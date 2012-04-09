using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace IFT585_TP3
{
  public class Global : System.Web.HttpApplication
  {

    void Application_Start(object sender, EventArgs e)
    {
      // Code qui s'exécute au démarrage de l'application

    }

    void Application_End(object sender, EventArgs e)
    {
      //  Code qui s'exécute à l'arrêt de l'application

    }

    void Application_Error(object sender, EventArgs e)
    {
      // Code qui s'exécute lorsqu'une erreur non gérée se produit

    }

    void Session_Start(object sender, EventArgs e)
    {
      // Code qui s'exécute lorsqu'une nouvelle session démarre
      if (HttpContext.Current != null && HttpContext.Current.Session != null)
      {
        Session.Add("LoggedIn", string.Empty);
        CheckLogin();
      }
    }

    void Session_End(object sender, EventArgs e)
    {
      // Code qui s'exécute lorsqu'une session se termine. 
      // Remarque : l'événement Session_End est déclenché uniquement lorsque le mode sessionstate
      // a la valeur InProc dans le fichier Web.config. Si le mode de session a la valeur StateServer 
      // ou SQLServer, l'événement n'est pas déclenché.

    }

    void Application_OnPostRequestHandlerExecute()
    {
      CheckLogin();
    }

    void CheckLogin()
    {
      if (HttpContext.Current != null && HttpContext.Current.Session != null)
      {
        if (Session["LoggedIn"] != null && Session["LoggedIn"].Equals(string.Empty) && !Request.RawUrl.Contains("/Account/Login.aspx") && !Request.RawUrl.Contains("/Account/Register.aspx"))
        {
          Response.Redirect("~/Account/Login.aspx");
        }
      }
    }
  }
}
