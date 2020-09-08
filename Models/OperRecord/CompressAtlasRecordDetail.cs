using System;

namespace CityGasWebApi.Models.OperRecord
{
    /// <summary>
    /// 压缩机运行记录详情（阿塔拉斯）
    /// </summary>
    public class CompressAtlasRecordDetail
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 压缩机运行记录表主键ID
        /// </summary>
        public Guid CompressAtlasRecordId { get; set; }

        /// <summary>
        /// 序号：考虑是否需要
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime RecordTime { get; set; }

        /// <summary>
        /// 压力（MPa）:进气压力
        /// </summary>
        public double IntakePressure { get; set; }

        /// <summary>
        /// 压力（MPa）:一级排气
        /// </summary>
        public double ExhaustPressureOne { get; set; }

        /// <summary>
        /// 压力（MPa）:二级排气
        /// </summary>
        public double ExhaustPressureTwo { get; set; }

        /// <summary>
        /// 压力（MPa）:三级排气
        /// </summary>
        public double ExhaustPressureThree { get; set; }

        /// <summary>
        /// 压力（MPa）：油压
        /// </summary>
        public double OilPressure { get; set; }

        /// <summary>
        /// 温度（℃）：一级排气
        /// </summary>
        public double ExhaustTemperatureOne { get; set; }

        /// <summary>
        /// 温度（℃）：二级排气
        /// </summary>
        public double ExhaustTemperatureTwo { get; set; }

        /// <summary>
        /// 温度（℃）：三级排气
        /// </summary>
        public double ExhaustTemperatureThree { get; set; }

        /// <summary>
        /// 温度（℃）：油温
        /// </summary>
        public double OilTemperature { get; set; }

        /// <summary>
        /// 运行情况
        /// </summary>
        public string RunState { get; set; }

        /// <summary>
        /// 主电机电压
        /// </summary>
        public string MainMotorVoltage { get; set; }

        /// <summary>
        /// 主电机电流
        /// </summary>
        public string MainMotorElectricCurrent { get; set; }

        /// <summary>
        /// 储气井：高压井（MPa）
        /// </summary>
        public string HighPressureWell { get; set; }

        /// <summary>
        /// 储气井：中压井（MPa）
        /// </summary>
        public string MiddlePressureWell { get; set; }

        /// <summary>
        /// 储气井：低压井1（MPa）
        /// </summary>
        public string LowPressureWellOne { get; set; }

        /// <summary>
        /// 储气井：低压井2（MPa）
        /// </summary>
        public string LowPressureWellTwo { get; set; }

        /// <summary>
        /// 运行时间
        /// </summary>
        public string RunTime { get; set; }

        /// <summary>
        /// 可燃气体浓度（%LEL）
        /// </summary>
        public double CombustibleGasConcentration { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
