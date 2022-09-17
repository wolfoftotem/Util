﻿using Util.Ui.Angular.Renders;
using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.Steps.Builders;

namespace Util.Ui.NgZorro.Components.Steps.Renders {
    /// <summary>
    /// 步骤条渲染器
    /// </summary>
    public class StepsRender : AngularRenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化步骤条渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public StepsRender( Config config ) : base( config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new StepsBuilder( _config );
            builder.Config();
            ConfigContent( builder );
            return builder;
        }
    }
}