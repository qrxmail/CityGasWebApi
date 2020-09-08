using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Task
{
    /// <summary>
    /// 任务表（通过计划表生成的任务表，任务执行者通过此表执行任务，并将执行过程记录到对应的记录表中）
    /// </summary>
    public class Task
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
        /// 任务名称
        /// </summary>
        public string TaskName { get; set; }

        /// <summary>
        /// 任务类型（根据任务类型，调出不同的记录表单进行新增，例如：维修任务，则调出维修记录新增页面）
        /// </summary>
        public string TaskType { get; set; }

        /// <summary>
        /// 任务时间
        /// </summary>
        public DateTime TaskTime { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 任务完成人
        /// </summary>
        public string CompleteUser { get; set; }

        /// <summary>
        /// 任务完成时间
        /// </summary>
        public DateTime CompleteTime { get; set; }


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

