﻿using Util.Ui.Configs;
using Util.Ui.Extensions;
using Util.Ui.NgZorro.Components.Tables.Helpers;

namespace Util.Ui.NgZorro.Components.Tables.Builders {
    /// <summary>
    /// 表头行标签生成器
    /// </summary>
    public class TableHeadRowBuilder : TableRowBuilder {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化表格主体行标签生成器
        /// </summary>
        public TableHeadRowBuilder( Config config ) : base( config ) {
            _config = config;
        }

        /// <summary>
        /// 配置
        /// </summary>
        public override void Config() {
            base.Config();
            ConfigAutoCreate();
            ConfigContent();
        }

        /// <summary>
        /// 配置自动创建嵌套结构
        /// </summary>
        public void ConfigAutoCreate() {
            var service = new TableHeadRowAutoCreateService( this );
            service.Init();
        }

        /// <summary>
        /// 配置内容
        /// </summary>
        public void ConfigContent() {
            if ( GetTableShareConfig().HeadColumnAutoCreated )
                return;
            _config.Content.AppendTo( this );
        }
    }
}