﻿using Util.Ui.Angular.Renders;
using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.Results.Builders;

namespace Util.Ui.NgZorro.Components.Results.Renders {
    /// <summary>
    /// 结果操作区渲染器
    /// </summary>
    public class ResultExtraRender : AngularRenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化结果操作区渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public ResultExtraRender( Config config ) : base( config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new ResultExtraBuilder( _config );
            builder.Config();
            ConfigContent( builder );
            return builder;
        }
    }
}