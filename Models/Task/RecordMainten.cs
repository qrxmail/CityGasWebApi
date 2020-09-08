using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Task
{
    /// <summary>
    /// 设备维修保养记录表
    /// </summary>
    public class RecordMainten
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
        /// 主要维修保养内容
        /// </summary>
        public string MaintContent { get; set; }

        /// <summary>
        /// 更换配件或更换油料
        /// </summary>
        public string MaintContent1 { get; set; }

        /// <summary>
        /// 修理费用（元）
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// 维修时间
        /// </summary>
        public DateTime MaintDate { get; set; }

        /// <summary>
        /// 维保类别
        /// </summary>
        public string MaintType { get; set; }

        /// <summary>
        /// 维修人员
        /// </summary>
        public string MaintUser { get; set; }

        /// <summary>
        /// 验收人
        /// </summary>
        public string CheckUser { get; set; }

        /// <summary>
        /// 验收结果
        /// </summary>
        public string CheckResult { get; set; }

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


