using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Archives
{
    /// <summary>
    /// 压力容器设备属性
    /// </summary>
    public class DevicePress
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid GId { get; set; }

        /// <summary>
        /// 主设备ID
        /// </summary>
        public Guid DeviceId { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备类型（大类：输气专用设备、动力设备、输气管线、自动化设备）需要收纳资产类别12类：参考资产管理制度
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备类型（小类：压力容器、除尘分离设备、阴极保护设备、减压撬和其他输气专用设备（管线中的阀门、阀井、调压箱和调压柜）；
        /// 发电机组、变电设备、配电设备、锅炉、天然气压缩机、其他动力设备；
        /// 输气主管线、工艺管网和压力管道；
        /// 自动控制设备、电子计算机外部设备、其他自动化设备）
        /// </summary>
        public string DeviceType1 { get; set; }

        /// <summary>
        /// 安装位置、使用地点（比如场站、加气站...）
        /// </summary>
        public string InstallAddress { get; set; }

        /// <summary>
        /// 使用部位(比如减压撬一支路一级调压后、压缩机....)
        /// </summary>
        public string UsePart { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
      
        /// <summary>
        /// 规格型号
        /// </summary>
        public string Spec { get; set; }

        /// <summary>
        /// 生成厂家
        /// </summary>
        public string Factory { get; set; }

        /// <summary>
        /// 出厂日期
        /// </summary>
        public DateTime FactoryDate { get; set; }

        /// <summary>
        /// 出厂编号
        /// </summary>
        public string FactoryNo { get; set; }

        /// <summary>
        /// 投用日期
        /// </summary>
        public DateTime UseDate { get; set; }

        /// <summary>
        /// 是否重点部位关键装置
        /// </summary>
        public string IsKeyPart { get; set; }

        /// <summary>
        /// 所属公司
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 设备状态
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 压力容器类别
        /// </summary>
        public string PressType { get; set; }

        /// <summary>
        /// 使用登记证编号
        /// </summary>
        public string UseRegistNo { get; set; }

        /// <summary>
        /// 发证单位
        /// </summary>
        public string LicensesCompany { get; set; }

        /// <summary>
        /// 检验周期（根据检验周期+使用日期计算下次检验日期：单位年）
        /// </summary>
        public double InspectCycle { get; set; }

        /// <summary>
        /// 下次检验日期
        /// </summary>
        public DateTime NextInspectDate { get; set; }

        /// <summary>
        /// 手续办理情况
        /// </summary>
        public string Formalities { get; set; }

        /// <summary>
        /// 安装告知日期
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        /// 监督检查日期
        /// </summary>
        public DateTime SuperviseInspectDate { get; set; }

        /// <summary>
        /// 安装完成日期
        /// </summary>
        public DateTime InstallFinishDate { get; set; }

        /// <summary>
        /// 中间验交日期
        /// </summary>
        public DateTime MiddleAcceptDate { get; set; }

        /// <summary>
        /// 竣工验收日期
        /// </summary>
        public DateTime AcceptDate { get; set; }

        /// <summary>
        /// 使用登记注册日期
        /// </summary>
        public DateTime UseRegistDate { get; set; }

        /// <summary>
        /// 年度检查时间
        /// </summary>
        public DateTime YearInspectDate { get; set; }

        /// <summary>
        /// 当地政府管理部门报备时间
        /// </summary>
        public DateTime LocalReportDate { get; set; }

        /// <summary>
        /// 供货单位
        /// </summary>
        public string SupplyDept { get; set; }

        /// <summary>
        /// 其他参数
        /// </summary>
        public string OtherParams { get; set; }

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

