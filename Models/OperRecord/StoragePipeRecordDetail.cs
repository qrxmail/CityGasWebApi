using System;

namespace CityGasWebApi.Models.OperRecord
{
    /// <summary>
    /// 储配站运行记录详情（管道）
    /// </summary>
    public class StoragePipeRecordDetail
    {
        public Guid Id { get; set; }

        /// <summary>
        ///储配站运行记录表（管道）主键ID
        /// </summary>
        public Guid StoragePipeRecordId { get; set; }

        /// <summary>
        /// 序号：考虑是否需要
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime RecordTime { get; set; }

        /// <summary>
        /// 进站压力（MPa）
        /// </summary>
        public double InletPressure { get; set; }

        /// <summary>
        /// 进站温度（℃）
        /// </summary>
        public double InletTemperature { get; set; }

        /// <summary>
        /// 一级调压阀后压力（MPa）
        /// </summary>
        public double RegulatPressureOne { get; set; }

        /// <summary>
        /// 一级调压阀后温度（℃）
        /// </summary>
        public double RegulatTemperatureOne { get; set; }

        /// <summary>
        /// 二级调压阀后压力（MPa）
        /// </summary>
        public double RegulatPressureTwo { get; set; }

        /// <summary>
        /// 二级调压阀后温度（℃）
        /// </summary>
        public double RegulatTemperatureTwo { get; set; }

        /// <summary>
        /// 过滤器压差（kPa）
        /// </summary>
        public double FilterDifferentPressure { get; set; }

        /// <summary>
        /// 瞬时流量（Nm³/h）
        /// </summary>
        public double InstantaneousFlow { get; set; }

        /// <summary>
        /// 累计流量（Nm³/h）
        /// </summary>
        public double TotalFlow { get; set; }

        /// <summary>
        /// 出站压力（MPa）
        /// </summary>
        public double OutPressure { get; set; }

        /// <summary>
        /// 出站温度（℃）
        /// </summary>
        public double OutTemperature { get; set; }

        /// <summary>
        /// 运行支路
        /// </summary>
        public string OperationBranch { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
