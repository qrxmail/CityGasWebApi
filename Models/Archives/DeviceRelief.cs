using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Archives
{
    /// <summary>
    /// 安全阀设备属性
    /// </summary>
    public class DeviceRelief
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
        /// 在站编号
        /// </summary>
        public string DeviceNo { get; set; }

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
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        public string Spec { get; set; }

        /// <summary>
        /// 型式
        /// </summary>
        public string Subtype { get; set; }

        /// <summary>
        /// 接口尺寸
        /// </summary>
        public string PortSize { get; set; }

        /// <summary>
        /// 生成厂家
        /// </summary>
        public string Factory { get; set; }

        /// <summary>
        /// 出厂编号
        /// </summary>
        public string FactoryNo { get; set; }

        /// <summary>
        /// 所属公司
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 投用日期
        /// </summary>
        public DateTime UseDate { get; set; }

        /// <summary>
        /// 检验周期（根据检验周期+使用日期计算下次检验日期：单位年）
        /// </summary>
        public double InspectCycle { get; set; }

        /// <summary>
        /// 设备要求整定压力
        /// </summary>
        public string RequirePress { get; set; }

        /// <summary>
        /// 安全阀铭牌注明整定压力
        /// </summary>
        public string CardPress { get; set; }

        /// <summary>
        /// 工艺要求整定压力
        /// </summary>
        public string ProcessPress { get; set; }

        /// <summary>
        /// 校验证书注明实际校验压力
        /// </summary>
        public string ActualPress { get; set; }

        /// <summary>
        /// 核准校验压力
        /// </summary>
        public string ApprovePress { get; set; }

        /// <summary>
        /// 压力等级
        /// </summary>
        public string PressLevel { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        public DateTime DueDate { get; set; }

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

