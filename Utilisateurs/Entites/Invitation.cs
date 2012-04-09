using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entites.Utilisateurs
{
  public class Invitation
  {
    public Invitation() { }

    public int InvitationId { get; set; }
    public int GroupeId { get; set; }
    public int PairId { get; set; }
  }
}
