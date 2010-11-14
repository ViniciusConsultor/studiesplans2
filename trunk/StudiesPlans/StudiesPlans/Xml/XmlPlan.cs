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

            foreach (SubjectsData sd in LoadedPlan.SubjectsDatas)
            {
                if(sd.SpecializationsData==null)
                {
                    xml.AppendLine("<przedmiot>");
                    xml.AppendLine("<nazwa>" + sd.Subject.Name + "</nazwa>");

                    string institute = sd.Institute != null ? sd.Institute.Name : "brak";

                    xml.AppendLine("<instytut>" + institute+ "</instytut>");
                    xml.AppendLine("<typ>?</typ>");
                    xml.AppendLine("<semestr>" + sd.Semester.Semester1.ToString() + "</semestr>");

                    string exam = sd.IsExam == true ? "true" : "false";

                    xml.AppendLine("<egzamin>" + exam + "</egzamin>");
                    xml.AppendLine("<siatkaGodzinWyklad>" + 0 + "</siatkaGodzinWyklad>");
                    xml.AppendLine("<siatkaGodzinCwiczenie>" + 0 + "</siatkaGodzinCwiczenie>");
                    xml.AppendLine("<siatkaGodzinLaboratorium>" + 0 + "</siatkaGodzinLaboratorium>");
                    xml.AppendLine("<siatkaGodzinProjekt>" + 0 + "</siatkaGodzinProjekt>");
                    xml.AppendLine("<siatkaGodzinSeminarium>" + 0 + "</siatkaGodzinSeminarium>");
                    xml.AppendLine("<siatkaGodzinSeminariumDyplomowe>" + 0 + "</siatkaGodzinSeminariumDyplomowe>");
                    xml.AppendLine("<siatkaGodzinLektorat>" + 0 + "</siatkaGodzinLektorat>");
                    xml.AppendLine("<siatkaGodzinWF>" + 0 + "</siatkaGodzinWF>");
                    xml.AppendLine("<siatkaGodzinZajeciaTerenowe>" + 0 + "</siatkaGodzinZajeciaTerenowe>");
                    xml.AppendLine("<siatkaGodzinZajeciaJezykowe>" + 0 + "</siatkaGodzinZajeciaJezykowe>");
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
                        xml.AppendLine("<przedmiot>");
                        xml.AppendLine("<nazwa>" + sd.Subject.Name + "</nazwa>");

                        string institute = sd.Institute != null ? sd.Institute.Name : "brak";

                        xml.AppendLine("<instytut>" + institute + "</instytut>");
                        xml.AppendLine("<typ>?</typ>");
                        xml.AppendLine("<semestr>" + sd.Semester.Semester1.ToString() + "</semestr>");

                        string exam = sd.IsExam == true ? "true" : "false";

                        xml.AppendLine("<egzamin>" + exam + "</egzamin>");
                        xml.AppendLine("<siatkaGodzinWyklad>" + 0 + "</siatkaGodzinWyklad>");
                        xml.AppendLine("<siatkaGodzinCwiczenie>" + 0 + "</siatkaGodzinCwiczenie>");
                        xml.AppendLine("<siatkaGodzinLaboratorium>" + 0 + "</siatkaGodzinLaboratorium>");
                        xml.AppendLine("<siatkaGodzinProjekt>" + 0 + "</siatkaGodzinProjekt>");
                        xml.AppendLine("<siatkaGodzinSeminarium>" + 0 + "</siatkaGodzinSeminarium>");
                        xml.AppendLine("<siatkaGodzinSeminariumDyplomowe>" + 0 + "</siatkaGodzinSeminariumDyplomowe>");
                        xml.AppendLine("<siatkaGodzinLektorat>" + 0 + "</siatkaGodzinLektorat>");
                        xml.AppendLine("<siatkaGodzinWF>" + 0 + "</siatkaGodzinWF>");
                        xml.AppendLine("<siatkaGodzinZajeciaTerenowe>" + 0 + "</siatkaGodzinZajeciaTerenowe>");
                        xml.AppendLine("<siatkaGodzinZajeciaJezykowe>" + 0 + "</siatkaGodzinZajeciaJezykowe>");
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
