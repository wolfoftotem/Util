﻿using Util.Ui.Angular.Renders;
using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.Anchors.Builders;

namespace Util.Ui.NgZorro.Components.Anchors.Renders {
    /// <summary>
    /// 链接渲染器
    /// </summary>
    public class LinkRender : AngularRenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化链接渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public LinkRender( Config config ) : base( config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new LinkBuilder( _config );
            builder.Config();
            ConfigContent( builder );
            return builder;
        }
    }
}