﻿using Util.Ui.Angular.Renders;
using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.Timelines.Builders;

namespace Util.Ui.NgZorro.Components.Timelines.Renders {
    /// <summary>
    /// 时间轴节点渲染器
    /// </summary>
    public class TimelineItemRender : AngularRenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化时间轴节点渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public TimelineItemRender( Config config ) : base( config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new TimelineItemBuilder( _config );
            builder.Config();
            ConfigContent( builder );
            return builder;
        }
    }
}