using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta.Lib
{
   public class MovieFacade
    {
       private IPlayer Player;
       public MovieFacade(IPlayer player)
       {
           this.Player = player;
       }
       public void Play(string movieName)
       {
           Player.PlayMovie(movieName);
       }
    }
}
