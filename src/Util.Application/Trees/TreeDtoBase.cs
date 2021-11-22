﻿using System.ComponentModel;
using Util.Applications.Dtos;

namespace Util.Applications.Trees {
    /// <summary>
    /// 树形参数
    /// </summary>
    public abstract class TreeDtoBase : DtoBase, ITreeNode {
        /// <summary>
        /// 父标识
        /// </summary>
        public string ParentId { get; set; }
        /// <summary>
        /// 父名称
        /// </summary>
        [Description( "父名称" )]
        public string ParentName { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 层级
        /// </summary>
        public int? Level { get; set; }
        /// <summary>
        /// 启用
        /// </summary>
        [Description( "启用" )]
        public bool? Enabled { get; set; } = true;
        /// <summary>
        /// 排序号
        /// </summary>
        [Description( "排序号" )]
        public int? SortId { get; set; }
        /// <summary>
        /// 是否展开
        /// </summary>
        [Description( "是否展开" )]
        public bool? Expanded { get; set; }
    }
}
