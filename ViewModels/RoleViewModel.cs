using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDesAbsencesv1.Models;
using Ga.Services;

namespace Ga.ViewModels
{
    class RoleViewModel
    {
        readonly DB db = new();

        public void store(string role)
        {
            Role role1 = new Role();
            role1.Label = role;
            db.Roles.Add(role1);
            db.SaveChanges();
        }
        
    }
}
