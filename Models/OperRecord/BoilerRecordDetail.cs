using System;

namespace CityGasWebApi.Models.OperRecord
{
    /// <summary>
    /// 锅炉运行记录详情
    /// </summary>
    public class BoilerRecordDetail
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 锅炉运行记录表主键ID
        /// </summary>
        public Guid BoilerRecordId { get; set; }

        /// <summary>
        /// 序号：考虑是否需要
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime RecordTime { get; set; }

        /// <summary>
        /// 锅炉（1#/2#）
        /// </summary>
        public string BoilerState { get; set; }

        /// <summary>
        /// 循环泵（1#/2#）
        /// </summary>
        public string CirculatingPumpState { get; set; }

        /// <summary>
        /// 出水压力（MPa）
        /// </summary>
        public double OutletPressure { get; set; }

        /// <summary>
        /// 进气压力（kPa）
        /// </summary>
        public double IntakePressure { get; set; }

        /// <summary>
        /// 出水温度（℃）
        /// </summary>
        public double OutletTemperature { get; set; }

        /// <summary>
        /// 回水温度（℃）
        /// </summary>
        public double BackWaterTemperature { get; set; }

        /// <summary>
        /// 累计流量（Nm³）
        /// </summary>
        public double CumulativeFlow { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
