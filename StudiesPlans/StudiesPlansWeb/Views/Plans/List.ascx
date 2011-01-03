<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<PlanList>" %>
<%@ Import Namespace="StudiesPlansModels.Models" %>
<%@ Import Namespace="StudiesPlansModels.Repositories" %>
<%@ Import Namespace="StudiesPlansWeb.Models" %>
<table cellpadding="0" cellspacing="0">
	<tr class="planHeader">
        <td>
            Nazwa
        </td>
        <td>
            Semestr
        </td>
        <td>
            ECTS
        </td>
        <td>
            Egzamin
        </td>
        <td>
            Instytut
        </td>
        <td>
            Specjalizacja
        </td>
        <td>
            Obowiązkowy
        </td>
        <td>
            Obieralny
        </td>
        <%
            PlanList p = (PlanList)Model;
            List<string> types = new List<string>();
            SubjectTypesRepository subjectTypesRepository = new SubjectTypesRepository();
            List<SubjectType> list = subjectTypesRepository.ListSubjectTypes().ToList();
            foreach (SubjectType sType in list)
            {
                %>
            <td>
            <%:
            sType.Name
             %>
        </td>
            <%
                
            }
%>
    </tr>
    <%
            int rowCount = 0;
            string[] rowStyles = { "tbl_std_row1", "tbl_std_row2" };
        foreach(StudiesPlansModels.Models.SubjectsData sd in p.SelectedPlan.SubjectsDatas)
        {
            rowCount = ++rowCount % 2;
%>
    <tr class="<%= rowStyles[rowCount]%>">
        <td>
            <%:
                sd.Subject.Name
                %>
        </td>
        <td>
            <%:
                sd.Semester.Name%>
        </td>
        <td>
            <%:
                sd.Ects%>
        </td>
        <td>
            <%:
                sd.IsExam ? "Tak" : string.Empty 
            %>
        </td>
        <td>
            <%: sd.Institute != null? sd.Institute.Name : "Brak" %>
        </td>
        <td>
            <%: sd.SpecializationsData != null ? sd.SpecializationsData.Specialization.Name : string.Empty%>
        </td>
        <td>
            <%: sd.IsGeneral ? "Tak" : string.Empty%>
        </td>
        <td>
            <%: sd.IsElective ? "Tak" : string.Empty%>
        </td>

        <%
            foreach (SubjectType st in list)
            {
                %><td><%
                foreach (SubjectTypesData std in sd.SubjectTypesDatas)
                {
%><%: st.Name.Equals(std.SubjectType.Name)? std.Hours.ToString():string.Empty%>
                        <%
                }%>
                </td>
                <%
            }%>
    </tr>
    <%
        }
%>
</table>
