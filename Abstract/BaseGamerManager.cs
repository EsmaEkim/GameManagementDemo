using GameManagementDemo.Adapters;
using GameManagementDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementDemo.Abstract
{
    public class BaseGamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public BaseGamerManager()
        {
        }

        public BaseGamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Die Informationen des Nutzers namens " + gamer.FirstName + " " + gamer.LastName + " wurden gelöscht.");
        }

        public virtual void Save(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Der Nutzer namens " + gamer.FirstName + " " + gamer.LastName + " wurde in die Datenbank eingetragen.");
            }
            else
            {
                Console.WriteLine("Benutzerüberprüfung fehlgeschlagen");
            }
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Die Informationen des Nutzers namens " +gamer.FirstName + " " +  gamer.LastName + " wurden aktualisiert.");
        }
    }
}
