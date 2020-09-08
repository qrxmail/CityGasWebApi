using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Archives
{
    /// <summary>
    /// 设备资料登记表
    /// </summary>
    public class DeviceMaterial
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
        /// 资料类型：现场验收、资料验收、工具验收、备件验收、说明书、合格证、
        /// 材质报告、维护保养手册、图纸、零部件目录图册、资质许可证、其他
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 资料名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 提供厂家
        /// </summary>
        public string Factory { get; set; }

        /// <summary>
        /// 文件类型：原件、复印件
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 存档类型：电子版、纸质版
        /// </summary>
        public string FileSaveType { get; set; }

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

