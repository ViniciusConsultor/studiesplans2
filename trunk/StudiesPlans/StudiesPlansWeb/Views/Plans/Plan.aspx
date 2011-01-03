<%@ Page Title="Plan Studiów" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<StudiesPlansWeb.Models.PlanList>" %>
<%@ Register Src="~/Views/Plans/List.ascx" TagName="PlanList" TagPrefix="sp" %>
<%@ Import Namespace="StudiesPlansModels.Models" %>
<%@ Import Namespace="StudiesPlansModels.Models.Interfaces" %>
<%@ Import Namespace="StudiesPlansModels.Repositories" %>
<%@ Import Namespace="StudiesPlansModels.Repositories.Interfaces" %>
<%@ Import Namespace="System.Data" %>
    <script runat="server">
        //private readonly IPlansRepository _plansRepository = new PlansRepository();
        //private static readonly ISubjectTypesRepository _typesRepository = new SubjectTypesRepository();
        ////protected void PlanDdlLoad(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        IEnumerable<Plan> list = _plansRepository.ListActivePlans();
        //        PlanDDL.DataSource = list.ToList();
        //        PlanDDL.DataTextField = "Name";
        //        PlanDDL.DataValueField = "planID";
        //        PlanDDL.DataBind();

        //    }
        //}

        //private static DataTable CreateDataTable()
        //{
        //    var myDataTable = new DataTable();
        //    int count = _typesRepository.ListSubjectTypes().Count();

        //    var myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Nazwa" };
        //    myDataTable.Columns.Add(myDataColumn);
        //    myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Semestr" };
        //    myDataTable.Columns.Add(myDataColumn);
        //    myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "ECTS" };
        //    myDataTable.Columns.Add(myDataColumn);
        //    myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Egzamin" };
        //    myDataTable.Columns.Add(myDataColumn);
        //    myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Instytut" };
        //    myDataTable.Columns.Add(myDataColumn);
        //    myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Specjalizacja" };
        //    myDataTable.Columns.Add(myDataColumn);
        //    myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Obowiazkowy" };
        //    myDataTable.Columns.Add(myDataColumn);
        //    myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Obieralny" };
        //    myDataTable.Columns.Add(myDataColumn);
        //    foreach(SubjectType st in _typesRepository.ListSubjectTypes())
        //    {
        //        myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = st.Name };
        //        myDataTable.Columns.Add(myDataColumn);
        //    }
        //    return myDataTable;
        //}

        //private DataTable AddDataToTable(SubjectsData sd, DataTable table)
        //{
        //    var row = table.NewRow();

        //    row["Nazwa"] = sd.Subject.Name;
        //    row["Semestr"] = sd.Semester.Name;
        //    row["ECTS"] = sd.Ects.ToString();
        //    row["Egzamin"] = sd.IsExam;
        //    row["Instytut"] = sd.Institute == null ? "Brak" : sd.Institute.Name;
        //    row["Obowiazkowy"] = sd.IsGeneral;
        //    row["Obieralny"] = sd.IsElective;
        //    foreach (SubjectTypesData st in sd.SubjectTypesDatas)
        //    {
        //        row[st.SubjectType.Name] = st.Hours.ToString();
        //    }
        //    if (sd.SpecializationDataID > 0)
        //    {
        //        string value = sd.SpecializationsData.Specialization.Name;
        //        if (sd.SpecializationsData.IsElective)
        //            value += " Obieralny";
        //        else if (sd.SpecializationsData.IsGeneral)
        //            value += " Obowiązkowy";
        //        row["Specjalizacja"] = value;
        //    }
        //    table.Rows.Add(row);
        //    return table;
        //} 

        //protected void  GridLoad(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        Plan selectedPlan = _plansRepository.GetPlan(PlanDDL.SelectedItem.Text);
        //        DataTable table = CreateDataTable();
        //        table = selectedPlan.SubjectsDatas.Aggregate(table, (current, sd) => AddDataToTable(sd, current));
        //        GridView1.DataSource = table;
        //        GridView1.DataBind();
        //        PlanDDL.SelectedIndex = -1;
        //    } 
        //}

        //protected void PlanDdlSelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Plan selectedPlan = _plansRepository.GetPlan(PlanDDL.SelectedItem.Text);
        //    DataTable table = CreateDataTable();
        //    table = selectedPlan.SubjectsDatas.Aggregate(table, (current, sd) => AddDataToTable(sd, current));
        //    GridView1.DataSource = table;
        //    GridView1.DataBind();
        //}

    </script>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Plan
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="height: 34px">
        Wybierz plan: 
           <%: Html.DropDownListFor(m => m.PlanID, Model.Plans, new { @class = "ddwn" })%>
    </h2>
   
    <sp:PlanList ID="frmPlanList" runat="server" />
    <br />

    <script language="javascript" type="text/javascript">
        $("#PlanID").change(function () {
            document.location.href = '<%:Url.Content("~/") %>Plans/Plan?PlanId=' + $("#PlanID").val();
        });

	</script>

</asp:Content>
