using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Material
{
    /// <summary>
    /// 工厂评分
    /// </summary>
    public class FactoryScore
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid GId { get; set; }

        /// <summary>
        /// 工厂ID
        /// </summary>
        public Guid FactoryID { get; set; }

        /// <summary>
        /// 评分
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// 评论
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 评价人
        /// </summary>
        public string CommentUser { get; set; }

        /// <summary>
        /// 评价时间
        /// </summary>
        public DateTime CommentTime { get; set; }

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
