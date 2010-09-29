<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<StudiesPlansWeb.Models.LogOnModel>" %>

<asp:Content ID="loginTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Log On
</asp:Content>

<asp:Content ID="loginContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Log On</h2>
    <% using (Html.BeginForm()) { %>
        <div id="center">
            <fieldset>
                <legend>Account Information</legend>
                
                <table id="login">
                    <tr>
                        <td> <%: Html.LabelFor(m => m.UserName) %></td>
                        <td> <%: Html.TextBoxFor(m => m.UserName) %><br />
                        <%: Html.ValidationMessageFor(m => m.UserName) %></td>
                    </tr>
                    <tr>
                        <td> <%: Html.LabelFor(m => m.Password) %></td>
                        <td> <%: Html.PasswordFor(m => m.Password) %><br />
                        <%: Html.ValidationMessageFor(m => m.Password) %></td>
                    </tr>
                    <tr>
                        <td><%: Html.LabelFor(m => m.RememberMe) %></td>
                        <td><%: Html.CheckBoxFor(m => m.RememberMe) %></td>
                    </tr>
                    <tr>
                        <td colspan="2" id="loginbtn"><input type="submit" value="Zaloguj" /></td>
                    </tr>
                </table>
            </fieldset>
        </div>
    <% } %>
</asp:Content>
