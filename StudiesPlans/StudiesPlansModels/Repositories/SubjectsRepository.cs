﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models.Interfaces;

namespace StudiesPlansModels.Models
{
    public class SubjectsRepository : ISubjectsRepository
    {
        public IEnumerable<SubjectsData> ListSubjects()
        {
            return (from SubjectsData sd in SPDatabase.DB.SubjectsDatas select sd);
        }

        public Subject GetSubject(string subjectName)
        {
            return (from Subject s in SPDatabase.DB.Subjects 
                    where string.Compare(subjectName, s.Name, true) == 0 
                    select s).FirstOrDefault();
        }

        public void AddSubject(NewSubject subject)
        {
            Subject s = this.GetSubject(subject.Name);
            if (s == null)
            {
                Subject newSubject = new Subject()
                {
                    Name = subject.Name
                };
                this.AddSubjectName(newSubject);
            }

            if (subject.Specializations != null && subject.Specializations.Count() > 0 && subject.IsGeneral == false)
            {
                s = this.GetSubject(subject.Name);

                for (int i = 0; i < subject.Specializations.Count(); i++)
                {
                    SpecializationsData specDat = new SpecializationsData()
                    {
                        IsElective = subject.Specializations.ElementAt(i).IsElective,
                        IsGeneral = subject.Specializations.ElementAt(i).IsGenereal,
                        SpecializationID = subject.Specializations.ElementAt(i).SpecializationId
                    };

                    SPDatabase.DB.SpecializationsDatas.AddObject(specDat);

                    SubjectsData sd = new SubjectsData()
                    {
                        DepartamentID = subject.DepartamentId,
                        Ects = subject.Ects,
                        FacultyID = subject.FacultyId,
                        InstituteID = subject.InstituteId,
                        IsExam = subject.IsExam,
                        SemesterID = subject.SemesterId,
                        SpecializationDataID = specDat.SpecializationDataID,
                        SubjectID = s.SubjectID,
                        IsElective = false,
                        IsGeneral = false
                    };

                    if (subject.InstituteId > 0)
                        sd.InstituteID = subject.InstituteId;
                    else
                        sd.InstituteID = null;

                    Plan p = GetPlan(subject.PlanId);
                    if (p != null)
                        sd.Plans.Add(p);

                    foreach (NewSubjectTypeData d in subject.SubjectTypes)
                    {
                        SubjectTypesData std = new SubjectTypesData()
                        {
                            Hours = d.Hours,
                            SubjectTypeID = d.SubjectTypeId
                        };

                        sd.SubjectTypesDatas.Add(std);
                    }

                    SPDatabase.DB.SubjectsDatas.AddObject(sd);
                    SPDatabase.DB.SaveChanges();
                }
            }

            if(subject.IsGeneral || subject.IsElective)
            {
                s = this.GetSubject(subject.Name);

                SubjectsData sdd = new SubjectsData()
                {
                    DepartamentID = subject.DepartamentId,
                    Ects = subject.Ects,
                    FacultyID = subject.FacultyId,
                    IsExam = subject.IsExam,
                    SemesterID = subject.SemesterId,
                    SpecializationDataID = null,
                    SubjectID = s.SubjectID,
                    IsElective = subject.IsElective,
                    IsGeneral = subject.IsGeneral
                };

                if (subject.InstituteId > 0)
                    sdd.InstituteID = subject.InstituteId;
                else
                    sdd.InstituteID = null;

                Plan pp = GetPlan(subject.PlanId);
                if (pp != null)
                    sdd.Plans.Add(pp);

                foreach (NewSubjectTypeData d in subject.SubjectTypes)
                {
                    SubjectTypesData std = new SubjectTypesData()
                    {
                        Hours = d.Hours,
                        SubjectTypeID = d.SubjectTypeId
                    };

                    sdd.SubjectTypesDatas.Add(std);
                }

                SPDatabase.DB.SubjectsDatas.AddObject(sdd);
                SPDatabase.DB.SaveChanges();
            }
        }

        private Plan GetPlan(int planId)
        {
            return (from Plan p in SPDatabase.DB.Plans
                    where p.PlanID == planId
                    select p).FirstOrDefault();
        }

        public void AddSubjectName(Subject newSubject)
        {
            if (newSubject != null)
            {
                SPDatabase.DB.Subjects.AddObject(newSubject);
                SPDatabase.DB.SaveChanges();
            }
        }

        public SubjectsData GetSubjectData(int subjectDataId)
        {
            return (from SubjectsData sd in SPDatabase.DB.SubjectsDatas
                    where sd.SubjectDataID == subjectDataId
                    select sd).FirstOrDefault();
        }

        public SubjectsData GetSubjectDataForEditing(string subjectName, int departamentId, double ects, int facultyId, int instituteId, bool isExam, int planId, int semesterId, IEnumerable<SpecializationDataEdit> specializations)
        {
            int? instituteId2 = null;
            if (instituteId > 0)
                instituteId2 = instituteId;

            IEnumerable<SubjectsData> s = (from SubjectsData sd in SPDatabase.DB.SubjectsDatas
                                    where sd.DepartamentID == departamentId &&
                                    //sd.Ects == ects &&
                                    sd.FacultyID == facultyId &&
                                    ((instituteId == 0 && sd.InstituteID == null) ||
                                    sd.InstituteID == instituteId) &&
                                    //sd.IsExam == isExam &&
                                    sd.SemesterID == semesterId &&
                                    string.Compare(sd.Subject.Name, subjectName, true) == 0
                                    select sd);

            if (s != null)
            {
                foreach (SubjectsData sd in s)
                {
                    foreach (Plan p in sd.Plans)
                    {
                        if (p.PlanID == planId)
                        {
                            if (specializations != null && specializations.Count() > 0)
                            {
                                if ((sd.SpecializationsData != null &&
                                    sd.SpecializationsData.IsElective == specializations.ElementAt(0).IsElective &&
                                    sd.SpecializationsData.IsGeneral == specializations.ElementAt(0).IsGenereal &&
                                    specializations.ElementAt(0).SpecializationId == sd.SpecializationsData.SpecializationID) ||
                                    sd.IsGeneral || (specializations.ElementAt(0).IsElective && sd.IsElective))
                                    return sd;
                            }
                            else if (specializations == null && sd.SpecializationsData == null)
                                return sd;
                        }
                    }
                }
            }

            return null;
        }

        public SubjectsData GetSubjectDataForAdding(string subjectName, int departamentId, double ects, int facultyId, int instituteId, bool isExam, int planId, int semesterId, IEnumerable<NewSpecializationData> specializations)
        {
            int? instituteId2 = null;
            if (instituteId > 0)
                instituteId2 = instituteId;

            IEnumerable<SubjectsData> s = (from SubjectsData sd in SPDatabase.DB.SubjectsDatas
                                           where sd.DepartamentID == departamentId &&
                                           //sd.Ects == ects &&
                                           sd.FacultyID == facultyId &&
                                           ((instituteId == 0 && sd.InstituteID == null) ||
                                           sd.InstituteID == instituteId) &&
                                           //sd.IsExam == isExam &&
                                           sd.SemesterID == semesterId &&
                                           string.Compare(sd.Subject.Name, subjectName, true) == 0
                                           select sd);

            if (s != null)
            {
                foreach (SubjectsData sd in s)
                {
                    foreach (Plan p in sd.Plans)
                    {
                        if (p.PlanID == planId)
                        {
                            if (specializations != null && specializations.Count() > 0)
                            {
                                if ((sd.SpecializationsData != null &&
                                    sd.SpecializationsData.IsElective == specializations.ElementAt(0).IsElective &&
                                    sd.SpecializationsData.IsGeneral == specializations.ElementAt(0).IsGenereal &&
                                    specializations.ElementAt(0).SpecializationId == sd.SpecializationsData.SpecializationID) ||
                                    sd.IsGeneral || (specializations.ElementAt(0).IsElective && sd.IsElective))
                                    return sd;
                            }
                            else if(specializations == null && sd.SpecializationsData == null)
                                return sd;
                        }
                    }
                }
            }

            return null;
        }

        public void DeleteSubject(SubjectsData sd)
        {
            if (sd != null)
            {
                SPDatabase.DB.SubjectsDatas.DeleteObject(sd);
                SPDatabase.DB.SaveChanges();
            }
        }

        public void EditSubject(SubjectsData subjectEdit)
        {
            if (subjectEdit != null)
                SPDatabase.DB.SaveChanges();
        }
    }
}
