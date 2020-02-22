using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using TestTask.Models;
using TestTask.Models.Observer;

namespace TestTask.Contollers
{
    public class HomeController : Controller
    {
        JsonOriginal jsonOriginal;
        JsonUpdate jsonUpdate;
        JsonBox jsonBox;
        IHostingEnvironment env;
        Comparator comparator;
        public HomeController(JsonOriginal jsonOr, JsonUpdate jsonUp,
                              JsonBox jBox, IHostingEnvironment e,
                              Comparator compar)
        {
            jsonOriginal = jsonOr;
            jsonUpdate = jsonUp;
            jsonBox=jBox  ;
            env = e;
            comparator = compar;
        }
        public IActionResult Index(JsonBox box=null)
        {    
                jsonBox.Original = jsonOriginal.WriteJson();
                jsonBox.Update = jsonUpdate.WriteJson();
                ViewBag.Message = TempData["ResultMessage"];
                return View(jsonBox);              
            
        }
        
        public IActionResult AuditLogsEntry(JsonBox box)
        {
          string origStr=box.Original;
          string updStr =box.Update;
          Subject subject = new Subject();
          Observer observer = new Observer(subject, origStr, updStr, comparator);
          subject.Go();
          TempData["ResultMessage"] = "File upload in folder of project";
          return  RedirectToAction("Index");
        }
       
    }
}