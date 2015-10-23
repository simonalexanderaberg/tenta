using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta.Lib
{
    public class NetflixPlayer:IPlayer
    {
        private IPlayer Player;
        public bool HasBeenPlayed { get; set; }
        public NetflixPlayer(IPlayer player)
        {
            this.Player = player;
        }
        public void PlayMovie(string movieName)
        {
            Debug.WriteLine("Netflix: " + movieName);
            HasBeenPlayed = true;
        }
    }
}
