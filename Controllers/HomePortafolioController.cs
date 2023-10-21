using Microsoft.AspNetCore.Mvc;

namespace HomePortafolioController.Controllers
{

    public class HomePortafolio : Controller {
        
        [HttpGet]
        [Route("/")]
        public ViewResult Index (){
            return View();
        }
        [HttpGet]
        [Route("/Projects")]
        public ViewResult Projects(){
            List<string> projectsList = new List<string>(){
                "Animals Otter",
                "Cute  Animals",
                "Asia Pets",
                "Official"
            };
            ViewBag.projects = projectsList;
            return View();
        }
        [HttpGet]
        [Route("/Contact")]
        public ViewResult Contact() => View();
    }
    
}