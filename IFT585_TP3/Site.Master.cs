using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IFT585_TP3
{
  public partial class SiteMaster : System.Web.UI.MasterPage
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (HttpContext.Current != null && HttpContext.Current.Session != null)
      {
        if (Session["LoggedIn"] != null && !Session["LoggedIn"].Equals(string.Empty))
        {
          lnkConnected.Text = "Bienvenue " + Session["Username"].ToString();
          lnkConnected.NavigateUrl = string.Empty;
        }
        else
        {
          lnkConnected.Text = "[Se connecter]";
          lnkConnected.NavigateUrl = ResolveUrl("~/Account/Login.aspx");
          // Si on n'est pas connecté, on n'affiche aucun menu.
          NavigationMenu.Items.Clear();
        }
      }
    }
  }
}
