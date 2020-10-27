using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Archives
{
    /// <summary>
    /// 履历设备（主设备）属性
    /// </summary>
    public class Device
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid GId { get; set; }

        /// <summary>
        /// 资产编码（管理编号）
        /// </summary>
        public string AssetNo { get; set; }

        /// <summary>
        /// 折旧信息
        /// </summary>
        public string Depreciation { get; set; }

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
        /// 作用
        /// </summary>
        public string Function { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        public string Spec { get; set; }

        /// <summary>
        /// 设备能力
        /// </summary>
        public string Ability { get; set; }

        /// <summary>
        /// 生成厂家
        /// </summary>
        public string Factory { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string FacPhone { get; set; }

        /// <summary>
        /// 出厂日期
        /// </summary>
        public DateTime FactoryDate { get; set; }

        /// <summary>
        /// 调试完成日期
        /// </summary>
        public DateTime DebugFinishDate { get; set; }

        /// <summary>
        /// 出厂编号
        /// </summary>
        public string FactoryNo { get; set; }

        /// <summary>
        /// 重量(kg)
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// 尺寸
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime BuyDate { get; set; }

        /// <summary>
        /// 购置合同号
        /// </summary>
        public string BuyContractNo { get; set; }

        /// <summary>
        /// 投用日期
        /// </summary>
        public DateTime UseDate { get; set; }

        /// <summary>
        /// 到货日期
        /// </summary>
        public DateTime ArrivalDate { get; set; }

        /// <summary>
        /// 验收日期
        /// </summary>
        public DateTime AcceptDate { get; set; }

        /// <summary>
        /// 质保期:单位为年(验收日期+质保期=质保金到期时间，到期要提醒)
        /// </summary>
        public double QualityYears { get; set; }

        /// <summary>
        /// 设备来源
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        public string ResponseUser { get; set; }

        /// <summary>
        /// 是否特种设备
        /// </summary>
        public string IsSpecial { get; set; }

        /// <summary>
        /// 是否重点部位关键装置
        /// </summary>
        public string IsKeyPart { get; set; }

        /// <summary>
        /// 操作人持证情况
        /// </summary>
        public string HolderSituation { get; set; }

        /// <summary>
        /// 所属公司
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 设备状态
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 设备原值（元）
        /// </summary>
        public double Cost { get; set; }

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
        /// 手续办理情况
        /// </summary>
        public string Formalities { get; set; }


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

    public class DeviceView : Device
    {
        public string InspectName { get; set; }
    }
}
