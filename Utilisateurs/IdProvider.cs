using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilisateurs
{
  public static class IdProvider
  {
    private static int _id = 0;

    public static int GetId()
    {
      return _id++;
    }
  }
}
