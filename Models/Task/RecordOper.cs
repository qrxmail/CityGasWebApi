using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Task
{
    /// <summary>
    /// 设备操作记录表
    /// </summary>
    public class RecordOper
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
        /// 操作人
        /// </summary>
        public string OperUser { get; set; }

        /// <summary>
        /// 操作内容
        /// </summary>
        public string OperContent { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime { get; set; }


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


