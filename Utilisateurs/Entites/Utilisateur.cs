using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Utilisateurs;

namespace Entites.Utilisateurs
{
  [Serializable]
  public class Utilisateur
  {
    public const string FICHIER_LISTE_UTILISATEUR = "users.xml";

    public Utilisateur() : this(string.Empty, string.Empty, string.Empty) { }
    public Utilisateur(string adresseFixe, string password, string cheminDossier) 
    {
      this.PairGuid = Guid.NewGuid();
      this.AdresseFixe = adresseFixe;
      this.Password = password;
      this.CheminDossierPartage = cheminDossier;
    }

    public Guid PairGuid { get; set; }
    public string AdresseFixe { get; set; }
    public string Password { get; set; }
    public string CheminDossierPartage { get; set; }
    public List<Groupe> Groupes { get; set; }
  }
}
