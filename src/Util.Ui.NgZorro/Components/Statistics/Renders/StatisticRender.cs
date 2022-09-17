﻿using Util.Ui.Angular.Renders;
using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.Statistics.Builders;

namespace Util.Ui.NgZorro.Components.Statistics.Renders {
    /// <summary>
    /// 统计渲染器
    /// </summary>
    public class StatisticRender : AngularRenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化统计渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public StatisticRender( Config config ) : base( config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new StatisticBuilder( _config );
            builder.Config();
            ConfigContent( builder );
            return builder;
        }
    }
}