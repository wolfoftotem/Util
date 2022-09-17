﻿using Util.Ui.Angular.Renders;
using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.Grids.Builders;

namespace Util.Ui.NgZorro.Components.Grids.Renders {
    /// <summary>
    /// 栅格行渲染器
    /// </summary>
    public class RowRender : AngularRenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化栅格行渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public RowRender( Config config ) : base( config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new RowBuilder( _config );
            builder.Config();
            ConfigContent( builder );
            return builder;
        }
    }
}