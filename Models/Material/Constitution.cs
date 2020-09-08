using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Material
{
    /// <summary>
    /// 章程信息表
    /// </summary>
    public class Constitution
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid GId { get; set; }

        /// <summary>
        /// 章程名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 章程内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 章程类别（维修保养、校验检修、其他）
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        public DateTime UploadTime { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PublishTime { get; set; }

        /// <summary>
        /// 是否需要审核
        /// </summary>
        public string IsCheck { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public string CheckState { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        public string LastUpdateUser { get; set; }


    }
}


