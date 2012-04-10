using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Script.Services;
using IFT585_TP3.Wrapper;
using Entites.Utilisateurs;
using Utilities.Helpers;

namespace IFT585_TP3
{
  public partial class GestionFichiers : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod()]
    [ScriptMethod()]
    public static List<AffichageFichierWrapper> GetFileList(List<string> clientSideFiles)
    {
      List<Fichier> fichiersServeur = SerializationHelper.DeserializeXml<Fichier>(Fichier.
    }
  }
}