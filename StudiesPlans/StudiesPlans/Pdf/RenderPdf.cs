using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PdfSharp.Drawing;
using System.Drawing;
using StudiesPlansModels.Models;
using PdfSharp.Pdf;

namespace StudiesPlans.Pdf
{
    public class RenderPdf
    {
        public Plan LoadedPlan { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public void Render(XGraphics gfx)
        {
            XPen pen;
            double x = 50;
            XFont fontH1 = new XFont("Times", 18, XFontStyle.Bold);

            XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);
            XFont font = new XFont("Times", 12, XFontStyle.Regular, options);
            XFont fontItalic = new XFont("Times", 12, XFontStyle.BoldItalic);
            double ls = font.GetHeight(gfx);

            pen = new XPen(XColors.Black, 0.5);
            pen.DashStyle = XDashStyle.Solid;

            double tablePositionX = 15, tablePositionY = 30, tablePositionX2 = gfx.PageSize.Width - tablePositionX, 
                    tablePositionY2 = tablePositionY + 30;

            // draw plan title
            gfx.DrawString(LoadedPlan.Name + " " + LoadedPlan.Departament.Name + " " + LoadedPlan.Faculty.Name + " " + LoadedPlan.StudiesType.Name, font, XBrushes.Black, x, 20);
            
            // draw table headers
            gfx.DrawLine(pen, tablePositionX, tablePositionY, tablePositionX, tablePositionY2);
            gfx.DrawLine(pen, tablePositionX + 30, tablePositionY, tablePositionX + 30, tablePositionY2);
            
            tablePositionY += 11;
            gfx.DrawString("Lp.", font, XBrushes.Black, tablePositionX + 2, tablePositionY);
            gfx.DrawString("Przedmiot", font, XBrushes.Black, tablePositionX + 32, tablePositionY);

            List<Semester> semesters = new List<Semester>();
            List<SubjectTypesData> subjectTypes = new List<SubjectTypesData>();

            Size semNameLength = new Size(0, 0);
            System.Drawing.Font ff = new Font("Times", 12);

            foreach (SubjectsData sd in LoadedPlan.SubjectsDatas)
            {
                bool semOnList = false;
                bool stOnList = false;
                foreach (Semester s in semesters)
                {
                    if (s.SemesterID == sd.SemesterID)
                        semOnList = true;
                }

                foreach (SubjectTypesData st in  sd.SubjectTypesDatas)
                {
                    foreach (SubjectTypesData std in subjectTypes)
                        if (st.SubjectTypeID == std.SubjectTypeID)
                            stOnList = true;

                    if (!stOnList)
                        subjectTypes.Add(st);
                }

                if (!semOnList)
                {
                    semesters.Add(sd.Semester);
                    Size tmp = System.Windows.Forms.TextRenderer.MeasureText(sd.Semester.Name, ff);
                    if (tmp.Width > semNameLength.Width)
                        semNameLength = tmp;
                }
            }

            semesters = semesters.OrderBy(c => c.Semester1).ToList();

            double oldX = tablePositionX;

            Size nameLength = new Size(0, 0);

            LoadedPlan.SubjectsDatas.OrderBy(c => c.Semester.Semester1);
            List<string> subjectNames = new List<string>();
            foreach (SubjectsData sd in LoadedPlan.SubjectsDatas)
            {
                bool isOnList = false;
                foreach (string name in subjectNames)
                    if (name.Equals(sd.Subject.Name))
                        isOnList = true;

                if (!isOnList)
                {
                    Size tmp = System.Windows.Forms.TextRenderer.MeasureText(sd.Subject.Name, ff);
                    subjectNames.Add(sd.Subject.Name);
                    if (tmp.Width > nameLength.Width)
                        nameLength = tmp;
                }
            }

            tablePositionX = nameLength.Width + 2;
            tablePositionY -= 11;
            gfx.DrawLine(pen, tablePositionX, tablePositionY, tablePositionX, tablePositionY2);

            double semLength = 15 * (subjectTypes.Count + 1);
            double diff = 0;
            if (semLength + 40 < semNameLength.Width)
                diff = semNameLength.Width - semLength - 40;
            else if (semLength >= semNameLength.Width)
                diff = 0;
            else
                diff = 40;

            semLength += diff;

            foreach (Semester s in semesters)
            {
                gfx.DrawString(s.Name, font, XBrushes.Black, tablePositionX + 2, tablePositionY + 11);
                foreach (SubjectTypesData st in subjectTypes)
                {
                    gfx.DrawString(st.SubjectType.Name.Substring(0, 1), font, XBrushes.Black, tablePositionX + 2, tablePositionY2 - 2);
                    tablePositionX += 15;
                    gfx.DrawLine(pen, tablePositionX, tablePositionY2 - 15, tablePositionX, tablePositionY2);
                }

                gfx.DrawString("E", font, XBrushes.Black, tablePositionX + 2, tablePositionY2 - 2);
                tablePositionX += 15;
                gfx.DrawLine(pen, tablePositionX, tablePositionY2 - 15, tablePositionX, tablePositionY2);
                gfx.DrawString("ECTS", font, XBrushes.Black, tablePositionX + 2, tablePositionY2 - 2);
                tablePositionX += diff;
                gfx.DrawLine(pen, tablePositionX, tablePositionY, tablePositionX, tablePositionY2);
            }


            tablePositionX = oldX;
            double oldY = tablePositionY2;
            double oldY2 = tablePositionY2+15;
            int lp = 1;

            double fullLength = nameLength.Width + (semLength * semesters.Count) + 2;
            gfx.DrawLine(pen, tablePositionX, 30, fullLength, 30);
            gfx.DrawLine(pen, tablePositionX, tablePositionY2, fullLength, tablePositionY2);
            gfx.DrawLine(pen, nameLength.Width + 2, tablePositionY2 - 15, fullLength, tablePositionY2 - 15);
            foreach (string name in subjectNames)
            {
                int offset = 0;
                tablePositionY = tablePositionY2;
                tablePositionY2 += 15;
                gfx.DrawLine(pen, tablePositionX, tablePositionY, tablePositionX, tablePositionY2);
                offset+=2;
                gfx.DrawString(lp.ToString(), font, XBrushes.Black, tablePositionX + offset, tablePositionY + 11);
                gfx.DrawLine(pen, tablePositionX, tablePositionY2, fullLength, tablePositionY2);
                offset+=28;
                gfx.DrawLine(pen, tablePositionX + 30, tablePositionY, tablePositionX + offset, tablePositionY2);
                lp++;
                offset+=2;
                gfx.DrawString(name, font, XBrushes.Black, tablePositionX + offset, tablePositionY + 11);
                gfx.DrawLine(pen, nameLength.Width + 2, tablePositionY, nameLength.Width + 2, tablePositionY2);

                foreach (SubjectsData sd in LoadedPlan.SubjectsDatas)
                {
                    if (sd.Subject.Name.Equals(name))
                    {
                        int no = 0;
                        foreach (Semester s in semesters)
                        {
                            if (s.Name.Equals(sd.Semester.Name))
                            {
                                foreach (SubjectTypesData std in sd.SubjectTypesDatas)
                                {
                                    int stno = 0;
                                    foreach (SubjectTypesData std2 in subjectTypes)
                                    {
                                        if (std.SubjectType.Name.Equals(std2.SubjectType.Name))
                                            gfx.DrawString(std.Hours.ToString(), font, XBrushes.Black, (nameLength.Width + 4) + (no * semLength) + (15 * stno), tablePositionY + 11);
                                        
                                        stno++;
                                    }  
                                }
                                if (sd.IsExam)                                                                                  // -53
                                    gfx.DrawString("x", font, XBrushes.Black, (nameLength.Width + 4) + ((no + 1) * (semLength ) - 13  - diff), tablePositionY + 11);
                                                                                                                                       // -38              
                                gfx.DrawString(sd.Ects.ToString(), font, XBrushes.Black, (nameLength.Width + 4) + ((no + 1) * (semLength) + 2 - diff), tablePositionY + 11);      
                            }
                            no++;
                        }  
                    }
                }
            } 

            // draw grid
            tablePositionX = oldX + 32 + nameLength.Width;
            for (int i = 0; i < subjectNames.Count; i++)
            {
                for (int j = 0; j < semesters.Count; j++)
                {
                    for (int k = 0; k < subjectTypes.Count; k++)
                    {
                        gfx.DrawLine(pen, (nameLength.Width + 15) + 2 + (j * semLength) + (15 * k), oldY, (nameLength.Width + 15) + 2 + (j * semLength) + (15 * k), oldY2);
                                        
                    }
                    gfx.DrawLine(pen, (nameLength.Width + 2) + ((j + 1) * (semLength) - diff), oldY, (nameLength.Width + 2) + ((j + 1) * (semLength) - diff), oldY2);
                    gfx.DrawLine(pen, (nameLength.Width + 2) + ((j + 1) * semLength), oldY, (nameLength.Width + 2) + ((j + 1) * semLength), oldY2);
                
                }
                oldY = oldY2;
                oldY2 += 15;
            }

            this.Width = fullLength + 30;
        }
    }
}
