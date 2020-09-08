using System;

namespace CityGasWebApi.Models.OperRecord
{
    /// <summary>
    /// 压缩机运行记录详情（安瑞科）
    /// </summary>
    public class CompressEnricRecordDetail
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 压缩机运行记录表主键ID
        /// </summary>
        public Guid CompressEnricRecordId { get; set; }

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
        /// 压力（MPa）：水压
        /// </summary>
        public double WaterPressure { get; set; }

        /// <summary>
        /// 压力（MPa）：仪表风压力
        /// </summary>
        public double InstrumentAirPressure { get; set; }

        /// <summary>
        /// 压力（MPa）：回收罐压力
        /// </summary>
        public double RecoveryTankPressure { get; set; }

        /// <summary>
        /// 温度（℃）：一级排气
        /// </summary>
        public double ExhaustTemperatureOne { get; set; }

        /// <summary>
        /// 温度（℃）：二级排气
        /// </summary>
        public double ExhaustTemperatureTwo { get; set; }

        /// <summary>
        /// 温度（℃）：三级排气：一级
        /// </summary>
        public double ExhaustTemperatureThreeOne { get; set; }

        /// <summary>
        /// 温度（℃）：三级排气：二级
        /// </summary>
        public double ExhaustTemperatureThreeTwo { get; set; }

        /// <summary>
        /// 温度（℃）：油温
        /// </summary>
        public double OilTemperature { get; set; }

        /// <summary>
        /// 运行情况
        /// </summary>
        public string RunState { get; set; }

        /// <summary>
        /// 主电机电压（V）
        /// </summary>
        public string MainMotorVoltage { get; set; }

        /// <summary>
        /// 主电机电流（A）
        /// </summary>
        public string MainMotorElectricCurrent { get; set; }

        /// <summary>
        /// 储气井：高压井（MPa）
        /// </summary>
        public string HighPressureWell { get; set; }

        /// <summary>
        /// 储气井：中压井1（MPa）
        /// </summary>
        public string MiddlePressureWellOne { get; set; }

        /// <summary>
        /// 储气井：中压井2（MPa）
        /// </summary>
        public string MiddlePressureWellTwo { get; set; }


        /// <summary>
        /// 储气井：低压井（MPa）
        /// </summary>
        public string LowPressureWell { get; set; }

        /// <summary>
        /// 运行时间
        /// </summary>
        public string RunTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
