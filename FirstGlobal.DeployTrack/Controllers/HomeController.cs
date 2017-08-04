using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstGlobal.DeployTrack.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstGlobal.DeployTrack.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getData()
        {
            List<DeployTrackViewModel> deployTrackViewModelList = new List<DeployTrackViewModel>()
            {
                new DeployTrackViewModel
                {
                    ModuleName = "Something"
                }, new DeployTrackViewModel
                {
                    ModuleName = "Nischal"
                }

            };

            return Json(deployTrackViewModelList.ToList());
        }

        public ActionResult About()
        {
           // ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> About(DeployTrackViewModel model)
        {
            return null;
        }

        public ActionResult Contact()
        {
            List<DeployTrackViewModel> deployTrackViewModelList = new List<DeployTrackViewModel>()
            {
                new DeployTrackViewModel()
                {
                    ModuleName = "Something",
                    //Id = 1
                }, new DeployTrackViewModel()
                {
                    //Id = 2,
                    ModuleName = "Nischal"
                }

            };

            ListDeployTrackViewModel listDeployTrackViewModel = new ListDeployTrackViewModel()
            {
                DeployTrackViewModelsList = deployTrackViewModelList
            };

            return View(listDeployTrackViewModel);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
