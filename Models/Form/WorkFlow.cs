using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Form
{
    /// <summary>
    /// 流程设置表
    /// </summary>
    public class WorkFlow
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid GId { get; set; }
       
        /// <summary>
        /// 步骤编号
        /// </summary>
        public int StepNo { get; set; }

        /// <summary>
        /// 步骤名称
        /// </summary>
        public string StepName { get; set; }

        /// <summary>
        /// 下一步骤编号
        /// </summary>
        public string NextStepNo { get; set; }

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
