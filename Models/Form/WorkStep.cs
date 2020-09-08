using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Form
{
    /// <summary>
    /// 流程处理步骤表（一个表单对应一个步骤表）
    /// </summary>
    public class WorkStep
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid GId { get; set; }

        /// <summary>
        /// 单据编号
        /// </summary>
        public string FormNo { get; set; }

        /// <summary>
        /// 步骤编号
        /// </summary>
        public int StepNo { get; set; }

        /// <summary>
        /// 步骤状态（待处理、已处理）
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 处理人
        /// </summary>
        public string OperUser { get; set; }

        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime OperTime { get; set; }

        /// <summary>
        /// 处理意见
        /// </summary>
        public string OperOpinion { get; set; }

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
