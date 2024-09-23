using GameManagementDemo.Abstract;
using GameManagementDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementDemo.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DateOfBirth == new DateTime(2002, 02, 17) && gamer.FirstName == "Hans" && gamer.LastName == "Müller" && gamer.NationalityId == 0987654321 && gamer.Id==1) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
