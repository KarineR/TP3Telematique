using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entites.Utilisateurs;
using Utilities.Helpers;

namespace IFT585_TP3.Account
{
  public partial class Register : System.Web.UI.Page
  {
    protected void CreateUser(object sender, EventArgs e)
    {
      try
      {
        Utilisateur pair = new Utilisateur(UserName.Text, Password.Text, txtCheminAcces.Text);
        SerializationHelper.SerializeToXml<Utilisateur>(new List<Utilisateur>() { pair }, Server.MapPath("~/App_Data/") + Utilisateur.FICHIER_LISTE_UTILISATEUR);
      }
      catch (Exception ex)
      {
        ErrorMessage.Text = "Erreur lors de la création, veuillez réessayer.";
      }

      Response.Redirect(new Uri(Context.Request.Url, ResolveUrl("~/Account/Login.aspx")).ToString() + "?CreateSuccess=true");
    }
  }
}
