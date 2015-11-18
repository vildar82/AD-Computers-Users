using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
   public partial class Form1 : Form
   {
      private List<UserData> _users = new List<UserData> ();
      private const string _usersFile = @"c:\temp\САПР\РеестрПользователейЕЦП\users.txt";
      private const string _compsFile = @"c:\temp\САПР\РеестрПользователейЕЦП\comps.txt";

      public Form1()
      {
         InitializeComponent();
      }

      private void buttonGetUsers_Click(object sender, EventArgs e)
      {
         _users = loadUsersFromTxt();
         if (_users.Count == 0)
         {            
            string domainName = textBoxDomain.Text;
            using (PrincipalContext ctx = new PrincipalContext(ContextType.Domain, domainName))
            {               
               GroupPrincipal group = GroupPrincipal.FindByIdentity(ctx, textBoxGroup.Text);
               if (group != null)
               {
                  HashSet<UserData> usersHash = new HashSet<UserData>();
                  IterateGroup(group, usersHash);
                  _users = usersHash.ToList();
               }
               else
               {
                  MessageBox.Show("Группа не найдена");
               }
            }
         }
         listBoxUsers.DataSource = _users.ToList();
         saveUsersToTxt(_users);     

         MessageBox.Show("Готово");
      }

      private List<UserData> loadUsersFromTxt()
      {
         List<UserData> users = new List<UserData>();
         if (File.Exists(_usersFile))
         {
            var lines = File.ReadAllLines(_usersFile);
            foreach (var line in lines)
            {
               UserData user = new UserData(line);
               users.Add(user);
            }
            users.Sort();     
         }
         return users;
      }

      private void saveUsersToTxt(List<UserData> users)
      {
         File.WriteAllLines(_usersFile, users.Select(u=>u.ToString()));
      }

      private void IterateGroup(GroupPrincipal group, HashSet<UserData> usersHash)
      {         
         foreach (Principal p in group.GetMembers())
         {  
            if (p is GroupPrincipal)
            {
               IterateGroup((GroupPrincipal)p, usersHash);
            }
            else if (p is UserPrincipal)
            {
               UserData u = new UserData(((UserPrincipal)p).DisplayName, ((UserPrincipal)p).SamAccountName, group.Name);               
               usersHash.Add(u);               
            }
         }
      }

      private void buttonGetComps_Click(object sender, EventArgs e)
      {
         List<CompData> comps = new List<CompData>();
         foreach (var item in _users)
         {
            CompData comp = new CompData(item);
            comps.Add(comp);
         }                  
         SearchComp(comps, "main.picompany.ru");
         SearchComp(comps, "dsk2.picompany.ru");

         saveCompsToTxt(comps);

         MessageBox.Show("Готово");
      }

      private void saveCompsToTxt(List<CompData> comps)
      {
         File.WriteAllLines(_compsFile, comps.Select(c=>c.ToString()));
      }

      private static void SearchComp(List<CompData> comps, string domainName)
      {
         using (PrincipalContext ctx = new PrincipalContext(ContextType.Domain, domainName))
         {
            foreach (var comp in comps)
            {
               if (comp.CompName == null)
               {
                  var sp = new ComputerPrincipal(ctx);
                  sp.Description = comp.User.Name;
                  var searcher = new PrincipalSearcher(sp);
                  var res = searcher.FindAll();
                  foreach (var p in res)
                  {
                     if (p is ComputerPrincipal)
                     {
                        var findComp = (ComputerPrincipal)p;
                        comp.CompName = findComp.Name;
                        comp.CompPath = findComp.DistinguishedName;
                     }
                  }
               }
            }
         }
      }
   }
}
