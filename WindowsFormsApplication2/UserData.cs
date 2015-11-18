using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
   public class UserData : IComparable <UserData>
   {
      public string Name;
      public string Login;
      public string Group;

      public UserData (string textline)
      {
         var res = textline.Split(';');
         Name = res[0];
         Login = res[1];
         Group = res[2];
      }

      public UserData (string name , string login, string group)
      {
         Name = name;
         Login = login;
         Group = group;
      }

      public override string ToString()
      {
         return string.Format("{0};{1};{2}", Name, Login, Group);
      }

      public int CompareTo(UserData other)
      {
         return Login.CompareTo(other.Login);
      }

      public override bool Equals(object obj)
      {
         UserData u = obj as UserData;
         return u != null && u.Login == Login;
      }

      public override int GetHashCode()
      {
         return Login.GetHashCode(); 
      }
   }
}
