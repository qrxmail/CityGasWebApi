using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Task
{
    /// <summary>
    /// 设备运行参数上报（包括设备运行状态、设备利用率报表会用到）
    /// </summary>
    public class ReportRunParams
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
        /// 参数名称
        /// </summary>
        public string ParamsName { get; set; }

        /// <summary>
        /// 值类型
        /// </summary>
        public string ValueType { get; set; }

        /// <summary>
        /// 参数值（浮点型）
        /// </summary>
        public double ParamsValue1 { get; set; }

        /// <summary>
        /// 参数值（字符型）
        /// </summary>
        public string ParamsValue2 { get; set; }

        /// <summary>
        /// 值单位
        /// </summary>
        public string Unit { get; set; }

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



