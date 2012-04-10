using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using IFT585_TP3.Wrapper;
using Entites.Utilisateurs;
using Utilities.Helpers;

namespace IFT585_TP3
{
  /// <summary>
  /// Description résumée de General
  /// </summary>
  [WebService(Namespace = "http://tempuri.org/")]
  [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
  [System.ComponentModel.ToolboxItem(false)]
  // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
  [System.Web.Script.Services.ScriptService]
  public class General : System.Web.Services.WebService
  {

    [WebMethod]
    public string HelloWorld()
    {
      return "Hello World";
    }

    [WebMethod()]
    public List<AffichageFichierWrapper> GetFileList(List<string> clientFolders)
    {
      List<AffichageFichierWrapper> listeRetour = new List<AffichageFichierWrapper>();
      List<Fichier> tousFichiersServeur = SerializationHelper.DeserializeXml<Fichier>(Server.MapPath("~/App_Data/").ToString() + Fichier.FICHIER_LISTE_FICHIERS);
      //List<Groupe> groupes = SerializationHelper.DeserializeXml<Groupe>(Server.MapPath("~/App_Data/").ToString() + Groupe.
      //List<Fichier> fichiersServeur = tousFichiersServeur.Where(item => item.Groupes

      foreach (string clientFolder in clientFolders)
      {
        string[] info = clientFolder.Split('|');
        listeRetour.Add(new AffichageFichierWrapper(Guid.NewGuid(), info[0], info[1], string.Empty, new List<Groupe>()));
      }
    }
  }
}
