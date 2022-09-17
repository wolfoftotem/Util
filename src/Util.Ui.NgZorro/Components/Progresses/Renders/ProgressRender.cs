﻿using Util.Ui.Angular.Renders;
using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.Progresses.Builders;

namespace Util.Ui.NgZorro.Components.Progresses.Renders {
    /// <summary>
    /// 进度条渲染器
    /// </summary>
    public class ProgressRender : AngularRenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化进度条渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public ProgressRender( Config config ) : base( config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new ProgressBuilder( _config );
            builder.Config();
            ConfigContent( builder );
            return builder;
        }
    }
}