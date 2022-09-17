﻿using Util.Ui.Angular.Renders;
using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.NgZorro.Components.Tables.Builders;

namespace Util.Ui.NgZorro.Components.Tables.Renders {
    /// <summary>
    /// 表格主体渲染器
    /// </summary>
    public class TableBodyRender : AngularRenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化表格主体渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public TableBodyRender( Config config ) : base( config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new TableBodyBuilder( _config );
            builder.Config();
            return builder;
        }
    }
}