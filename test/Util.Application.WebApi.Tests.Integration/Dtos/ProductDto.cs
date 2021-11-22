using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Util.Applications.Dtos {
    /// <summary>
    /// 产品参数
    /// </summary>
    public class ProductDto : DtoBase {
        /// <summary>
        /// 产品编码
        ///</summary>
        [Description( "产品编码" )]
        [Required(ErrorMessage = "产品编码不能为空")]
        [MaxLength( 50 )]
        public string Code { get; set; }
        /// <summary>
        /// 产品名称
        ///</summary>
        [Description( "产品名称" )]
        [Required(ErrorMessage = "产品名称不能为空")]
        [MaxLength( 500 )]
        public string Name { get; set; }
        /// <summary>
        /// 价格
        ///</summary>
        [Description( "价格" )]
        [Required(ErrorMessage = "价格不能为空")]
        public decimal Price { get; set; }
        /// <summary>
        /// 描述
        ///</summary>
        [Description( "描述" )]
        public string Description { get; set; }
        /// <summary>
        /// 启用
        ///</summary>
        [Description( "启用" )]
        public bool Enabled { get; set; }
        /// <summary>
        /// 创建时间
        ///</summary>
        [Description( "创建时间" )]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        ///</summary>
        [Description( "创建人" )]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        ///</summary>
        [Description( "最后修改时间" )]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        ///</summary>
        [Description( "最后修改人" )]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        ///</summary>
        [Description( "是否删除" )]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 版本号
        ///</summary>
        [Description( "版本号" )]
        public byte[] Version { get; set; }
    }
}