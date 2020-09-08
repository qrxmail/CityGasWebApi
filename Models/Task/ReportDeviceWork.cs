using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Task
{
    /// <summary>
    /// 设备运转记录上报表（减压撬，其他设备属性不同，需要根据需求各自建表）
    /// </summary>
    public class ReportDeviceWork
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
        /// 月份
        /// </summary>
        public string Month { get; set; }

        /// <summary>
        /// 运转小时
        /// </summary>
        public int WorkHours { get; set; }

        /// <summary>
        /// 当月输气量（Nm³）
        /// </summary>
        public double CurrentMonth { get; set; }

        /// <summary>
        /// 累计输气量（Nm³）
        /// </summary>
        public double Sum { get; set; }

        /// <summary>
        /// 加臭剂消耗(g）
        /// </summary>
        public double Odorant { get; set; }

        /// <summary>
        /// 共计利用天数
        /// </summary>
        public int SumWorkDays { get; set; }

        /// <summary>
        /// 工作天数
        /// </summary>
        public int WorkDays { get; set; }

        /// <summary>
        /// 维修保养（天）
        /// </summary>
        public int MaintenDays { get; set; }

        /// <summary>
        /// 待料待修（天）
        /// </summary>
        public int WaitDays { get; set; }

        /// <summary>
        /// 其他停用（天）
        /// </summary>
        public int OtherDays { get; set; }

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



