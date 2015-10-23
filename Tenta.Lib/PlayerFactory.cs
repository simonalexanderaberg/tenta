using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta.Lib
{
    public class PlayerFactory
    {
        private IPlayer player;
        public IPlayer CreatePlayer(string company)
        {
            if (company == "SF")
                return new SFPlayer(player);
            else
                return new NetflixPlayer(player);
        }
    }
}
