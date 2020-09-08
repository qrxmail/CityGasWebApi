using System;

namespace CityGasWebApi.Models.OperRecord
{
    /// <summary>
    /// 发电机运行记录
    /// </summary>
    public class AlternatorRecord
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
        /// 市电停电时间
        /// </summary>
        public DateTime PowerOutageTime { get; set; }

        /// <summary>
        /// 市电来电时间
        /// </summary>
        public DateTime PowerInageTime { get; set; }

        /// <summary>
        /// 发电机开机时间
        /// </summary>
        public DateTime PowerStartTime { get; set; }

        /// <summary>
        /// 是否带负载
        /// </summary>
        public string IsLoadStr { get; set; }

        /// <summary>
        /// 蓄电池电压（V）
        /// </summary>
        public double BatteryVoltage { get; set; }

        /// <summary>
        /// 启动气压（kPa）
        /// </summary>
        public double StartingPressure { get; set; }

        /// <summary>
        /// 停机时间
        /// </summary>
        public DateTime DownTime { get; set; }

        /// <summary>
        /// 燃气用量
        /// </summary>
        public double GasConsumption { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public string OperUser { get; set; }

        /// <summary>
        /// 监护人
        /// </summary>
        public string Guardian { get; set; }
    }
}
