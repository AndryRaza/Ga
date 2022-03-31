using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ga.Factories;

namespace Ga.Services
{
    class Seeds
    {
        public Seeds()
        {
            new RoleFactory();
            new UserFactory(20, "étudiant");
        }
    }
}
