using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace maybe451.Controllers
{
    public class VictoryController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(new Success());
        }
        
        public IActionResult Welcome(string name, int numTimes = 1) 
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View(); 
        }
        
    }
    /*
    public class Success {
        
        public string name = "Nick"
    }
    
 */
}
