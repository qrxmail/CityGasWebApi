using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Task
{
    /// <summary>
    /// 设备运行异常上报
    /// </summary>
    public class ReportAbnormal
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid GId { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        public Guid DeviceId { get; set; }

        /// <summary>
        /// 异常内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 异常发生开始时间
        /// </summary>
        public DateTime OccurStartTime { get; set; }

        /// <summary>
        /// 异常发生结束时间
        /// </summary>
        public DateTime OccurEndTime { get; set; }

        /// <summary>
        /// 异常上报人
        /// </summary>
        public string ReportUser { get; set; }

        /// <summary>
        /// 是否报警
        /// </summary>
        public string IsAlarm { get; set; }

        /// <summary>
        /// 报警级别
        /// </summary>
        public string AlarmLevel{ get; set; }

        /// <summary>
        /// 警报处理人
        /// </summary>
        public string AlarmOper { get; set; }

        /// <summary>
        /// 警报处理结果
        /// </summary>
        public string AlarmOperResult { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        public string LastUpdateUser { get; set; }

    }


}





