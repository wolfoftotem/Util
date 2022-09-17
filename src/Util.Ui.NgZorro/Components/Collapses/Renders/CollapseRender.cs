﻿using Util.Ui.Angular.Renders;
using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.Collapses.Builders;

namespace Util.Ui.NgZorro.Components.Collapses.Renders {
    /// <summary>
    /// 折叠渲染器
    /// </summary>
    public class CollapseRender : AngularRenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化折叠渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public CollapseRender( Config config ) : base( config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new CollapseBuilder( _config );
            builder.Config();
            ConfigContent( builder );
            return builder;
        }
    }
}