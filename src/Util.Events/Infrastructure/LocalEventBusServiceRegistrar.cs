﻿using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Util.Events.Local;
using Util.Infrastructure;
using Util.Reflections;

namespace Util.Events.Infrastructure {
    /// <summary>
    /// 本地事件总线服务注册器
    /// </summary>
    public class LocalEventBusServiceRegistrar : IServiceRegistrar {
        /// <summary>
        /// 获取标识
        /// </summary>
        public static int GetId() => 510;

        /// <summary>
        /// 标识
        /// </summary>
        public int Id => GetId();

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enabled => ServiceRegistrarConfig.Instance.IsEnabled( GetId() );

        /// <summary>
        /// 注册服务
        /// </summary>
        /// <param name="services">服务集合</param>
        /// <param name="configuration">配置</param>
        /// <param name="finder">类型查找器</param>
        public Action Register( IServiceCollection services, IConfiguration configuration, ITypeFinder finder ) {
            RegisterDependency( services );
            RegisterEventHandlers( services, finder );
            return null;
        }

        /// <summary>
        /// 注册依赖
        /// </summary>
        private void RegisterDependency( IServiceCollection services ) {
            services.TryAddSingleton<ILocalEventBus, LocalEventBus>();
            services.TryAddSingleton<IEventBus, LocalEventBus>();
        }

        /// <summary>
        /// 注册事件处理器
        /// </summary>
        private void RegisterEventHandlers( IServiceCollection services, ITypeFinder finder ) {
            Type handlerType = typeof(IEventHandler<>);
            var handlerTypes = GetTypes( finder,handlerType );
            foreach( var handler in handlerTypes ) {
                var serviceTypes = handler.FindInterfaces( ( filter, criteria ) => criteria != null && filter.IsGenericType && ( (Type)criteria ).IsAssignableFrom( filter.GetGenericTypeDefinition() ), handlerType );
                serviceTypes.ToList().ForEach( serviceType => services.AddScoped( serviceType, handler ) );
            }
        }

        /// <summary>
        /// 获取类型集合
        /// </summary>
        private Type[] GetTypes( ITypeFinder finder,Type type ) {
            return finder.Find( type ).ToArray();
        }
    }
}