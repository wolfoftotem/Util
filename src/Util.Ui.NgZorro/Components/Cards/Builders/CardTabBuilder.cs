﻿using Util.Ui.Builders;
using Util.Ui.Configs;

namespace Util.Ui.NgZorro.Components.Cards.Builders {
    /// <summary>
    /// 卡片标签页标签生成器
    /// </summary>
    public class CardTabBuilder : TagBuilder {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly Config _config;

        /// <summary>
        /// 初始化卡片标签页标签生成器
        /// </summary>
        public CardTabBuilder( Config config ) : base( "nz-card-tab" ) {
            _config = config;
        }
    }
}