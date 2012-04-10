<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionGroupes.aspx.cs" Inherits="IFT585_TP3.GestionGroupes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>Gestion des groupes</h2>
<div runat="server" id="listeGroupes">
</div>
<p>
<asp:Button ID="btnCreerGroupe" runat="server" Text="Créer un groupe" OnClick="btnCreerClick" />
</p>
</asp:Content>
