using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using StudiesPlansModels.Helpers;
using StudiesPlansModels.Models;
using StudiesPlansModels.Repositories;
using StudiesPlansModels.Repositories.Interfaces;
using StudiesPlansWeb.Models;

namespace StudiesPlansWeb.Controllers
{
    public class PlansController : Controller
    {
        IPlansRepository plansRepository = new PlansRepository();

        public ActionResult Plan(int planId = 0)
        {       
            //IEnumerable<Plan> plans = plansRepository.ListActivePlans();
            //ViewData["Plany"] = new SelectList(plans, "PlanID", "Name");
            //return View();

            PlanList data = new PlanList(this.plansRepository.ListPlans(new PlanFilter() ));
            data.PlanID = planId;
            List<SelectListItem> plans = new List<SelectListItem>(data.Plans);
            data.SelectedPlan = this.plansRepository.GetPlan(data.PlanID);
            if (data.PlanID == 0)
            {
                if (plans.Count > 0)
                {
                    data.PlanID = int.Parse(plans[0].Value);
                    data.SelectedPlan = this.plansRepository.GetPlan(data.PlanID);
                }
                else
                    return View(data);
            }
            return View(data);
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
