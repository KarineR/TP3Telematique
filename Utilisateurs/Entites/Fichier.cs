using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entites.Utilisateurs
{
  public class Fichier
  {
    public const string FICHIER_LISTE_FICHIERS = "fichiers.xml";
    public Fichier() { }

    public Guid FichierId { get; set; }
    public string Nom { get; set; }
    public DateTime DateModification { get; set; }
  }
}
