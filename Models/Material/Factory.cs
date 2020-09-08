using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Material
{
    /// <summary>
    /// 工厂信息
    /// </summary>
    public class Factory
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid GId { get; set; }

        /// <summary>
        /// 工厂名称
        /// </summary>
        public string FactoryName { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// 是否黑名单
        /// </summary>
        public string IsBlack { get; set; }

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
