using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
   public class CompData
   {
      public UserData User;
      public string CompName;
      public string CompPath;

      public CompData (UserData user)
      {
         User = user;
      }

      public override string ToString()
      {
         return string.Format("{0};{1};{2};{3}", User.Name, User.Login, CompName, CompPath);
      }
   }
}
