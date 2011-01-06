<%@ Page Title="Plan Studiów" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<StudiesPlansWeb.Models.PlanList>" %>
<%@ Register Src="~/Views/Plans/List.ascx" TagName="PlanList" TagPrefix="sp" %>
<%@ Register Src="~/Views/Plans/PlanInfo.ascx" TagName="PlanInfo" TagPrefix="sp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Plany Studiów - Przeglądanie planów
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="height: 34px">
        Przeglądanie planów:</h2>
        <p style="color: Gray">Wybierz plan: <%: Html.DropDownListFor(m => m.PlanID, Model.Plans, new { @class = "ddwn" })%>
    </p>
    <table id="infos">
    <tr>
    <td id="leftinfo">
    <div id="filterbox">
    <h2 id="filterheader">&nbsp;Filtr</h2>
    <table id="filter">
        <tr>
            <td  id="leftfilter">
                Nazwa:</td>
            <td>
                <%: Html.TextBox("name")%></td>
        </tr>
        <tr>
            <td id="leftfilter">
                Wydział:</td>
            <td >
                 <%: Html.DropDownListFor(m => m.DepartamentID, Model.Departaments , new { @class = "ddwn" })%></td>
        </tr>
                <tr>
            <td id="leftfilter">
                Kierunek:</td>
            <td >
                <%: Html.DropDownListFor(m => m.FacultyID, Model.Faculties , new { @class = "ddwn" })%></td>
        </tr>
        <tr>
            <td id="leftfilter">
                Rok rozpoczęcia:    </td>
            <td ><input id="Checkbox1" type="checkbox" />
                <%: Html.DropDownListFor(m => m.YearStartID, Model.Years , new { @class = "ddwn" })%></td>
            
        </tr>
        <tr>
            <td id="leftfilter">
                Rok zakończenia:    </td>
            <td >
            <input id="Checkbox2" type="checkbox" />
                <%: Html.DropDownListFor(m => m.YearEndID, Model.Years, new { @class = "ddwn" })%></td>
        </tr>
        <tr>
            <td id="leftfilter">
                Semestr początkowy: </td>
            <td ><input id="Checkbox3" type="checkbox" />
                <%: Html.TextBox("semesterStart")%></td>
            
        </tr>
        <tr>
            <td id="leftfilter">
                Semestr końcowy:    </td>
            <td ><input id="Checkbox4" type="checkbox" />
                <%: Html.TextBox("semesterEnd")%></td>
        </tr>
             <tr>
            <td id="leftfilter">
                Plany:</td>
            <td >
               <input id="RadioAll" name="plan" type="radio" value="all" checked="checked"/> Wszystkie</td>
        </tr>
        <tr>
            <td id="leftfilter">
                </td>
            <td >
               <input id="RadioArch" name="plan" value="arch" type="radio" /> Archiwalne</td>
        </tr>
        <tr>
            <td id="leftfilter">
                </td>
            <td >
               <input id="RadioCurr" name="plan" value="curr" type="radio" /> Obowiązujące</td>
        </tr>
        <tr>
            <td id="leftfilter">
                </td>
            <td >
             
                <input id="Button1" type="button" value="Szukaj" /></td>

        </tr>
        
    </table>
    </div>
    </td>
    <td class="info">
    <h2 id="filterheader">Informacje o planie</h2>
    <div id="planbox">
    <sp:PlanInfo ID="PlanInfo1" runat="server" />
    </div>
    </td>
    </tr>
    </table>
    <br /><br />
    <sp:PlanList ID="frmPlanList" runat="server" />
    <br />



    <script language="javascript" type="text/javascript">
        $("#PlanID").change(function () {
            document.location.href = '<%:Url.Content("~/") %>Plans/Plan?PlanId=' + $("#PlanID").val();
        });

        $("#Button1").click(function () {
            document.location.href = '<%:Url.Content("~/") %>Plans/Plan?PlanId=0' + '&name=' + $("#name").val() +
            '&departamentID=' + $("#DepartamentID").val() + '&facultyID=' + $("#FacultyID").val() +
            '&selectedPlan=' + checkRadio() + '&yearStart=' + yearStart() + '&yearEnd=' + yearEnd() +
            '&semesterStart=' + semesterStart() + '&semesterEnd=' + semesterEnd();
        });

        function checkRadio() {
            for (i = 0; i < document.getElementsByName("plan").length; i++) {
                if (document.getElementsByName("plan")[i].checked == true) {
                    return document.getElementsByName("plan")[i].value;
                }
            }
        }

        function yearStart() {
            if (document.getElementById("Checkbox1").checked == true)
                return $("#YearStartID").val();
            else
                return 0;
        }

        function yearEnd() {
            if (document.getElementById("Checkbox2").checked == true)
                return $("#YearEndID").val();
            else
                return 0;
        }

        function semesterStart() {
            if (document.getElementById("Checkbox3").checked == true)
                return $("#semesterStart").val();
            else
                return 0;
        }

        function semesterEnd() {
            if (document.getElementById("Checkbox4").checked == true)
                return $("#semesterEnd").val();
            else
                return 0;
        }



	</script>

</asp:Content>
