using Microsoft.AspNetCore.Mvc;

namespace MVC_firstApp.Controllers
{
    public class HomeController:Controller
    {

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Detail(int id)
        {
            return View();
        }
    }
}
