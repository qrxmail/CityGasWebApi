using System;

namespace CityGasWebApi.Models.OperRecord
{
    /// <summary>
    /// 干燥器运行记录详情
    /// </summary>
    public class DryerRecordDetail
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 干燥器运行记录表主键ID
        /// </summary>
        public Guid DryerRecordId { get; set; }

        /// <summary>
        /// 序号：考虑是否需要
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 运行时间
        /// </summary>
        public double RunTime { get; set; }

        /// <summary>
        /// 加热时间
        /// </summary>
        public double HeatingTime { get; set; }

        /// <summary>
        /// A塔／B塔：吸附
        /// </summary>
        public double Adsorbent { get; set; }

        /// <summary>
        /// A塔／B塔：再生
        /// </summary>
        public double Regenerate { get; set; }

        /// <summary>
        /// 温度（℃）：加热器出口
        /// </summary>
        public double HeaterOutlet { get; set; }

        /// <summary>
        /// 温度（℃）：冷却器出口
        /// </summary>
        public double CoolerOutlet { get; set; }

        /// <summary>
        /// 温度（℃）：再生器出口
        /// </summary>
        public double RegeneratorOutlet { get; set; }

        /// <summary>
        /// 温度（℃）：辅加热器表面
        /// </summary>
        public double AuxiliaryHeaterSurface { get; set; }

        /// <summary>
        /// 温度（℃）：主加热器表面
        /// </summary>
        public double MainHeaterSurface { get; set; }

        /// <summary>
        /// 电流(A)
        /// </summary>
        public double ElectricCurrent { get; set; }

        /// <summary>
        /// 露点（℃）
        /// </summary>
        public double DewPoint { get; set; }

        /// <summary>
        /// 缓冲罐压力（MPa）
        /// </summary>
        public double PressureOfDewPointBufferTank { get; set; }

        /// <summary>
        /// 缓冲罐温度（℃）
        /// </summary>
        public double BufferTankTemperature { get; set; }

        /// <summary>
        /// 排污
        /// </summary>
        public double Blowdown { get; set; }
    }
}
