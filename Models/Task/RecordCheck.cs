using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Task
{
    /// <summary>
    /// 设备校验检修记录表
    /// </summary>
    public class RecordCheck
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
        /// 校验/检修日期
        /// </summary>
        public DateTime InspectDate { get; set; }

        /// <summary>
        /// 校验/检修内容
        /// </summary>
        public string InspectContent { get; set; }

        /// <summary>
        /// 校验/检修结果
        /// </summary>
        public string InspectResult { get; set; }

        /// <summary>
        /// 校验/检修单位
        /// </summary>
        public string InspectDept { get; set; }

        /// <summary>
        /// 校验/检修负责人
        /// </summary>
        public string InspectUser { get; set; }

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


