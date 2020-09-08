using System;

namespace CityGasWebApi.Models.OperRecord
{
    /// <summary>
    /// 锅炉运行记录
    /// </summary>
    public class BoilerRecord
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
        /// 当日锅炉用气量
        /// </summary>
        public double GasConsumptionBoiler { get; set; }

        /// <summary>
        /// 存在问题及注意事项
        /// </summary>
        public string Precautions { get; set; }

        /// <summary>
        /// 早班值班人员
        /// </summary>
        public string MorningDutyOfficer { get; set; }

        /// <summary>
        /// 晚班值班人员
        /// </summary>
        public string EveningDutyOfficer { get; set; }

    }
}
