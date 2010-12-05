<%@ Page Title="Plan Studiów" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="StudiesPlansModels.Models" %>
<%@ Import Namespace="StudiesPlansModels.Repositories" %>
<%@ Import Namespace="StudiesPlansModels.Repositories.Interfaces" %>
<%@ Import Namespace="System.Data" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
    <script runat="server">
        readonly IPlansRepository _plansRepository = new PlansRepository();
        protected void PlanDdlLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IEnumerable<Plan> list = _plansRepository.ListActivePlans();
                PlanDDL.DataSource = list.ToList();
                PlanDDL.DataTextField = "Name";
                PlanDDL.DataValueField = "planID";
                PlanDDL.DataBind();

            }
        }

        private static DataTable CreateDataTable()
        {
            var myDataTable = new DataTable();

            var myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Nazwa" };
            myDataTable.Columns.Add(myDataColumn);
            myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Semestr" };
            myDataTable.Columns.Add(myDataColumn);
            myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "ECTS" };
            myDataTable.Columns.Add(myDataColumn);
            myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Egzamin" };
            myDataTable.Columns.Add(myDataColumn);
            myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Instytut" };
            myDataTable.Columns.Add(myDataColumn);
            myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Specjalizacja" };
            myDataTable.Columns.Add(myDataColumn);
            myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Obowiazkowy" };
            myDataTable.Columns.Add(myDataColumn);
            myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Obieralny" };
            myDataTable.Columns.Add(myDataColumn);
            myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Projekt" };
            myDataTable.Columns.Add(myDataColumn);
            myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Wykład" };
            myDataTable.Columns.Add(myDataColumn);
            myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Laborka" };
            myDataTable.Columns.Add(myDataColumn);
            myDataColumn = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Ćwiczenia" };
            myDataTable.Columns.Add(myDataColumn);
            return myDataTable;
        }

        private DataTable AddDataToTable(SubjectsData sd, DataTable table)
        {
            var row = table.NewRow();

            row["Nazwa"] = sd.Subject.Name;
            row["Semestr"] = sd.Semester.Name;
            row["ECTS"] = sd.Ects.ToString();
            row["Egzamin"] = sd.IsExam;
            row["Instytut"] = sd.Institute == null ? "Brak" : sd.Institute.Name;
            row["Obowiazkowy"] = sd.IsGeneral;
            row["Obieralny"] = sd.IsElective;
            foreach (SubjectTypesData st in sd.SubjectTypesDatas)
            {
                row[st.SubjectType.Name] = st.Hours.ToString();
            }
            if (sd.SpecializationDataID > 0)
            {
                string value = sd.SpecializationsData.Specialization.Name;
                if (sd.SpecializationsData.IsElective)
                    value += " Obieralny";
                else if (sd.SpecializationsData.IsGeneral)
                    value += " Obowiązkowy";
                row["Specjalizacja"] = value;
            }
            table.Rows.Add(row);
            return table;
        } 

protected void  GridLoad(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        Plan selectedPlan = _plansRepository.GetPlan(PlanDDL.SelectedItem.Text);
        DataTable table = CreateDataTable();
        table = selectedPlan.SubjectsDatas.Aggregate(table, (current, sd) => AddDataToTable(sd, current));
        GridView1.DataSource = table;
        GridView1.DataBind();
        PlanDDL.SelectedIndex = -1;
    } 
}

protected void PlanDdlSelectedIndexChanged(object sender, EventArgs e)
{
    Plan selectedPlan = _plansRepository.GetPlan(PlanDDL.SelectedItem.Text);
    DataTable table = CreateDataTable();
    table = selectedPlan.SubjectsDatas.Aggregate(table, (current, sd) => AddDataToTable(sd, current));
    GridView1.DataSource = table;
    GridView1.DataBind();
}

</script>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Plan
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" runat="server">
    <h2 style="height: 34px">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        Wybierz plan:     
            <asp:DropDownList ID="PlanDDL" runat="server" Height="18" Width="188" 
            AutoPostBack="True" oninit="PlanDdlLoad" 
                onselectedindexchanged="PlanDdlSelectedIndexChanged" 
            ViewStateMode="Enabled">
            </asp:DropDownList>
    </h2>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server" ViewStateMode="Enabled">
        <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
                GridLines="None" oninit="GridLoad" Font-Size="Smaller">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="PlanDDL" EventName="TextChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <br />
    <br />
    <br />

    </form>

</asp:Content>
