using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TestTask.Models.Observer
{
    public class Comparator
    {
        

        private Route DeserialJson(string s)
        {
            Route deserObj = JsonConvert.DeserializeObject<Route>(s);
            return deserObj;
        }



        public void JsonCompare(string orig, string upd)
        {            
            Route origin = DeserialJson(orig);
            Route update = DeserialJson(upd);
            string change = "";
            List<AuditLogEntry> auditList=new List<AuditLogEntry>();
            for (int i = 0; i < origin.Riders.Count; i++)
            {
                string stOrigTime = origin.Riders[i].StartTime;
                string stOrigPlanTime = origin.Riders[i].PlannedStartTime;
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
                    AuditLogEntry audit = AuditObj(stUpdateDateRide, stOrigDateRide,
                                                  stOrigDriv, origin.ActiveDays,
                                                  change, stUpdateTime, stOrigTime);
                    
                    auditList.Add(audit);
                }

                if (!Equals(stOrigTime, stUpdateTime) && Equals(stOrigPlanTime, stUpdatePlanTime))
                {
                    change = "Unplaned";
                    AuditLogEntry audit = AuditObj(stUpdateDateRide, stOrigDateRide,
                                                  stOrigDriv, origin.ActiveDays,
                                                  change, stUpdateTime, stOrigTime);
                    auditList.Add(audit);
                }
                else
                {
                    change = "Planned";
                    AuditLogEntry audit = AuditObj(stUpdateDateRide, stOrigDateRide,
                                                  stOrigDriv, origin.ActiveDays,
                                                  change, stUpdateTime, stOrigTime);
                   auditList.Add(audit);
                }

                if (!Equals(stOrigDrivPer.FirstName, stUpdateDrivPer.FirstName) &&
                    !Equals(stOrigDrivPer.LastName, stUpdateDrivPer.LastName))
                {
                    change = "Driver change";
                    AuditLogEntry audit = new AuditLogEntry()
                    {
                        TypeOfChange = change,
                        NewValue = $"Name: {stUpdateDrivPer.FirstName }, Lastname: {stUpdateDrivPer.LastName}",
                        OriginalValue = $"Name: {stOrigDrivPer.FirstName}, Lastname: { stOrigDrivPer.LastName}",
                        AffectedDays = origin.ActiveDays,
                        EndDateOfChange = stUpdateDateRide,
                        StartDateOfChange = stOrigDateRide,
                        Approvals = new List<Approval>() {
                        new Approval(){ Driver=stOrigDriv, Approved=true },
                        new Approval(){ Driver=stUpdDriv, Approved=true }}
                    };
                    auditList.Add(audit);
                }
            }
           string result = JsonConvert.SerializeObject(auditList);
           string fileName = System.IO.Path.Combine(Environment.CurrentDirectory, "Audit.json");
           System.IO.File.WriteAllText(fileName, result);
           
        }


        private AuditLogEntry AuditObj(DateTime stUpdateDateRide, DateTime stOrigDateRide,  Driver driver,ActiveDays ActiveDays,params string [] s)
        {
            AuditLogEntry NewAudit = new AuditLogEntry()
            {
                TypeOfChange = s[0],
                NewValue = s[1],
                OriginalValue = s[2],
                AffectedDays = ActiveDays,
                EndDateOfChange = stUpdateDateRide,
                StartDateOfChange = stOrigDateRide,
                Approvals = new List<Approval>() { new Approval(){ Driver=driver, Approved=true }}
            };
            return NewAudit;
        }

    }
}
