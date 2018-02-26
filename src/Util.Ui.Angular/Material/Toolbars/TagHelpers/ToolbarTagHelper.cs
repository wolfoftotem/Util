﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Util.Ui.Configs;
using Util.Ui.Material.Enums;
using Util.Ui.Material.Toolbars.Renders;
using Util.Ui.Renders;
using Util.Ui.TagHelpers;

namespace Util.Ui.Material.Toolbars.TagHelpers {
    /// <summary>
    /// 工具栏
    /// </summary>
    [HtmlTargetElement( "util-toolbar" )]
    public class ToolbarTagHelper : TagHelperBase {
        /// <summary>
        /// 颜色
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="context">上下文</param>
        protected override IRender GetRender( Context context ) {
            return new ToolbarRender( new Config( context ) );
        }
    }
}