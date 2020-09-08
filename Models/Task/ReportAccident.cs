using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Task
{
    /// <summary>
    /// 设备事故上报表
    /// </summary>
    public class ReportAccident
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
        /// 事故时间
        /// </summary>
        public DateTime OccurTime { get; set; }

        /// <summary>
        /// 事故原因简述
        /// </summary>
        public string AccidentContent { get; set; }

        /// <summary>
        /// 事故损失（元）
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// 事故性质
        /// </summary>
        public string Properties { get; set; }

        /// <summary>
        /// 事故责任人
        /// </summary>
        public string ResponseUser { get; set; }

        /// <summary>
        /// 事故分析和处理情况
        /// </summary>
        public string OperContent { get; set; }

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



