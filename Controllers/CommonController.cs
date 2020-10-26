using System.Linq;
using CityGasWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityGasWebApi.Controllers
{
    [Route("api/common")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        private readonly CityGasContext _context;

        public CommonController(CityGasContext context)
        {
            _context = context;
        }

        // 获取站点数据（下拉选框数据）
        [Route("getOilStation")]
        public dynamic GetOilStation()
        {
            var stationData = _context.OilStation.ToList();

            var queryGroup = from a in stationData.GroupBy(t => new { t.Branch })
                             select new
                             {
                                 Label = a.Key.Branch,
                                 Value = a.Key.Branch,
                                 Children = from b in stationData.Where(p => p.Branch.Equals(a.Key.Branch)).GroupBy(t => new { t.Name })
                                            select new
                                            {
                                                Label = b.Key.Name,
                                                Value = b.Key.Name,
                                                Children = from c in stationData.Where(p => p.Name.Equals(b.Key.Name)).GroupBy(t => new { t.District, t.PK })
                                                           select new
                                                           {
                                                               Label = c.Key.District,
                                                               Value = c.Key.PK,
                                                           }
                                            }
                             };

            return queryGroup.ToList();
        }

        // 获取司机数据（下拉选框数据）
        [Route("getDriver")]
        public dynamic GetDriver()
        {
            var data = _context.Driver.ToList();

            var query = from a in data
                        select new
                             {
                                 Text = a.Name,
                                 Value = a.PK,
                             };

            return query.ToList();
        }

        // 获取车辆数据（下拉选框数据）
        [Route("getTruck")]
        public dynamic GetTruck()
        {
            var data = _context.Truck.ToList();

            var query = from a in data
                        select new
                        {
                            Text = a.Number,
                            Value = a.PK,
                        };

            return query.ToList();
        }

    }


}
