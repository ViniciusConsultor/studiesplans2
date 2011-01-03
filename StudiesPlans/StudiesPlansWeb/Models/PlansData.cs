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
        public Plan SelectedPlan { get; set; }

        public PlanList(IEnumerable<StudiesPlansModels.Models.Plan> plans)
        {
            List<SelectListItem> items = new List<SelectListItem>();

            foreach (Plan p in plans)
            {
                items.Add(new SelectListItem() { Text = p.Name, Value = p.PlanID.ToString() });
            }

            this.Plans = items;
        }
    }
}