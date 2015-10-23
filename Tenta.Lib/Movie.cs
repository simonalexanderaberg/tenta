using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta.Lib
{
   public class Movie
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int LengthInMinutes { get; set; }
        public string Website { get; set; }
        public IList<Actor> Actors { get; set; }
    }
}
