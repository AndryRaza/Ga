using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ga.Factories;
using GestionDesAbsencesv1.Models;

namespace Ga.Services
{
    class Seeds
    {
        readonly DB db = new();
        public Seeds()
        {
            new RoleFactory();
            new PromotionFactory();
            new UserFactory(1, "formateur");
            new UserFactory(20, "étudiant");
    
        }
    }
}
