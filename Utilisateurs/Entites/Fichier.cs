using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entites.Utilisateurs
{
  public class Fichier
  {
    public Fichier() { }

    public int FichierId { get; set; }
    public string Nom { get; set; }
    public DateTime DateModification { get; set; }
  }
}
