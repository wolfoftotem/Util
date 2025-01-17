﻿namespace Util.Microservices.Dapr.StateManagements;

/// <summary>
/// Dapr状态管理
/// </summary>
public class DaprStateManage : DaprStateManageBase<IStateManage>, IStateManage {
    /// <summary>
    /// 初始化Dapr状态管理
    /// </summary>
    /// <param name="client">Dapr客户端</param>
    /// <param name="options">Dapr配置</param>
    /// <param name="loggerFactory">日志工厂</param>
    /// <param name="keyGenerator">状态存储键生成器</param>
    public DaprStateManage( DaprClient client, IOptions<DaprOptions> options, ILoggerFactory loggerFactory, IKeyGenerator keyGenerator ) 
        : base(client,options,loggerFactory,keyGenerator){
    }

    /// <inheritdoc />
    public IStateManage OrderBy<T>( Expression<Func<T, object>> expression ) {
        Sort.OrderBy( expression );
        return this;
    }

    /// <inheritdoc />
    public IStateManage OrderByDescending<T>( Expression<Func<T, object>> expression ) {
        Sort.OrderByDescending( expression );
        return this;
    }

    /// <inheritdoc />
    public IStateManage Equal<T>( Expression<Func<T, object>> expression, object value ) {
        Filter.Equal( expression, value );
        return this;
    }

    /// <inheritdoc />
    public IStateManage In<T>( Expression<Func<T, object>> expression, IEnumerable<object> values ) {
        Filter.In( expression, values );
        return this;
    }

    /// <inheritdoc />
    public IStateManage In<T>( Expression<Func<T, object>> expression, params object[] values ) {
        Filter.In( expression, values );
        return this;
    }
}