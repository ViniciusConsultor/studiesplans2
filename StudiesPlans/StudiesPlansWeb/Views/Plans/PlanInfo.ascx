<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<StudiesPlansWeb.Models.PlanList>" %>
<%@ Import Namespace="StudiesPlansModels.Models" %>
<%@ Import Namespace="StudiesPlansWeb.Models" %>
<table>
    <tr>
        <td>
            <% PlanList planL = (PlanList)Model;
               Plan plan = planL.SelectedPlan;
                %>

            Nazwa:
        </td>
        <td>
            <%: plan != null ? plan.Name : string.Empty %>
        </td>
    </tr>
    <tr>
        <td>
            Kierunek:
        </td>
        <td>
            <%: plan != null ? plan.Faculty.Name : string.Empty%>
        </td>
    </tr>
    <tr>
        <td>
            Wydział:
        </td>
        <td>
            <%: plan != null ? plan.Departament.Name : string.Empty %>
        </td>
    </tr>
    <tr>
        <td>
            Semestr początkowy:
        </td>
        <td>
            <%: plan != null ? (plan.SemesterStart.HasValue? plan.SemesterStart.Value.ToString() : string.Empty) : string.Empty %>
        </td>
    </tr>
    <tr>
        <td>
            Semestr końcowy:
        </td>
        <td>
            <%: plan != null ? (plan.SemesterEnd.HasValue ? plan.SemesterEnd.Value.ToString() : string.Empty) : string.Empty %>
        </td>
    </tr>
    <tr>
        <td>
            Rok początkowy:
        </td>
        <td>
            <%: plan != null ? (plan.YearStart.HasValue ? plan.YearStart.Value.Year.ToString() : string.Empty) : string.Empty %>
        </td>
    </tr>
    <tr>
        <td>
            Rok końcowy:
        </td>
        <td>
            <%: plan != null ? (plan.YearEnd.HasValue ? plan.YearEnd.Value.Year.ToString() : string.Empty) : string.Empty %>
        </td>
    </tr>
    <tr>
        <td>
            Typ studiów:
        </td>
        <td>
            <%: plan != null ? plan.StudiesType.Name : string.Empty %>
        </td>
    </tr>
    <tr>
        <td>
            Status:
        </td>
        <td>
            <%: plan != null ? (plan.IsMandatory? "Obowiązuje" : (plan.IsArchiewed? "Zarchiwizowany": string.Empty)) : string.Empty %>
        </td>
    </tr>
</table>
