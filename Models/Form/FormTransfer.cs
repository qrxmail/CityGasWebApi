using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Form
{
    /// <summary>
    /// 设备移交表单
    /// </summary>
    public class FormTransfer
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
        /// 设备名称
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        public string Spec { get; set; }

        /// <summary>
        /// 设备来源
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 出厂编号
        /// </summary>
        public string FactoryNo { get; set; }

        /// <summary>
        /// 出厂日期
        /// </summary>
        public DateTime FactoryDate { get; set; }

        /// <summary>
        /// 生成厂家
        /// </summary>
        public string Factory { get; set; }

        /// <summary>
        /// 移交单位
        /// </summary>
        public string TransDept { get; set; }

        /// <summary>
        /// 移交日期
        /// </summary>
        public DateTime TransDate { get; set; }

        /// <summary>
        /// 接收单位
        /// </summary>
        public string AcceptDept { get; set; }

        /// <summary>
        /// 接收/验收日期
        /// </summary>
        public DateTime AcceptDate { get; set; }

        /// <summary>
        /// 重量(kg)
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// 尺寸
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// 主要验收项目及参数
        /// </summary>
        public string AcceptParams { get; set; }

        /// <summary>
        /// 资料、附件、备品备件、随机工具等是否齐全，有关证书、报告等是否有效
        /// </summary>
        public string AcceptDesc { get; set; }

        /// <summary>
        /// 移交验收结论
        /// </summary>
        public string AcceptResult { get; set; }

        /// <summary>
        /// 生产部负责人
        /// </summary>
        public string ResponsUser { get; set; }

        /// <summary>
        /// 生产部负责人审批日期
        /// </summary>
        public DateTime ResponsDate { get; set; }

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
