using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Form
{
    /// <summary>
    /// 设备封存表单
    /// </summary>
    public class FormSeal
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid GId { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        public Guid DeviceId { get; set; }

        /// <summary>
        /// 单据编号
        /// </summary>
        public string FormNo { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        public string ApplyUser { get; set; }

        /// <summary>
        /// 表单状态
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 封存日期
        /// </summary>
        public DateTime SealDate { get; set; }

        /// <summary>
        /// 封存单位
        /// </summary>
        public string SealDept { get; set; }

        /// <summary>
        /// 封存地点
        /// </summary>
        public string SealAddr { get; set; }

        /// <summary>
        /// 出厂编号
        /// </summary>
        public string FactoryNo { get; set; }

        /// <summary>
        /// 型号规格
        /// </summary>
        public string Spec { get; set; }

        /// <summary>
        /// 立卡时间
        /// </summary>
        public string CardDate { get; set; }

        /// <summary>
        /// 使用年限
        /// </summary>
        public string UseYears { get; set; }

        /// <summary>
        /// 原值（元）
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// 净值（元）
        /// </summary>
        public double NetCost { get; set; }

        /// <summary>
        /// 封存前资产状况
        /// </summary>
        public string SealStateDesc { get; set; }

        /// <summary>
        /// 封存原因
        /// </summary>
        public string SealReason { get; set; }

        /// <summary>
        /// 生产技术部意见
        /// </summary>
        public string ManagerOpinion { get; set; }

        /// <summary>
        /// 分管领导意见
        /// </summary>
        public string LeaderOpinion { get; set; }


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
