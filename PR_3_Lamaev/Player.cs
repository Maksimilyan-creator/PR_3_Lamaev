﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_3_Lamaev
{
    internal class Player
    {
        public string Name { get; set; }
        public int Point { get; set; }
        public Player (string name, int point)
        {
            Name = name;
            Point = point;
        }
    }
}
