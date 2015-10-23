using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tenta.Lib;

namespace Tenta.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerFactory factory = new PlayerFactory();
            IPlayer player = factory.CreatePlayer("SF");
            MovieFacade facade = new MovieFacade(player);
            facade.Play("Bad Boyz II");
            Console.ReadLine();
        }
    }
}
