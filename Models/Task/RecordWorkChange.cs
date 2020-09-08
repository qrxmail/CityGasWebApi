using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Task
{
    /// <summary>
    /// 设备交接班记录
    /// </summary>
    public class RecordWorkChange
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
        /// 工作人
        /// </summary>
        public string WorkUser { get; set; }

        /// <summary>
        /// 工作内容
        /// </summary>
        public string WorkContent { get; set; }

        /// <summary>
        /// 工作起始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 工作结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 交接人
        /// </summary>
        public string ChangeUser { get; set; }


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





