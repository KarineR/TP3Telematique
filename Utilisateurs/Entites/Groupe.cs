using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entites.Utilisateurs
{
  public class Groupe
  {
    public const string FICHIER_LISTE_GROUPE = "groupes.xml";

    public Groupe() { }
    public Groupe(string nom, List<Guid> pairs, Guid AdminId)
    {
      this.Id = Guid.NewGuid();
      this.Nom = nom;
      this.Pairs = pairs;
      this.AdministrateurId = AdminId;
      this.Fichiers = new List<Fichier>();
    }

    public Guid Id { get; set; }
    public string Nom {get; set; }
    public List<Guid> Pairs { get; set; }
    public Guid AdministrateurId { get; set; }
    public List<Fichier> Fichiers { get; set; }
  }
}
