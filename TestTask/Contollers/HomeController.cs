using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using TestTask.Models;

namespace TestTask.Contollers
{
    public class HomeController : Controller
    {
        JsonOriginal jsonOriginal;
        JsonUpdate jsonUpdate;
        JsonBox jsonBox;
        IHostingEnvironment env;
       
        public HomeController(JsonOriginal jsonOr, JsonUpdate jsonUp,
                              JsonBox jBox, IHostingEnvironment e)
        {
            jsonOriginal = jsonOr;
            jsonUpdate = jsonUp;
            jsonBox=jBox  ;
            env = e;
           
        }
        public IActionResult Index()
        {
            jsonBox.Original= jsonOriginal.WriteJson();
            jsonBox.Update = jsonUpdate.WriteJson();
            string path= env.ContentRootPath;
            System.IO.File.WriteAllText(@path + "/Original.json", string.Empty);
            System.IO.File.WriteAllText(@path + "/Update.json", string.Empty);
            System.IO.File.WriteAllText(@path+"/Original.json", jsonBox.Original);
            System.IO.File.WriteAllText(@path +"/Update.json", jsonBox.Update);




            return View(jsonBox);
        }
        public IActionResult AuditLogsEntry(JsonBox box)
        { string change;
          string origStr=box.Original;
          string updStr = box.Update;
           Route origin = JsonConvert.DeserializeObject<Route>(origStr);
           Route update = JsonConvert.DeserializeObject<Route>(updStr);
            for(int i=0; i< origin.Riders.Count; i++)
            {
                string stOrigTime = origin.Riders[i].StartTime;
                string stOrigPlanTime= origin.Riders[i].PlannedStartTime;
                string stUpdateTime = update.Riders[i].StartTime;
                string stUpdatePlanTime = update.Riders[i].PlannedStartTime;
                
                if(!string.Equals(stOrigTime, stUpdateTime))
                {
                     change = "Start houre change";
                }

                if(!Equals(stOrigTime, stUpdateTime)&& Equals(stOrigPlanTime, stUpdatePlanTime))
                {
                     change = "Unplaned";
                }
                else
                {
                     change = "Planned";
                }

                Driver stOrigDriv= origin.Riders[i].Driver;
                Person stOrigDrivPer= origin.Riders[i].Driver.Person;
                Driver stUpdDriv = update.Riders[i].Driver;
                Person stUpdateDrivPer = update.Riders[i].Driver.Person;
                if(!Equals(stOrigDrivPer.FirstName, stUpdateDrivPer.FirstName) && !Equals(stOrigDrivPer.LastName, stUpdateDrivPer.LastName))
                {
                     change = "Driver change";
                }
                AuditLogEntry audit = new AuditLogEntry()
                {
                    TypeOfChange = change,
                    NewValue=,
                    OriginalValue=,
                    AffectedDays=,
                    EndDateOfChange=,
                    StartDateOfChange=,
                    Approvals=new List<Approval>() {new Approval() { } }
                };
            }
            return RedirectToAction("Index");
        }
       
    }
}