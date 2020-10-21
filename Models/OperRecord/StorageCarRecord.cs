using System;

namespace CityGasWebApi.Models.OperRecord
{
    /// <summary>
    /// 储配站运行记录（槽车）
    /// </summary>
    public class StorageCarRecord
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
        /// 供气方式
        /// </summary>
        public string GasSupplyMode { get; set; }

        /// <summary>
        /// 当日累计用气量（Nm³）
        /// </summary>
        public decimal TotalGas  { get; set; }

        /// <summary>
        /// 自用气（Nm³）
        /// </summary>
        public decimal SelfUseGas { get; set; }

        /// <summary>
        /// 放空（Nm³）
        /// </summary>
        public decimal Venting { get; set; }

        /// <summary>
        /// 加臭机运行时间
        /// </summary>
        public decimal OdorizerRunTime { get; set; }

        /// <summary>
        /// 加臭剂量(mg)
        /// </summary>
        public decimal OdorantDosage { get; set; }

        /// <summary>
        /// 排污情况
        /// </summary>
        public string PollutionDischarge { get; set; }

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
