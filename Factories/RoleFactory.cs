using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ga.ViewModels;

namespace Ga.Factories
{
    class RoleFactory
    {
        public List<string> TabRole = new() { "étudiant", "admin", "formateur", "secrétaire" };
        readonly RoleViewModel roleVM = new();
        public RoleFactory()
        {
            foreach(string role in TabRole)
            {
                roleVM.store(role);
            }
        }
    }
}
