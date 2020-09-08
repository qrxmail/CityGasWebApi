using System;

namespace CityGasWebApi.Models.OperRecord
{
    /// <summary>
    /// 消防泵运行记录
    /// </summary>
    public class FirePumpRecord
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 生产设备ID
        /// </summary>
        public Guid MainDeviceId { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime RecordDate { get; set; }

        /// <summary>
        /// 人员
        /// </summary>
        public string RecordUser { get; set; }

        /// <summary>
        /// 启动水泵：1#泵
        /// </summary>
        public string StartWaterPumpOne { get; set; }

        /// <summary>
        /// 启动水泵：2#泵
        /// </summary>
        public string StartWaterPumpTwo { get; set; }

        /// <summary>
        /// 运行压力：1#泵(MPa)
        /// </summary>
        public double OperatingPressureOne { get; set; }

        /// <summary>
        /// 运行压力：2#泵(MPa)
        /// </summary>
        public double OperatingPressureTwo { get; set; }

        /// <summary>
        /// 运行时间：1#泵
        /// </summary>
        public double OperatingTimeOne { get; set; }

        /// <summary>
        /// 运行时间：2#泵
        /// </summary>
        public double OperatingTimeTwo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
