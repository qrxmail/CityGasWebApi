using System;

namespace CityGasWebApi.Models.OperRecord
{
    /// <summary>
    /// 阀井维护保养记录
    /// </summary>
    public class ValvePitMaintanceRecord
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 阀井设备ID：根据设备ID可查出阀井编号、型号、安装位置、投用日期
        /// </summary>
        public Guid ValvePitDeviceId { get; set; }

        /// <summary>
        /// 序号：考虑是否需要
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// CH₄含量（%LEL）
        /// </summary>
        public double ChContent { get; set; }

        /// <summary>
        /// 十字作业
        /// </summary>
        public string TenWork { get; set; }

        /// <summary>
        /// 是否盘活
        /// </summary>
        public string IsLive { get; set; }

        /// <summary>
        /// 其它维护保养项
        /// </summary>
        public string OtherMaintanceItem { get; set; }

        /// <summary>
        /// 存在问题
        /// </summary>
        public string Problems { get; set; }

        /// <summary>
        /// 处理跟进
        /// </summary>
        public string FollowUp { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime RecordDate { get; set; }

        /// <summary>
        /// 操作人员
        /// </summary>
        public string OperUser { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


    }
}
