using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entites.Utilisateurs;

namespace IFT585_TP3.Wrapper
{
  public class AffichageFichierWrapper
  {
    public AffichageFichierWrapper() { }
    public AffichageFichierWrapper(Guid fichierId, string nomFichier, string dateLocale, string dateServeur, List<Groupe> groupes)
    {
      FichierId = fichierId;
      NomFichier = nomFichier;
      DateLocale = dateLocale;
      DateServeur = dateServeur;
      Groupes = groupes;
    }


    public Guid FichierId { get; set; }
    public string NomFichier { get; set; }
    public string DateLocale { get; set; }
    public string DateServeur { get; set; }
    public List<Groupe> Groupes { get; set; }
  }
}