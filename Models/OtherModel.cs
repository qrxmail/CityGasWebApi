using CityGasWebApi.Models.Archives;
using System;
using System.Collections.Generic;

namespace CityGasWebApi.Models
{
    /// <summary>
    /// 前端列表数据的通用参数
    /// </summary>
    public class TableData
    {
        public int Total { get; set; }
        public bool Success { get; set; }
        public int PageSize { get; set; }
        public int Current { get; set; }
    }

    /// <summary>
    /// 用来返回设备的列表数据
    /// </summary>
    public class TableDataDevice : TableData
    {
        public List<DeviceView> Data { get; set; }
    }

    public class DeviceView : Device
    {
        public string InspectName { get; set; }
    }

    /// <summary>
    /// 用来接收删除参数
    /// </summary>
    public class DelObj
    {
        public List<Guid> gId { get; set; }
    }

    public class ResultObj
    {
        public bool IsSuccess { get; set; }
        public string ErrMsg { get; set; }
    }
}
