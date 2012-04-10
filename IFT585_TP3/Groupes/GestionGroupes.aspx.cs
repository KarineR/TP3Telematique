using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entites.Utilisateurs;
using Utilities.Helpers;

namespace IFT585_TP3
{
  public partial class GestionGroupes : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      List<Groupe> groupsList = SerializationHelper.DeserializeXml<Groupe>(Server.MapPath("~/App_Data/").ToString() + Groupe.FICHIER_LISTE_GROUPE);
      List<Groupe> isMemberList = groupsList.Where(item => item.Pairs.Contains(new Guid(Session["PairGuid"].ToString()))).ToList();

      Table table = new Table();

      //Entete du tableau
      TableHeaderRow header = new TableHeaderRow();

      TableHeaderCell thCol1 = new TableHeaderCell();
      TableHeaderCell thCol2 = new TableHeaderCell();
      TableHeaderCell thCol3 = new TableHeaderCell();
      thCol1.Text = "Nom";
      thCol1.CssClass = "tableHeader";
      thCol2.Text = "Administrateur";
      thCol2.CssClass = "tableHeader";
      thCol3.Text = "Actions";
      thCol3.CssClass = "tableHeader";
      header.Cells.Add(thCol1);
      header.Cells.Add(thCol2);
      header.Cells.Add(thCol3);
      table.Rows.Add(header);

      bool impair = false;
      foreach (Groupe groupe in isMemberList)
      {
        TableRow row = new TableRow();
        row.CssClass = "divTr";
        if (impair) row.CssClass += " divTrImpair";
        impair = !impair;
        
        TableCell tdNom = new TableCell();
        TableCell tdAdmin = new TableCell();
        TableCell tdAction = new TableCell();

        if (groupe.AdministrateurId.Equals(new Guid(Session["PairGuid"].ToString())))
        {
          Button btnAdmin = new Button();
          btnAdmin.Text = "Modifier";
          btnAdmin.OnClientClick = "modifierClick";
          tdAdmin.Text = "X";
          tdAction.Controls.Add(btnAdmin);
        }
        else
        {
          tdAdmin.Text = "";
          tdAction.Text = "";
        }
        tdNom.Text = groupe.Nom;
        tdNom.Style.Value = "padding:0px 0px 0px 5px;";
        tdAdmin.HorizontalAlign = HorizontalAlign.Center;
        tdAction.HorizontalAlign = HorizontalAlign.Center; ;
        row.Cells.Add(tdNom);
        row.Cells.Add(tdAdmin);
        row.Cells.Add(tdAction);
        table.Rows.Add(row);
        
      }

      listeGroupes.Controls.Add(table);
    }

    public void btnCreerClick(object sender, EventArgs e)
    {
      Response.Redirect("~/Groupes/CreerGroupe.aspx");
    }
  }
}