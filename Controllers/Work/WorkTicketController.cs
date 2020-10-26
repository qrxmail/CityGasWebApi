using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CityGasWebApi.Models;
using CityGasWebApi.Models.Work;
using CityGasWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CityGasWebApi.Controllers.Work
{
    [Route("api/workticket")]
    [ApiController]
    public class WorkTicketController : ControllerBase
    {
        private readonly CityGasContext _context;

        public WorkTicketController(CityGasContext context)
        {
            _context = context;
        }

        // 带多个查询条件的查询
        [Route("query")]
        [HttpGet]
        public ActionResult<TableData> Query(string queryStr)
        {
            JObject jObject = new JObject();
            if (string.IsNullOrEmpty(queryStr) == false)
            {
                jObject = JsonConvert.DeserializeObject<JObject>(queryStr);
            }

            int current = jObject.Value<int>("current") == 0 ? 1 : jObject.Value<int>("current");
            int pageSize = jObject.Value<int>("pageSize") == 0 ? 20 : jObject.Value<int>("pageSize");
            string serialNumber = jObject.Value<string>("serialNumber");
            string subSerialNumber = jObject.Value<string>("subSerialNumber");
            string createUser = jObject.Value<string>("createdby");
            string createTime = jObject.Value<string>("createTime");
            string loadStationName = jObject.Value<string>("loadStationName");
            string unloadStationName = jObject.Value<string>("unloadStationName");
            string carNumber = jObject.Value<string>("carNumber");
            string status = jObject.Value<string>("status"); 

            //防止查询条件都不满足，先生成一个空的查询(左连接查询)
            var where = (from work in _context.WorkTicket
                         join station in _context.OilStation on work.LoadStation equals station.PK.ToString() into station
                         from sta in station.DefaultIfEmpty()
                         join unStation in _context.OilStation on work.UnloadStation equals unStation.PK.ToString() into unStation
                         from unsta in unStation.DefaultIfEmpty()
                         join truck in _context.Truck on work.CarNumber equals truck.PK.ToString() into truck
                         from tru in truck.DefaultIfEmpty()
                         join drvier in _context.Driver on work.Driver equals drvier.PK.ToString() into driver
                         from drv in driver.DefaultIfEmpty()

                         //from sta in work.LoadStation.DefaultIfEmpty()
                         //from sta1 in work.UnloadStation.DefaultIfEmpty()
                         select new WorkTicketView
                         {
                             PK = work.PK,
                             LoadStation = work.LoadStation,
                             UnloadStation = work.UnloadStation,
                             SerialNumber = work.SerialNumber,
                             SubSerialNumber = work.SubSerialNumber,
                             CarNumber = work.CarNumber,
                             LoadingBeginTime = work.LoadingBeginTime,
                             LoadingEndTime = work.LoadingEndTime,
                             LoadingActualBeginTime = work.LoadingActualBeginTime,
                             LoadingActualEndTime = work.LoadingActualEndTime,
                             OilLoaded = work.OilLoaded,
                             Driver = work.Driver,
                             OilLoader = work.OilLoader,
                             UnloadingBeginTime = work.UnloadingBeginTime,
                             UnloadingEndTime = work.UnloadingEndTime,
                             OilUnloaded = work.OilUnloaded,
                             OilUnloader = work.OilUnloader,
                             Description = work.Description,
                             Reviewer = work.Reviewer,
                             Status = work.Status,
                             LevelBeginLoad = work.LevelBeginLoad,
                             LevelAfterLoad = work.LevelAfterLoad,
                             TaskDuration = work.TaskDuration,
                             Remark = work.Remark,
                             IsDeleted = work.IsDeleted,
                             CreateTime = work.CreateTime,
                             CreateUser = work.CreateUser,
                             LastUpdateTime = work.LastUpdateTime,
                             LastUpdateUser = work.LastUpdateUser,

                             LoadStationName = sta.Name,
                             LoadStationBranch = sta.Branch,
                             LoadStationDistrict = sta.District,
                             UnloadStationName = unsta.Name,
                             UnloadStationBranch = unsta.Branch,
                             UnloadStationDistrict = unsta.District,
                             TruckNo = tru.Number,
                             DrvierName = drv.Name,
                         }).Where(p => p.IsDeleted == false);
            
            if (string.IsNullOrEmpty(serialNumber) == false)
            {
                where = where.Where(p => p.SerialNumber.Contains(serialNumber));
            }
            if (string.IsNullOrEmpty(subSerialNumber) == false)
            {
                where = where.Where(p => p.SubSerialNumber.Contains(subSerialNumber));
            }
            if (string.IsNullOrEmpty(createUser) == false)
            {
                where = where.Where(p => p.CreateUser.Contains(createUser));
            }
            if (string.IsNullOrEmpty(createTime) == false)
            {
                where = where.Where(p => p.CreateTime <= DateTime.Parse(createTime));
            }
            if (string.IsNullOrEmpty(loadStationName) == false)
            {
                where = where.Where(p => p.LoadStationName.Contains(loadStationName));
            }
            if (string.IsNullOrEmpty(unloadStationName) == false)
            {
                where = where.Where(p => p.UnloadStationName.Contains(unloadStationName));
            }
            if (string.IsNullOrEmpty(carNumber) == false)
            {
                where = where.Where(p => p.CarNumber.Contains(carNumber));
            }
            if (string.IsNullOrEmpty(status) == false)
            {
                where = where.Where(p => p.Status.Equals(status));
            }
            //统计总记录数
            int total = where.Count();

            // 解析排序规则
            string sorterKey = "";
            string sortRule = "";
            JObject sorterObj = jObject.Value<JObject>("sorter");
            IEnumerable<JProperty> properties = sorterObj.Properties();
            foreach (JProperty item in properties)
            {
                sorterKey = item.Name;
                sortRule = item.Value.ToString();
            }
            if (string.IsNullOrEmpty(sorterKey) == false && string.IsNullOrEmpty(sortRule) == false)
            {
                if (sorterKey.Equals("serialNumber") && sortRule.Equals("descend"))
                {
                    where = where.OrderByDescending(p => p.SerialNumber);
                }
                else if (sorterKey.Equals("serialNumber") && sortRule.Equals("ascend"))
                {
                    where = where.OrderBy(p => p.SerialNumber);
                }
                if (sorterKey.Equals("subserialnumber") && sortRule.Equals("descend"))
                {
                    where = where.OrderByDescending(p => p.SubSerialNumber);
                }
                else if (sorterKey.Equals("subserialnumber") && sortRule.Equals("ascend"))
                {
                    where = where.OrderBy(p => p.SubSerialNumber);
                }
                if (sorterKey.Equals("createUser") && sortRule.Equals("descend"))
                {
                    where = where.OrderByDescending(p => p.CreateUser);
                }
                else if (sorterKey.Equals("createUser") && sortRule.Equals("ascend"))
                {
                    where = where.OrderBy(p => p.CreateUser);
                }
                if (sorterKey.Equals("createTime") && sortRule.Equals("descend"))
                {
                    where = where.OrderByDescending(p => p.CreateTime);
                }
                else if (sorterKey.Equals("createTime") && sortRule.Equals("ascend"))
                {
                    where = where.OrderBy(p => p.CreateTime);
                }
                if (sorterKey.Equals("status") && sortRule.Equals("descend"))
                {
                    where = where.OrderByDescending(p => p.Status);
                }
                else if (sorterKey.Equals("status") && sortRule.Equals("ascend"))
                {
                    where = where.OrderBy(p => p.Status);
                }
                // 按照最后更新时间排序
                if (sorterKey.Equals("lastUpdateTime") && sortRule.Equals("descend"))
                {
                    where = where.OrderByDescending(p => p.LastUpdateTime);
                }
                else if (sorterKey.Equals("lastUpdateTime") && sortRule.Equals("ascend"))
                {
                    where = where.OrderBy(p => p.LastUpdateTime);
                }
            }
            else
            {
                //结果按照最后修改时间倒序排序
                where = where.OrderByDescending(p => p.LastUpdateTime);
            }

            //跳过翻页的数量
            where = where.Skip(pageSize * (current - 1));
            //获取结果
            List<WorkTicketView> dataList = where.Take(pageSize).ToList();

            TableData resultObj = new TableData();
            resultObj.Data = dataList;
            resultObj.Current = current;
            resultObj.Success = true;
            resultObj.PageSize = pageSize;
            resultObj.Total = total;

            return resultObj;
        }

        // 根据id查询
        [Route("getbyid")]
        [HttpGet]
        public ActionResult<WorkTicket> GetById(Guid gid)
        {
            var item = _context.WorkTicket.Find(gid);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        // 判断是否存在相同编号
        public bool IsExistSame(WorkTicket obj)
        {
            var where = _context.WorkTicket.Where(p => p.SerialNumber == obj.SerialNumber);
            if (obj.PK != null)
            {
                where = where.Where(p => p.PK != obj.PK);
            }
            List<WorkTicket> list = where.ToList();
            if (list.Count > 0)
            {
                return true;
            }
            return false;
        }

        // 新增
        [Route("add")]
        [HttpPost]
        public ResultObj Add(WorkTicket obj)
        {
            // 获取当前登录用户名
            string _currentUserName = CommonService.GetCurrentUser(HttpContext).UserName;

            ResultObj resultObj = new ResultObj();
            if (IsExistSame(obj))
            {
                resultObj.IsSuccess = false;
                resultObj.ErrMsg = "该工单编号已存在。";
                return resultObj;
            }
            obj.Status = WorkTicketStatus.待接单.ToString();
            obj.IsDeleted = false;
            obj.Description = obj.Description + "\n【创建工单】操作人：" + _currentUserName + "，时间：" + DateTime.Now;
            obj.CreateUser = _currentUserName;
            obj.CreateTime = DateTime.Now;
            obj.LastUpdateUser = obj.LastUpdateUser;
            obj.LastUpdateTime = DateTime.Now;

            _context.WorkTicket.Add(obj);
            _context.SaveChanges();

            resultObj.IsSuccess = true;
            return resultObj;
        }

        // 修改
        [Route("update")]
        [HttpPost]
        public ResultObj Update(WorkTicket newObj)
        {
            // 获取当前登录用户名
            string _currentUserName = CommonService.GetCurrentUser(HttpContext).UserName;

            ResultObj resultObj = new ResultObj();

            var obj = _context.WorkTicket.Find(newObj.PK);
            if (obj == null)
            {
                resultObj.IsSuccess = false;
                resultObj.ErrMsg = "修改对象不存在。";
                return resultObj;
            }

            if (IsExistSame(newObj))
            {
                resultObj.IsSuccess = false;
                resultObj.ErrMsg = "该工单编号已存在。";
                return resultObj;
            }

            obj.SerialNumber = newObj.SerialNumber;
            obj.LoadStation = newObj.LoadStation;
            obj.LoadingBeginTime = newObj.LoadingBeginTime;
            obj.LoadingEndTime = newObj.LoadingEndTime;
            obj.UnloadStation = newObj.UnloadStation;
            obj.Remark = newObj.Remark;
            obj.Description = obj.Description + "\n【修改工单】操作人：" + _currentUserName + "，时间：" + DateTime.Now;

            obj.LastUpdateTime = DateTime.Now;
            obj.LastUpdateUser = _currentUserName;

            _context.WorkTicket.Update(obj);
            _context.SaveChanges();

            resultObj.IsSuccess = true;
            return resultObj;
        }

        // 接单
        [Route("receive")]
        [HttpPost]
        public ResultObj receive(WorkTicket newObj)
        {
            // 获取当前登录用户名
            string _currentUserName = CommonService.GetCurrentUser(HttpContext).UserName;

            ResultObj resultObj = new ResultObj();

            var obj = _context.WorkTicket.Find(newObj.PK);
            if (obj == null)
            {
                resultObj.IsSuccess = false;
                resultObj.ErrMsg = "修改对象不存在。";
                return resultObj;
            }
          
            obj.CarNumber = newObj.CarNumber;
            obj.Driver = newObj.Driver;
            obj.Status = WorkTicketStatus.待授权.ToString();
            obj.Description = obj.Description + "\n【接单】操作人：" + _currentUserName + "，时间：" + DateTime.Now;

            obj.LastUpdateTime = DateTime.Now;
            obj.LastUpdateUser = _currentUserName;

            _context.WorkTicket.Update(obj);
            _context.SaveChanges();

            resultObj.IsSuccess = true;
            return resultObj;
        }

        // 授权
        [Route("grant")]
        [HttpPost]
        public ResultObj grant(WorkTicket newObj)
        {
            // 获取当前登录用户名
            string _currentUserName = CommonService.GetCurrentUser(HttpContext).UserName;

            ResultObj resultObj = new ResultObj();

            var obj = _context.WorkTicket.Find(newObj.PK);
            if (obj == null)
            {
                resultObj.IsSuccess = false;
                resultObj.ErrMsg = "修改对象不存在。";
                return resultObj;
            }
           
            obj.Status = WorkTicketStatus.待拉油.ToString();
            obj.Description = obj.Description + "\n【授权】操作人：" + _currentUserName + "，时间：" + DateTime.Now;

            obj.LastUpdateTime = DateTime.Now;
            obj.LastUpdateUser = _currentUserName;

            _context.WorkTicket.Update(obj);
            _context.SaveChanges();

            resultObj.IsSuccess = true;
            return resultObj;
        }

        // 拉油
        [Route("load")]
        [HttpPost]
        public ResultObj load(WorkTicket newObj)
        {
            // 获取当前登录用户名
            string _currentUserName = CommonService.GetCurrentUser(HttpContext).UserName;

            ResultObj resultObj = new ResultObj();

            var obj = _context.WorkTicket.Find(newObj.PK);
            if (obj == null)
            {
                resultObj.IsSuccess = false;
                resultObj.ErrMsg = "修改对象不存在。";
                return resultObj;
            }

            obj.LoadingActualBeginTime = newObj.LoadingActualBeginTime;
            obj.LoadingActualEndTime = newObj.LoadingActualEndTime;
            obj.OilLoaded = newObj.OilLoaded;
            obj.OilLoader = _currentUserName;

            obj.Status = WorkTicketStatus.待卸油.ToString();
            obj.Description = obj.Description + "\n【拉油】操作人：" + _currentUserName + "，时间：" + DateTime.Now;

            obj.LastUpdateTime = DateTime.Now;
            obj.LastUpdateUser = _currentUserName;

            _context.WorkTicket.Update(obj);
            _context.SaveChanges();

            resultObj.IsSuccess = true;
            return resultObj;
        }

        // 卸油
        [Route("unload")]
        [HttpPost]
        public ResultObj unload(WorkTicket newObj)
        {
            // 获取当前登录用户名
            string _currentUserName = CommonService.GetCurrentUser(HttpContext).UserName;

            ResultObj resultObj = new ResultObj();

            var obj = _context.WorkTicket.Find(newObj.PK);
            if (obj == null)
            {
                resultObj.IsSuccess = false;
                resultObj.ErrMsg = "修改对象不存在。";
                return resultObj;
            }

            obj.UnloadingBeginTime = newObj.UnloadingBeginTime;
            obj.UnloadingEndTime = newObj.UnloadingEndTime;
            obj.OilUnloaded = newObj.OilUnloaded;
            obj.OilUnloader = _currentUserName;
            obj.SubSerialNumber = newObj.SubSerialNumber;

            obj.Status = WorkTicketStatus.待审批.ToString();
            obj.Description = obj.Description + "\n【卸油】操作人：" + _currentUserName + "，时间：" + DateTime.Now;

            obj.LastUpdateTime = DateTime.Now;
            obj.LastUpdateUser = _currentUserName;

            _context.WorkTicket.Update(obj);
            _context.SaveChanges();

            resultObj.IsSuccess = true;
            return resultObj;
        }

        // 审批
        [Route("review")]
        [HttpPost]
        public ResultObj review(WorkTicket newObj)
        {
            // 获取当前登录用户名
            string _currentUserName = CommonService.GetCurrentUser(HttpContext).UserName;

            ResultObj resultObj = new ResultObj();

            var obj = _context.WorkTicket.Find(newObj.PK);
            if (obj == null)
            {
                resultObj.IsSuccess = false;
                resultObj.ErrMsg = "修改对象不存在。";
                return resultObj;
            }
 
            obj.Reviewer = _currentUserName;

            obj.Status = WorkTicketStatus.已完成.ToString();
            obj.Description = obj.Description + "\n【审批】操作人：" + _currentUserName + "，时间：" + DateTime.Now;

            obj.LastUpdateTime = DateTime.Now;
            obj.LastUpdateUser = _currentUserName;

            _context.WorkTicket.Update(obj);
            _context.SaveChanges();

            resultObj.IsSuccess = true;
            return resultObj;
        }

        // 作废
        [Route("tovoid")]
        [HttpPost]
        public ResultObj tovoid (WorkTicket newObj)
        {
            // 获取当前登录用户名
            string _currentUserName = CommonService.GetCurrentUser(HttpContext).UserName;

            ResultObj resultObj = new ResultObj();

            var obj = _context.WorkTicket.Find(newObj.PK);
            if (obj == null)
            {
                resultObj.IsSuccess = false;
                resultObj.ErrMsg = "修改对象不存在。";
                return resultObj;
            }

            obj.Status = WorkTicketStatus.已作废.ToString();
            obj.Description = obj.Description + "\n【作废】操作人：" + _currentUserName + "，时间：" + DateTime.Now;

            obj.LastUpdateTime = DateTime.Now;
            obj.LastUpdateUser = _currentUserName;

            _context.WorkTicket.Update(obj);
            _context.SaveChanges();

            resultObj.IsSuccess = true;
            return resultObj;
        }

        // 删除
        [Route("delete")]
        [HttpPost]
        public IActionResult Delete(DelObj delObj)
        {
            // 获取当前登录用户名
            string _currentUserName = CommonService.GetCurrentUser(HttpContext).UserName;

            for (int i = 0; i < delObj.Id.Count(); i++)
            {
                var obj = _context.WorkTicket.Find(delObj.Id[i]);
                if (obj == null)
                {
                    return NotFound();
                }
                obj.IsDeleted = true;
                obj.Status = WorkTicketStatus.已删除.ToString();
                obj.Description = obj.Description + "\n【删除工单】操作人：" + _currentUserName + "，时间：" + DateTime.Now;

                obj.LastUpdateTime = DateTime.Now;
                obj.LastUpdateUser = _currentUserName;
                _context.WorkTicket.Update(obj);
                _context.SaveChanges();
            }

            return NoContent();
        }
    }

}
