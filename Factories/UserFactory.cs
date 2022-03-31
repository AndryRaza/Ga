using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDesAbsencesv1.Models;
using Ga.Services;
using Ga.ViewModels;


namespace Ga.Factories
{
    class UserFactory
    {
        readonly DB db = new();
        private UserViewModel UserVM = new();

        public UserFactory(int number, string rol)
        {
            for (int x = 0; x <= number; x++)
            {
                Role role = db.Roles.Where(c => c.Label == rol).First();

                User user = new User();
                user.LastName = Faker.Name.Last();
                user.FirstName = Faker.Name.First();
                user.Mail = Faker.Internet.Email();
                user.RoleId = role.RoleId;

                UserVM.Store(user);
                UserVM.associatePromotion(user.UserId, 1);
            }
        }

    }
}
