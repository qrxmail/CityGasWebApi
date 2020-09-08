using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Form
{
    /// <summary>
    /// 设备采购表单
    /// </summary>
    public class FormBuy
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid GId { get; set; }

        /// <summary>
        /// 单据编号
        /// </summary>
        public string FormNo { get; set; }

        /// <summary>
        /// 申购人
        /// </summary>
        public string ApplyUser { get; set; }

        /// <summary>
        /// 表单状态
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 申购时间
        /// </summary>
        public DateTime BuyDate { get; set; }

        /// <summary>
        /// 申购部门
        /// </summary>
        public string BuyDept { get; set; }


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
