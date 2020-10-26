using CityGasWebApi.Models.Archives;
using CityGasWebApi.Models.Work;
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
        public dynamic Data { get; set; }
    }

    public class DeviceView : Device
    {
        public string InspectName { get; set; }
    }

    public class WorkTicketView : WorkTicket
    {
        public string LoadStationName { get; set; }
        public string LoadStationBranch { get; set; }
        public string LoadStationDistrict { get; set; }
        public string UnloadStationName { get; set; }
        public string UnloadStationBranch { get; set; }
        public string UnloadStationDistrict { get; set; }

        public string TruckNo { get; set; }
        public string DrvierName { get; set; }
    }

    /// <summary>
    /// 用来接收删除参数
    /// </summary>
    public class DelObj
    {
        public List<Guid> Id { get; set; }
    }

    public class ResultObj
    {
        public bool IsSuccess { get; set; }
        public string ErrMsg { get; set; }
    }
}
