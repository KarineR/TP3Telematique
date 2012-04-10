<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="GestionFichiers.aspx.cs" Inherits="IFT585_TP3.GestionFichiers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .folderContent 
    {
        border:1px solid black;
    }
        </style>

    <script type="text/javascript">
    var folderPath = "<%= Session["Folder"].ToString().Replace("\\", "\\\\") %>";
    $(document).ready(function () {
        
        var fso = new ActiveXObject("Scripting.FileSystemObject");
        if (fso.FolderExists(folderPath)) {
            var folder = fso.GetFolder(folderPath);
            var enu = new Enumerator(folder.Files);
            var impair = false;
            for (; !enu.atEnd(); enu.moveNext()) {
                var trClass = "divTr";
                if (impair) trClass += " divTrImpair";
                $(".folderContent").append("<div class='" + trClass + "'><div>" + enu.item().Name + "</div></div>");   
                impair = !impair;           
            }
        } else {
            $(".folderContent").html("Le dossier '" + folderPath + "' n'existe pas.");
        }
    });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Gestion des fichiers</h2>
    <div class="folderContent" style="width:150px;">
    </div>
</asp:Content>
