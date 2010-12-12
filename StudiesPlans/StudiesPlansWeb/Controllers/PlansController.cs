using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using StudiesPlansModels.Models;
using StudiesPlansModels.Repositories;
using StudiesPlansModels.Repositories.Interfaces;

namespace StudiesPlansWeb.Controllers
{
    public class PlansController : Controller
    {
        IPlansRepository plansRepository = new PlansRepository();
              public ActionResult Plan()
              {
                   
                   IEnumerable<Plan> plans = plansRepository.ListActivePlans();
                   ViewData["Plany"] = new SelectList(plans, "PlanID", "Name"); 
                   return View();
              }
            
              [HttpPost]
              public ActionResult PlanView(int index)
              {

                  Plan plan = plansRepository.GetPlan(index);
                  ViewData["Plany"] = plan;
                  return View();
              }
    }
}
