﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Util.Configs;

namespace Util.Logging.Serilog {
    /// <summary>
    /// Serilog日志操作配置扩展
    /// </summary>
    public class SerilogOptionsExtension : OptionsExtensionBase {
        /// <summary>
        /// 是否清除日志提供程序
        /// </summary>
        private readonly bool _isClearProviders;

        /// <summary>
        /// 初始化Serilog日志操作配置扩展
        /// </summary>
        /// <param name="isClearProviders">是否清除日志提供程序</param>
        public SerilogOptionsExtension( bool isClearProviders ) {
            _isClearProviders = isClearProviders;
        }

        /// <inheritdoc />
        public override void ConfigureServices( HostBuilderContext context, IServiceCollection services ) {
            services.AddTransient( typeof( ILog<> ), typeof( Log<> ) );
            services.AddTransient( typeof( ILoggerWrapper<> ), typeof( LoggerWrapper<> ) );
            var configuration = context.Configuration;
            services.AddLogging( loggingBuilder => {
                if ( _isClearProviders )
                    loggingBuilder.ClearProviders();
                Log.Logger = new LoggerConfiguration()
                    .Enrich.FromLogContext()
                    .Enrich.WithLogLevel()
                    .Enrich.WithLogContext()
                    .ReadFrom.Configuration( configuration )
                    .ConfigLogLevel( configuration )
                    .CreateLogger();
                loggingBuilder.AddSerilog();
            } );
        }
    }
}
