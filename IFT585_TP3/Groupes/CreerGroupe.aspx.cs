using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities.Helpers;
using Entites.Utilisateurs;

namespace IFT585_TP3.Groupes
{
  public partial class CreerGroupe : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      List<Utilisateur> usersList = SerializationHelper.DeserializeXml<Utilisateur>(Server.MapPath("~/App_Data/").ToString() + Utilisateur.FICHIER_LISTE_UTILISATEUR);
      chkUsers.DataSource = usersList.Where(item => !item.PairGuid.ToString().Equals(Session["PairGuid"].ToString()));
      chkUsers.DataTextField = "AdresseFixe";
      chkUsers.DataValueField = "PairGuid";
      if (!IsPostBack) { chkUsers.DataBind(); }
    }

    public void btnSubmit_Click(object sender, EventArgs e)
    {
      try
      {
        //List<ListItem> selectedItems = new List<ListItem>(chkUsers.Items).Where(item => item.Selected);
        List<ListItem> selectedItems = chkUsers.Items.Cast<ListItem>().Where(item => item.Selected).ToList();
        List<Guid> membres = new List<Guid>();
        selectedItems.ForEach(item => membres.Add(new Guid(item.Value)));
        membres.Add(new Guid(Session["PairGuid"].ToString()));
        Groupe groupe = new Groupe(GroupName.Text, membres,  new Guid(Session["PairGuid"].ToString()));
        SerializationHelper.SerializeToXml<Groupe>(new List<Groupe>() { groupe }, Server.MapPath("~/App_Data/") + Groupe.FICHIER_LISTE_GROUPE);
      }
      catch (Exception ex)
      {
      }
    }
  }
}