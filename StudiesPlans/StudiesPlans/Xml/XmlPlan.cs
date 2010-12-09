using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models;
using System.Xml;
using System.IO;

namespace StudiesPlans.Xml
{
    public class XmlPlan
    {
        public Plan LoadedPlan { get; set; }
        public string XmlDoc { get; set; }

        public XmlPlan(Plan plan)
        {
            LoadedPlan = plan;
        }

        private List<string> GetSpecializationtNames()
        {
            List<string> specNames = new List<string>();

            foreach (SubjectsData sd in LoadedPlan.SubjectsDatas)
            {
                if (sd.SpecializationsData != null)
                {
                    bool isOnList = false;
                    foreach (string name in specNames)
                        if (name.Equals(sd.SpecializationsData.Specialization.Name))
                            isOnList = true;

                    if (!isOnList)
                        specNames.Add(sd.SpecializationsData.Specialization.Name);
                }
            }

            return specNames;
        }

        public void CreateXmlDocument()
        {
            StringBuilder xml = new StringBuilder();
            xml.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            xml.AppendLine("<harmonogramStudiow xsi:noNamespaceSchemaLocation=\"harmonogram.xml\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
            xml.AppendLine("<kierunek opis=\"\" nazwa=\"" + LoadedPlan.Faculty.Name + "\">");
            
            
            // without spec first
            xml.AppendLine("<specjalnosc nazwa=\"\">");
            float wyklad = 0;
            float cwiczenia = 0;
            float lab = 0;
            float projekt = 0;
            float seminarium = 0;
            float seminariumD = 0;
            float lektorat = 0;
            float terenowe = 0;
            float jezykowe = 0;

            foreach (SubjectsData sd in LoadedPlan.SubjectsDatas)
            {
                if(sd.SpecializationsData==null)
                {
                    foreach (SubjectTypesData st in sd.SubjectTypesDatas)
                    {
                        if (st.SubjectType.Name.ToLower().Contains("wykład"))
                            wyklad = (float)st.Hours;
                        else if (st.SubjectType.Name.ToLower().Contains("ćwiczenia"))
                            cwiczenia = (float)st.Hours;
                        else if (st.SubjectType.Name.ToLower().Contains("laboratorium"))
                            lab = (float)st.Hours;
                        else if (st.SubjectType.Name.ToLower().Contains("projekt"))
                            projekt = (float)st.Hours;
                        else if (st.SubjectType.Name.ToLower().Contains("seminarium"))
                            seminarium = (float)st.Hours;
                        else if (st.SubjectType.Name.ToLower().Contains("seminarium d"))
                            seminariumD = (float)st.Hours;
                        else if (st.SubjectType.Name.ToLower().Contains("lektorat"))
                            lektorat = (float)st.Hours;
                        else if (st.SubjectType.Name.ToLower().Contains("terenowe"))
                            terenowe = (float)st.Hours;
                        else if (st.SubjectType.Name.ToLower().Contains("językowe"))
                            jezykowe = (float)st.Hours;
                    }

                    xml.AppendLine("<przedmiot>");
                    xml.AppendLine("<nazwa>" + sd.Subject.Name + "</nazwa>");

                    string institute = sd.Institute != null ? sd.Institute.Name : "brak";

                    xml.AppendLine("<instytut>" + institute+ "</instytut>");
                    xml.AppendLine("<typ>?</typ>");
                    xml.AppendLine("<semestr>" + sd.Semester.Semester1.ToString() + "</semestr>");

                    string exam = sd.IsExam == true ? "true" : "false";

                    xml.AppendLine("<egzamin>" + exam + "</egzamin>");
                    xml.AppendLine("<siatkaGodzinWyklad>" + wyklad.ToString() + "</siatkaGodzinWyklad>");
                    xml.AppendLine("<siatkaGodzinCwiczenie>" + cwiczenia.ToString() + "</siatkaGodzinCwiczenie>");
                    xml.AppendLine("<siatkaGodzinLaboratorium>" + lab.ToString() + "</siatkaGodzinLaboratorium>");
                    xml.AppendLine("<siatkaGodzinProjekt>" + projekt.ToString() + "</siatkaGodzinProjekt>");
                    xml.AppendLine("<siatkaGodzinSeminarium>" + seminarium.ToString() + "</siatkaGodzinSeminarium>");
                    xml.AppendLine("<siatkaGodzinSeminariumDyplomowe>" + seminariumD.ToString() + "</siatkaGodzinSeminariumDyplomowe>");
                    xml.AppendLine("<siatkaGodzinLektorat>" + lektorat.ToString() + "</siatkaGodzinLektorat>");
                    xml.AppendLine("<siatkaGodzinWF>" + 0 + "</siatkaGodzinWF>");
                    xml.AppendLine("<siatkaGodzinZajeciaTerenowe>" + terenowe.ToString() + "</siatkaGodzinZajeciaTerenowe>");
                    xml.AppendLine("<siatkaGodzinZajeciaJezykowe>" + jezykowe.ToString() + "</siatkaGodzinZajeciaJezykowe>");
                    xml.AppendLine("</przedmiot>");
                }
            }

            xml.AppendLine("</specjalnosc>");

            // with specializations now

            List<string> specNames = this.GetSpecializationtNames();
            foreach (string name in specNames)
            {
                xml.AppendLine("<specjalnosc nazwa=\"" + name + "\">");
                foreach (SubjectsData sd in LoadedPlan.SubjectsDatas)
                {
                    if (sd.SpecializationsData != null && name.Equals(sd.SpecializationsData.Specialization.Name))
                    {
                        foreach (SubjectTypesData st in sd.SubjectTypesDatas)
                        {
                            if (st.SubjectType.Name.ToLower().Contains("wykład"))
                                wyklad = (float)st.Hours;
                            else if (st.SubjectType.Name.ToLower().Contains("ćwiczenia"))
                                cwiczenia = (float)st.Hours;
                            else if (st.SubjectType.Name.ToLower().Contains("laboratorium"))
                                lab = (float)st.Hours;
                            else if (st.SubjectType.Name.ToLower().Contains("projekt"))
                                projekt = (float)st.Hours;
                            else if (st.SubjectType.Name.ToLower().Contains("seminarium"))
                                seminarium = (float)st.Hours;
                            else if (st.SubjectType.Name.ToLower().Contains("seminarium d"))
                                seminariumD = (float)st.Hours;
                            else if (st.SubjectType.Name.ToLower().Contains("lektorat"))
                                lektorat = (float)st.Hours;
                            else if (st.SubjectType.Name.ToLower().Contains("terenowe"))
                                terenowe = (float)st.Hours;
                            else if (st.SubjectType.Name.ToLower().Contains("językowe"))
                                jezykowe = (float)st.Hours;
                        }

                        xml.AppendLine("<przedmiot>");
                        xml.AppendLine("<nazwa>" + sd.Subject.Name + "</nazwa>");

                        string institute = sd.Institute != null ? sd.Institute.Name : "brak";

                        xml.AppendLine("<instytut>" + institute + "</instytut>");
                        xml.AppendLine("<typ>?</typ>");
                        xml.AppendLine("<semestr>" + sd.Semester.Semester1.ToString() + "</semestr>");

                        string exam = sd.IsExam == true ? "true" : "false";

                        xml.AppendLine("<egzamin>" + exam + "</egzamin>");
                        xml.AppendLine("<siatkaGodzinWyklad>" + wyklad.ToString() + "</siatkaGodzinWyklad>");
                        xml.AppendLine("<siatkaGodzinCwiczenie>" + cwiczenia.ToString() + "</siatkaGodzinCwiczenie>");
                        xml.AppendLine("<siatkaGodzinLaboratorium>" + lab.ToString() + "</siatkaGodzinLaboratorium>");
                        xml.AppendLine("<siatkaGodzinProjekt>" + projekt.ToString() + "</siatkaGodzinProjekt>");
                        xml.AppendLine("<siatkaGodzinSeminarium>" + seminarium.ToString() + "</siatkaGodzinSeminarium>");
                        xml.AppendLine("<siatkaGodzinSeminariumDyplomowe>" + seminariumD.ToString() + "</siatkaGodzinSeminariumDyplomowe>");
                        xml.AppendLine("<siatkaGodzinLektorat>" + lektorat.ToString() + "</siatkaGodzinLektorat>");
                        xml.AppendLine("<siatkaGodzinWF>" + 0 + "</siatkaGodzinWF>");
                        xml.AppendLine("<siatkaGodzinZajeciaTerenowe>" + terenowe.ToString() + "</siatkaGodzinZajeciaTerenowe>");
                        xml.AppendLine("<siatkaGodzinZajeciaJezykowe>" + jezykowe.ToString() + "</siatkaGodzinZajeciaJezykowe>");
                        xml.AppendLine("</przedmiot>");
                    }
                }
                xml.AppendLine("</specjalnosc>");
            }

            xml.AppendLine("</kierunek>");
            xml.AppendLine("</harmonogramStudiow>");

            XmlDoc = xml.ToString();
        }

        public void SaveXmlDocument(string path)
        {
            File.WriteAllText(path, XmlDoc);
        }
    }
}
