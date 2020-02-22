using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
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
        public IActionResult Index(JsonBox box=null)
        {    string path= env.ContentRootPath;
             if(System.IO.File.Exists(path + "/Original.json")&& System.IO.File.Exists(path + "/Update.json"))
               {
                jsonBox.Original = jsonOriginal.WriteJson();
                jsonBox.Update = jsonUpdate.WriteJson();

                System.IO.File.WriteAllText(path + "/Original.json", string.Empty);
                System.IO.File.WriteAllText(path + "/Update.json", string.Empty);
                System.IO.File.WriteAllText(path + "/Original.json", jsonBox.Original);
                System.IO.File.WriteAllText(path + "/Update.json", jsonBox.Update);
                return View(jsonBox);
                }
            else
            {
                return null;
            }
            
        }
        
        public IActionResult AuditLogsEntry(JsonBox box)
        { string change;
          string jResult="";
          string path = env.ContentRootPath;
          if (System.IO.File.Exists(path + "/Audit.json"))
            {
               System.IO.File.WriteAllText(path + "/Audit.json", string.Empty);
            }
            else
            {
                return null;
            }
         
          string origStr=box.Original;
          string updStr =box.Update;
           Route origin = JsonConvert.DeserializeObject<Route>(origStr);
           Route update = JsonConvert.DeserializeObject<Route>(updStr);
            for (int i=0; i< origin.Riders.Count; i++)
            {
                string stOrigTime = origin.Riders[i].StartTime;
                string stOrigPlanTime= origin.Riders[i].PlannedStartTime;
                string stUpdateTime = update.Riders[i].StartTime;
                string stUpdatePlanTime = update.Riders[i].PlannedStartTime;
                DateTime stOrigDateRide = origin.Riders[i].DateOfRide;
                DateTime stUpdateDateRide = update.Riders[i].DateOfRide;
                Driver stOrigDriv = origin.Riders[i].Driver;
                Person stOrigDrivPer = origin.Riders[i].Driver.Person;
                Driver stUpdDriv = update.Riders[i].Driver;
                Person stUpdateDrivPer = update.Riders[i].Driver.Person;

                if (!string.Equals(stOrigTime, stUpdateTime))
                {
                     change = "Start houre change";
                    AuditLogEntry audit = new AuditLogEntry()
                    {
                        TypeOfChange = change,
                        NewValue = stUpdateTime,
                        OriginalValue = stOrigTime,
                        AffectedDays =(int)origin.ActiveDays,
                        EndDateOfChange =stUpdateDateRide,
                        StartDateOfChange =stOrigDateRide,
                        Approvals = new List<Approval>() {
                        new Approval(){ Driver=stOrigDriv, Approved=true }}
                    };
                    string jRes = JsonConvert.SerializeObject(audit);
                    jResult += jRes;
                }

                if(!Equals(stOrigTime, stUpdateTime)&& Equals(stOrigPlanTime, stUpdatePlanTime))
                {
                     change = "Unplaned";
                    AuditLogEntry audit = new AuditLogEntry()
                    {
                        TypeOfChange = change,
                        NewValue = stUpdateTime,
                        OriginalValue = stOrigTime,
                        AffectedDays = (int)origin.ActiveDays,
                        EndDateOfChange = stUpdateDateRide,
                        StartDateOfChange = stOrigDateRide,
                        Approvals = new List<Approval>() {
                        new Approval(){ Driver=stOrigDriv, Approved=true }}
                    };
                    string jRes = JsonConvert.SerializeObject(audit);
                    jResult += jRes;
                }
                else
                {
                     change = "Planned";
                    AuditLogEntry audit = new AuditLogEntry()
                    {
                        TypeOfChange = change,
                        NewValue = stUpdateTime,
                        OriginalValue = stOrigTime,
                        AffectedDays = (int)origin.ActiveDays,
                        EndDateOfChange = stUpdateDateRide,
                        StartDateOfChange = stOrigDateRide,
                        Approvals = new List<Approval>() {
                        new Approval(){ Driver=stOrigDriv, Approved=true }}
                    };
                    string jRes = JsonConvert.SerializeObject(audit);
                    jResult += jRes;
                }

                if(!Equals(stOrigDrivPer.FirstName, stUpdateDrivPer.FirstName) && !Equals(stOrigDrivPer.LastName, stUpdateDrivPer.LastName))
                {
                     change = "Driver change";
                    AuditLogEntry audit = new AuditLogEntry()
                    {
                        TypeOfChange = change,
                        NewValue = stUpdateDrivPer.FirstName+" "+stUpdateDrivPer.LastName,
                        OriginalValue = stOrigDrivPer.FirstName+" "+ stOrigDrivPer.LastName,
                        AffectedDays = (int)origin.ActiveDays,
                        EndDateOfChange =stUpdateDateRide,
                        StartDateOfChange =stOrigDateRide,
                        Approvals = new List<Approval>() {
                        new Approval(){ Driver=stOrigDriv, Approved=true },
                        new Approval(){ Driver=stUpdDriv, Approved=true }}
                    };
                    string jRes = JsonConvert.SerializeObject(audit);
                    jResult += jRes;
                }
                
            }
            
            System.IO.File.WriteAllText(path + "/Audit.json", jResult); 
            return RedirectToAction("Index");
        }
       
    }
}