﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;
using System.Data;

namespace StudiesPlans.Controllers
{
    public class SpecializationController
    {
        private static SpecializationController instance;
        private ISpecializationsRepository repository;

        public static SpecializationController Instance
        {
            get
            {
                if (instance == null)
                    instance = new SpecializationController(new SpecializationsRepository());

                return instance;
            }
        }

        public SpecializationController(ISpecializationsRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Specialization> ListSpecializations()
        {
            return this.repository.ListSpecializations();
        }

        public bool AddSpecialization(NewSpecialization toAdd)
        {
            Specialization s = this.repository.GetSpecialization(toAdd.SpecializationName);
            if (s != null)
                toAdd.AddError("Specjalizacja o takiej nazwie już\nistnieje");
            if (toAdd.IsValid)
            {
                this.repository.AddSpecialization(toAdd);
                return true;
            }
            return false;
        }

        public SpecializationEdit GetSpecializationEdit(string specializationName)
        {
            return this.repository.GetSpecializationEdit(specializationName);
        }

        public void DeleteSpecialization(SpecializationEdit toEdit)
        {
            Specialization s = this.repository.GetSpecialization(toEdit.SpecializationName);
            if (s != null && s.SpecializationsDatas.Count > 0)
                throw new UpdateException("Nie można usunąć specjalizacji,\nponieważ posiada powiązania");
            else
            {
                this.repository.DeleteSpecialization(s);
            }
        }

        public bool EditSpecialization(SpecializationEdit toEdit)
        {
            if (toEdit != null)
            {
                Specialization s = this.repository.GetSpecialization(toEdit.SpecializationName);
                if (s != null && s.SpecializationID != toEdit.SpecializationID && s.Name.Equals(toEdit.SpecializationName))
                    toEdit.AddError("Specjalizacja o takiej nazwie\njuż istnieje");

                if (toEdit.IsValid)
                {
                    s = this.repository.GetSpecialization(toEdit.SpecializationID);
                    s.Name = toEdit.SpecializationName;
                   
                    this.repository.EditSpecialization(s);
                    return true;
                }
            }
            return false;
        }
    }
}