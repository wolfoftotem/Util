﻿using Util.Ui.Angular.Renders;
using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.Layouts.Builders;

namespace Util.Ui.NgZorro.Components.Layouts.Renders {
    /// <summary>
    /// 顶部布局渲染器
    /// </summary>
    public class HeaderRender : AngularRenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化顶部布局渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public HeaderRender( Config config ) : base( config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new HeaderBuilder();
            ConfigContent( builder );
            return builder;
        }
    }
}