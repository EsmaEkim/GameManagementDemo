using GameManagementDemo.Abstract;
using GameManagementDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementDemo.Concrete
{
    public class GamerServiceManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public GamerServiceManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
               
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Die Informationen gehören nicht zu einem gültigen Benutzer");
            }
        }

       
    }
}
