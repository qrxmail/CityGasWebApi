using System;

namespace CityGasWebApi.Models.OperRecord
{
    /// <summary>
    /// 压缩机运行记录（阿塔拉斯）
    /// </summary>
    public class CompressAtlasRecord
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 生产设备ID
        /// </summary>
        public Guid MainDeviceId { get; set; }

        /// <summary>
        /// 天气
        /// </summary>
        public string Weather { get; set; }

        /// <summary>
        /// 气温
        /// </summary>
        public string Temperature { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime RecordDate { get; set; }

        /// <summary>
        /// 本班运行时间
        /// </summary>
        public decimal RunTime { get; set; }

        /// <summary>
        /// 累计运行时间
        /// </summary>
        public decimal SumRunTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

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
