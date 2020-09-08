using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Form
{
    /// <summary>
    /// 设备报废表单
    /// </summary>
    public class FormScrap
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
        /// 申请人
        /// </summary>
        public string ApplyUser { get; set; }

        /// <summary>
        /// 表单状态
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        public Guid DeviceId { get; set; }

        /// <summary>
        /// 报废日期
        /// </summary>
        public DateTime ScrapDate { get; set; }

        /// <summary>
        /// 资产编号
        /// </summary>
        public string AssetNo { get; set; }

        /// <summary>
        /// 使用单位
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 生产厂家
        /// </summary>
        public string Factory { get; set; }

        /// <summary>
        /// 出厂编号
        /// </summary>
        public string FactoryNo { get; set; }

        /// <summary>
        /// 出厂日期
        /// </summary>
        public DateTime FactoryDate { get; set; }

        /// <summary>
        /// 型号规格
        /// </summary>
        public string Spec { get; set; }

        /// <summary>
        /// 经济用途（对应设备表的属性：作用）
        /// </summary>
        public string Function { get; set; }

        /// <summary>
        /// 立卡时间
        /// </summary>
        public string CardDate { get; set; }

        /// <summary>
        /// 使用年限
        /// </summary>
        public string UseYears { get; set; }

        /// <summary>
        /// 累计折旧（元）
        /// </summary>
        public double SumDeprec { get; set; }

        /// <summary>
        /// 原值（元）
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// 净值（元）
        /// </summary>
        public double NetCost { get; set; }

        /// <summary>
        /// 净残值
        /// </summary>
        public double NetSalvageCost { get; set; }

        /// <summary>
        /// 清理费用
        /// </summary>
        public double CleanCost { get; set; }

        /// <summary>
        /// 清理单位
        /// </summary>
        public string CleanDept { get; set; }

        /// <summary>
        /// 原因
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 技术鉴定
        /// </summary>
        public string TechAppr { get; set; }

        /// <summary>
        /// 可利用的主要部件
        /// </summary>
        public string Available { get; set; }

        /// <summary>
        /// 使用部门意见
        /// </summary>
        public string UseDeptOpinion { get; set; }

        /// <summary>
        /// 生产技术管理部意见
        /// </summary>
        public string ManagerOpinion { get; set; }

        /// <summary>
        /// 工程及物资管理部意见
        /// </summary>
        public string ProjectOpinion { get; set; }

        /// <summary>
        /// 分管领导意见
        /// </summary>
        public string LeaderOpinion { get; set; }

        /// <summary>
        /// 总经理意见
        /// </summary>
        public string GenLeaderOpinion { get; set; }

        /// <summary>
        /// 执行董事意见
        /// </summary>
        public string DirectorOpinion { get; set; }

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
