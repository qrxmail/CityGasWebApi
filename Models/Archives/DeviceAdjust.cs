﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CityGasWebApi.Models.Archives
{
    /// <summary>
    /// 调压箱调压柜属性
    /// </summary>
    public class DeviceAdjust
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid GId { get; set; }

        /// <summary>
        /// 主设备ID
        /// </summary>
        public Guid DeviceId { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备类型（大类：输气专用设备、动力设备、输气管线、自动化设备）需要收纳资产类别12类：参考资产管理制度
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备类型（小类：压力容器、除尘分离设备、阴极保护设备、减压撬和其他输气专用设备（管线中的阀门、阀井、调压箱和调压柜）；
        /// 发电机组、变电设备、配电设备、锅炉、天然气压缩机、其他动力设备；
        /// 输气主管线、工艺管网和压力管道；
        /// 自动控制设备、电子计算机外部设备、其他自动化设备）
        /// </summary>
        public string DeviceType1 { get; set; }

        /// <summary>
        /// 安装地点
        /// </summary>
        public string InstallAddress { get; set; }

        /// <summary>
        /// 所在地区
        /// </summary>
        public string UseAddress { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        public string Spec { get; set; }

        /// <summary>
        /// 设备能力
        /// </summary>
        public string Ability { get; set; }

        /// <summary>
        /// 生成厂家
        /// </summary>
        public string Factory { get; set; }

        /// <summary>
        /// 出厂日期
        /// </summary>
        public DateTime FactoryDate { get; set; }

        /// <summary>
        /// 出厂编号
        /// </summary>
        public string FactoryNo { get; set; }

        /// <summary>
        /// 重量(kg)
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// 尺寸
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// 设备原值（元）
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        public string ResponseUser { get; set; }

        /// <summary>
        /// 投用日期
        /// </summary>
        public DateTime UseDate { get; set; }

        /// <summary>
        /// 是否重点部位关键装置
        /// </summary>
        public string IsKeyPart { get; set; }

        /// <summary>
        /// 是否通气
        /// </summary>
        public string IsVentilate { get; set; }

        /// <summary>
        /// 所属公司
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 设备状态
        /// </summary>
        public string State { get; set; }


        /// <summary>
        /// 其他参数
        /// </summary>
        public string OtherParams { get; set; }

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


