using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entites.Utilisateurs
{
  public class Groupe
  {
    public Groupe() { }

    public int Id { get; set; }
    public List<Utilisateur> Pairs { get; set; }
    public int AdministrateurId { get; set; }
    public List<Fichier> Fichiers { get; set; }
  }
}
