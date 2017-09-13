<%@ Page Title="" Language="C#" MasterPageFile="~/GoC.WebTemplate/GoCWebTemplate.Master" AutoEventWireup="true" CodeFile="Ecogeo.aspx.cs" Inherits="Ecogeo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <% if(this.WebTemplateMaster.WebTemplateCore.TwoLetterCultureLanguage == "en") { %>
        <% Session["GoC.Template.Culture"] = "en-CA"; %>
        <iframe src="ecogeo-en.html" style="height: 700px;width:100%;border:0;" allowfullscreen></iframe>
    <% } %>
    <% else { %>
        <% Session["GoC.Template.Culture"] = "fr-CA"; %>
        <iframe src="ecogeo-fr.html" style="height: 700px;width:100%;border:0;" allowfullscreen></iframe>
    <% } %>
</asp:Content>
