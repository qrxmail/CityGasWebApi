using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Task
{
    /// <summary>
    /// 设备故障上报表
    /// </summary>
    public class ReportBug
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
        /// 故障内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 故障发生开始时间
        /// </summary>
        public DateTime OccurStartTime { get; set; }

        /// <summary>
        /// 故障发生结束时间
        /// </summary>
        public DateTime OccurEndTime { get; set; }

        /// <summary>
        /// 故障上报人
        /// </summary>
        public string ReportUser { get; set; }

        /// <summary>
        /// 是否报修
        /// </summary>
        public string IsMainten { get; set; }

        /// <summary>
        /// 修理处理人
        /// </summary>
        public string MaintenOper { get; set; }

        /// <summary>
        /// 修理处理结果
        /// </summary>
        public string MaintenOperResult { get; set; }


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



