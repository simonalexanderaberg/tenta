﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta.Lib
{
    public class SFPlayer:IPlayer
    {
        private IPlayer Player;
        public bool HasBeenPlayed { get; set; }
        public SFPlayer(IPlayer player)
        {
            this.Player = player;
        }
        public void PlayMovie(string movieName)
        {
            Debug.WriteLine("SF: " + movieName);
            HasBeenPlayed = true;
        }
    }
}
