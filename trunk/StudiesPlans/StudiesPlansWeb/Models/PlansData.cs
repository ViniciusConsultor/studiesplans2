using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudiesPlansModels.Models;

namespace StudiesPlansWeb.Models
{
    public class PlanList
    {
        public IEnumerable<SelectListItem> Plans { get; set; }
        public int PlanID { get; set; }
        public int DepartamentID { get; set; }
        public int FacultyID { get; set; }
        public Plan SelectedPlan { get; set; }
        public IEnumerable<SelectListItem> Departaments { get; set; }
        public IEnumerable<SelectListItem> Faculties { get; set; }

        public PlanList(IEnumerable<StudiesPlansModels.Models.Plan> plans)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (Plan p in plans)
            {
                items.Add(new SelectListItem() { Text = p.Name, Value = p.PlanID.ToString() });
            }

            Plans = items;

            IEnumerable<Departament> departaments = new DepartamentsRepository().ListDepartaments();
            List<SelectListItem> departmentsList = new List<SelectListItem>();
            departmentsList.Add(new SelectListItem() { Text = "Wszystkie", Value = "0" });
            foreach (Departament d in departaments)
            {
                departmentsList.Add(new SelectListItem() { Text = d.Name, Value = d.DepartamentID.ToString() });
            }

            Departaments = departmentsList;

            IEnumerable<Faculty> faculties = new FacultiesRepository().ListFaculties();
            List<SelectListItem> facultiesList = new List<SelectListItem>();
            facultiesList.Add(new SelectListItem() {Text = "Wszystkie", Value = "0"});
            foreach (Faculty f in faculties)
            {
                facultiesList.Add(new SelectListItem() { Text = f.Name, Value = f.FacultyID.ToString() });
            }

            Faculties = facultiesList;
        }
    }
}