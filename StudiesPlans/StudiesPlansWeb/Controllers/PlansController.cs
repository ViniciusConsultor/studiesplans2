using System.Collections.Generic;
using System.Web.Mvc;
using StudiesPlansModels.Helpers;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;
using StudiesPlansModels.Repositories;
using StudiesPlansModels.Repositories.Interfaces;
using StudiesPlansWeb.Models;

namespace StudiesPlansWeb.Controllers
{
    public class PlansController : Controller
    {
        IPlansRepository plansRepository = new PlansRepository();
        IDepartamentsRepository _departamentsRepository = new DepartamentsRepository();
        IFacultiesRepository _facultiesRepository = new FacultiesRepository();
        private PlanFilter filter = new PlanFilter();

        public ActionResult Plan(int planId = 0, string name ="", int departamentId = 0, int facultyId = 0, string selectedPlan = "")
        {
            PlanList data;
                filter.Name = name;
                if (departamentId != 0)
                    filter.DepartamentName = _departamentsRepository.GetDepartament(departamentId).Name;
                if (facultyId != 0)
                    filter.FacultyName = _facultiesRepository.GetFaculty(facultyId).Name;
                if (selectedPlan != null && !selectedPlan.Equals(""))
                {
                    if (selectedPlan.Equals("all"))
                        filter.All = true;
                    else if (selectedPlan.Equals("arch"))
                        filter.IsArchieved = true;
                    else if (selectedPlan.Equals("curr"))
                        filter.IsMandatory = true;
                }

            data = new PlanList(this.plansRepository.ListPlans(filter));


            data.PlanID = planId;
            List<SelectListItem> plans = new List<SelectListItem>(data.Plans);
            List<SelectListItem> faculties = new List<SelectListItem>(data.Faculties);
            data.FacultyID = int.Parse(faculties[0].Value);
            List<SelectListItem> departaments = new List<SelectListItem>(data.Departaments);
            data.DepartamentID = int.Parse(departaments[0].Value);

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
    }
}
