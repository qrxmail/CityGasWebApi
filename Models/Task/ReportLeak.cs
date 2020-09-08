using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Task
{
    /// <summary>
    /// 设备/管道泄漏上报表
    /// </summary>
    public class ReportLeak
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
        /// 发现泄露的时间
        /// </summary>
        public DateTime OccurTime { get; set; }

        /// <summary>
        /// 设备动密封点数
        /// </summary>
        public int DynamicPoint { get; set; }

        /// <summary>
        /// 设备静密封点数
        /// </summary>
        public int StaticPoint { get; set; }

        /// <summary>
        /// 其他动密封点数
        /// </summary>
        public int OtherDynamicPoint { get; set; }

        /// <summary>
        /// 其他静密封点数
        /// </summary>
        public int OtherStaticPoint { get; set; }

        /// <summary>
        /// 钢制阀井动密封点数
        /// </summary>
        public int SteelDynamicPoint { get; set; }

        /// <summary>
        /// 钢制阀井静密封点数
        /// </summary>
        public int SteelStaticPoint { get; set; }

        /// <summary>
        /// 单放散球阀动密封点数
        /// </summary>
        public int SingularDynamicPoint { get; set; }

        /// <summary>
        /// 单放散球阀静密封点数
        /// </summary>
        public int SingularStaticPoint { get; set; }

        /// <summary>
        /// 标准球阀阀动密封点数
        /// </summary>
        public int StandardDynamicPoint { get; set; }

        /// <summary>
        /// 标准球阀阀静密封点数
        /// </summary>
        public int StandardStaticPoint { get; set; }

        /// <summary>
        /// 双放散球阀动密封点数
        /// </summary>
        public int DualDynamicPoint { get; set; }

        /// <summary>
        /// 双放散球阀静密封点数
        /// </summary>
        public int DualStaticPoint { get; set; }

        /// <summary>
        /// 上报人
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



