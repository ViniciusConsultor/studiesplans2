<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Plany Studiów - Strona Główna
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        Serwis ten służy do wyszukiwania i przeglądania planów studiów. Dostępne są plany na wszystkich kierunkach i wydziałach.
        Serwis ten został stworzony w ramach projektu inżynieskiego na kierunku Informatyka na wydziale AEiI Politechniki Śląskiej.
        <br /><br />
        Autorami serwisu są:
        <br />
        Łukasz Kulig<br />
        Krzysztof Sałajczyk<br /><br />
        Promotor:<br />dr inż. Robert Tutajewicz
    </p>
    <p>
        Zapraszamy do korzystania!
    </p>
</asp:Content>
