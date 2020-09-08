using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Archives
{
    /// <summary>
    /// 设备密封点信息
    /// </summary>
    public class DevicePoint
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid GId { get; set; }

        /// <summary>
        /// 设备表名称（可能是不同的设备的密封点信息，不同设备用了不同的表）
        /// </summary>
        public string TableName { get; set; }

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
        /// 线路名称
        /// </summary>
        public string InstallLineName { get; set; }

        /// <summary>
        /// 动密封点数
        /// </summary>
        public int DynamicPoint { get; set; }

        /// <summary>
        /// 静密封点数
        /// </summary>
        public int StaticPoint { get; set; }

        /// <summary>
        /// 其他密封部位名称
        /// </summary>
        public string OtherPointName { get; set; }

        /// <summary>
        /// 其他动密封点数
        /// </summary>
        public int OtherDynamicPoint { get; set; }

        /// <summary>
        /// 其他静密封点数
        /// </summary>
        public int OtherStaticPoint { get; set; }

        /// <summary>
        /// 钢制阀井数量
        /// </summary>
        public int SteelValveCount { get; set; }

        /// <summary>
        /// 钢制阀井动密封点数
        /// </summary>
        public int SteelDynamicPoint { get; set; }

        /// <summary>
        /// 钢制阀井静密封点数
        /// </summary>
        public int SteelStaticPoint { get; set; }

        /// <summary>
        /// PE阀井数量
        /// </summary>
        public int PeValveCount { get; set; }

        /// <summary>
        /// 单放散球阀井数量
        /// </summary>
        public int SingularValveCount { get; set; }

        /// <summary>
        /// 单放散球阀动密封点数
        /// </summary>
        public int SingularDynamicPoint { get; set; }

        /// <summary>
        /// 单放散球阀静密封点数
        /// </summary>
        public int SingularStaticPoint { get; set; }

        /// <summary>
        /// 标准球阀阀井数量
        /// </summary>
        public int StandardValveCount { get; set; }

        /// <summary>
        /// 标准球阀阀动密封点数
        /// </summary>
        public int StandardDynamicPoint { get; set; }

        /// <summary>
        /// 标准球阀阀静密封点数
        /// </summary>
        public int StandardStaticPoint { get; set; }

        /// <summary>
        /// 双放散球阀阀井数量
        /// </summary>
        public int DualValveCount { get; set; }

        /// <summary>
        /// 双放散球阀动密封点数
        /// </summary>
        public int DualDynamicPoint { get; set; }

        /// <summary>
        /// 双放散球阀静密封点数
        /// </summary>
        public int DualStaticPoint { get; set; }

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

