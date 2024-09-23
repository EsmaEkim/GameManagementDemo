using GameManagementDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementDemo.Abstract
{
    class BaseGameManager : IGameService
    {
        public void Delete(Games games)
        {
            Console.WriteLine("Das Spiel " + games.Name + " wurde gelöscht.");
        }

        public void Add(Games games)
        {
            Console.WriteLine("Das Spiel " + games.Name + " wurde zur Spieleliste hinzugefügt.");
        }

        public void Update(Games games)
        {
            Console.WriteLine("Das Spiel "+ games.Name +" wurde aktualisiert");
        }
    }
}
