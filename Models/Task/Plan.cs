using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Task
{
    /// <summary>
    /// 计划表（包括设备操作计划、维修保养计划、校验检修计划的制定，根据计划表生成任务表）
    /// </summary>
    public class Plan
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
        /// 计划名称
        /// </summary>
        public string PlanName { get; set; }

        /// <summary>
        /// 计划类型
        /// </summary>
        public string PlanType { get; set; }

        /// <summary>
        /// 执行周期（根据周期自动生成任务）
        /// </summary>
        public string Cycle { get; set; }

        /// <summary>
        /// 执行人
        /// </summary>
        public string ExecutUser { get; set; }

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
