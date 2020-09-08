using System;

namespace CityGasWebApi.Models.OperRecord
{
    /// <summary>
    /// 发电机运行记录详情
    /// </summary>
    public class AlternatorRecordDetail
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 发电机运行记录表主键ID
        /// </summary>
        public Guid AlternatorRecordId { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime RecordTime { get; set; }

        /// <summary>
        /// 频率（HZ）
        /// </summary>
        public double Frequency { get; set; }

        /// <summary>
        /// 电压（Ｖ）
        /// </summary>
        public double Voltage { get; set; }

        /// <summary>
        /// 电流（A）
        /// </summary>
        public double ElectricCurrent { get; set; }

        /// <summary>
        /// 油压（Psi）
        /// </summary>
        public double OilPressure { get; set; }

        /// <summary>
        /// 水温（℃）
        /// </summary>
        public double WaterTemperature { get; set; }

    }
}
