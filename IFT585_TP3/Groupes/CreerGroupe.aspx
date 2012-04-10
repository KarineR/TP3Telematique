<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreerGroupe.aspx.cs" Inherits="IFT585_TP3.Groupes.CreerGroupe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<style type="text/css" media="all">
.checkboxlist_nowrap tr td label
    {
        white-space:nowrap;
        overflow:hidden;
    }
    .style1
    {
        width: 98px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Créer un groupe</h2>
&nbsp
<div>
        <table>
        <tr>
            <td><asp:Label ID="GroupNameLabel" runat="server" AssociatedControlID="GroupName">Nom du groupe : </asp:Label></td>
            <td><asp:TextBox ID="GroupName" runat="server" CssClass="textEntry"></asp:TextBox></td>
        </tr>

        <tr>
            <td valign="top" class="style1"><asp:Label ID="lblUsers" runat="server" AssociatedControlID="chkUsers">Membres : </asp:Label></td>
            <td>
                <asp:CheckBoxList ID="chkUsers" runat="server" RepeatColumns="1" Width="113px"  
                    RepeatLayout="Table">
                </asp:CheckBoxList>
             </td>
        </tr> 
        <tr>
        <td>&nbsp</td>
        <td align="right">
            <asp:Button ID="btnSubmit" runat="server" Text="Soumettre" 
                onclick="btnSubmit_Click"/>
        </td>
        </tr>
        </table>
</div>

</asp:Content>
