<%@ Page Title="Plan Studiów" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<StudiesPlansWeb.Models.PlanList>" %>
<%@ Register Src="~/Views/Plans/List.ascx" TagName="PlanList" TagPrefix="sp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Plan
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="height: 34px">
        Wybierz plan: 
           <%: Html.DropDownListFor(m => m.PlanID, Model.Plans, new { @class = "ddwn" })%>
    </h2>
    <table style="width:100%;">
        <tr>
            <td style="width: 56px">
                Nazwa:</td>
            <td style="width: 212px">
                <%: Html.TextBox("name")%></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 56px">
                Wydział:</td>
            <td style="width: 212px">
                 <%: Html.DropDownListFor(m => m.DepartamentID, Model.Departaments , new { @class = "ddwn" })%></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 56px">
                Kierunek:</td>
            <td style="width: 212px">
                <%: Html.DropDownListFor(m => m.FacultyID, Model.Faculties , new { @class = "ddwn" })%></td>
            <td>
                &nbsp;</td>
        </tr>
             <tr>
            <td style="width: 56px">
                Plany:</td>
            <td style="width: 212px">
               <input id="RadioAll" name="plan" type="radio" value="all" checked="checked"/> Wszystkie</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 56px">
                </td>
            <td style="width: 212px">
               <input id="RadioArch" name="plan" value="arch" type="radio" /> Archiwalne</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 56px">
                </td>
            
            <td style="width: 212px">
               <input id="RadioCurr" name="plan" value="curr" type="radio" /> Obowiązujące</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 56px">
                </td>
            <td style="width: 212px">
             
                <input id="Button1" type="button" value="Szukaj" /></td>
            <td>
                &nbsp;</td>
        </tr>
        
    </table>
    <sp:PlanList ID="frmPlanList" runat="server" />
    <br />



    <script language="javascript" type="text/javascript">
        $("#PlanID").change(function () {
            document.location.href = '<%:Url.Content("~/") %>Plans/Plan?PlanId=' + $("#PlanID").val();
        });

        $("#Button1").click(function () {
            document.location.href = '<%:Url.Content("~/") %>Plans/Plan?PlanId=0' + '&name=' + $("#name").val() +
            '&departamentID=' + $("#DepartamentID").val() + '&facultyID=' + $("#FacultyID").val() +
            '&selectedPlan=' + checkRadio();
        });

        function checkRadio() {
            for (i = 0; i < document.getElementsByName("plan").length; i++) {
                if (document.getElementsByName("plan")[i].checked == true) {
                    return document.getElementsByName("plan")[i].value;
                }
            }
        }

	</script>

</asp:Content>
