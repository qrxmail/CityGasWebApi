using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Archives
{
    /// <summary>
    /// 压力管道设备属性
    /// </summary>
    public class DevicePipe
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
        /// 管道名称
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
        /// 使用地点
        /// </summary>
        public string InstallAddress { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 管道规格
        /// </summary>
        public string Spec { get; set; }

        /// <summary>
        /// 管道材质
        /// </summary>
        public string Material { get; set; }

        /// <summary>
        /// 管道级别
        /// </summary>
        public string PipeLevel { get; set; }

        /// <summary>
        /// 公称直径
        /// </summary>
        public string Dia { get; set; }

        /// <summary>
        /// 安装单位
        /// </summary>
        public string InstallFactory { get; set; }

        /// <summary>
        /// 敷设方式
        /// </summary>
        public string InstallType { get; set; }

        /// <summary>
        /// 管道起点
        /// </summary>
        public string PipeStart { get; set; }

        /// <summary>
        /// 管道止点
        /// </summary>
        public string PipeEnd { get; set; }

        /// <summary>
        /// 累计长度
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// 安全状况
        /// </summary>
        public string SafeState { get; set; }

        /// <summary>
        /// 发证单位
        /// </summary>
        public string CertDept { get; set; }

        /// <summary>
        /// 发证日期
        /// </summary>
        public DateTime CertDate { get; set; }

        /// <summary>
        /// 下次全面检验时间
        /// </summary>
        public DateTime NextInspectDate { get; set; }

        /// <summary>
        /// 是否通气
        /// </summary>
        public string IsVentilate { get; set; }

        /// <summary>
        /// 资料情况
        /// </summary>
        public string MaterialState { get; set; }

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
        /// 管道状态
        /// </summary>
        public string State { get; set; }

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
        /// 建成日期
        /// </summary>
        public DateTime BuiltDate { get; set; }

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
        /// 省燃力中心报备时间
        /// </summary>
        public DateTime GasReportDate { get; set; }

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


