using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class AuditLogEntry
    {
       
        public DateTime StartDateOfChange { get; set; }
        public DateTime EndDateOfChange { get; set; }
        public ActiveDays AffectedDays { get; set; }
        public string TypeOfChange { get; set; }
        public string OriginalValue { get; set; }
        public string NewValue { get; set; }
        public List<Approval> Approvals { get; set; }

    }
}
