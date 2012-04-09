using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities.Helpers;
using Entites.Utilisateurs;

namespace IFT585_TP3.Account
{
  public partial class Login : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Request.QueryString["CreateSuccess"] == "true")
      {
        LoginSuccess.Text = "Votre inscription est réussie, il ne vous reste plus qu'à vous connecter!";
      }
      RegisterHyperLink.NavigateUrl = "Register.aspx";
    }

    public void LoginClick(object sender, EventArgs e)
    {
      List<Utilisateur> utilisateurs = SerializationHelper.DeserializeXml<Utilisateur>(Server.MapPath("~/App_Data/").ToString() + Utilisateur.FICHIER_LISTE_UTILISATEUR);
      Utilisateur utilisateur = utilisateurs.Find(user => user.AdresseFixe.Equals(LoginUser.UserName) && user.Password.Equals(LoginUser.Password));
      if (utilisateur != null)
      {
        Session["LoggedIn"] = true;
        Session["PairGuid"] = utilisateur.PairGuid.ToString();
        Session["Username"] = utilisateur.AdresseFixe;
      }

      Response.Redirect("~/Default.aspx");
    }
  }
}
