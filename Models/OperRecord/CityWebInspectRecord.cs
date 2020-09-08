using System;

namespace CityGasWebApi.Models.OperRecord
{
    /// <summary>
    /// 城区管网日常巡检记录
    /// </summary>
    public class CityWebInspectRecord
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 日期时间（分开两栏）
        /// </summary>
        public DateTime InpectDateTime { get; set; }

        /// <summary>
        /// 巡检区域：线路
        /// </summary>
        public string Line { get; set; }

        /// <summary>
        /// 巡检区域：重点部位
        /// </summary>
        public string KeyPart { get; set; }

        /// <summary>
        /// 巡检情况
        /// </summary>
        public string InspectSituation { get; set; }

        /// <summary>
        /// 问题处理情况
        /// </summary>
        public string ProblemHandling { get; set; }

        /// <summary>
        /// 巡检人
        /// </summary>
        public string InspectUser { get; set; }

    }
}
