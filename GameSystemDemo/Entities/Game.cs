﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystemDemo.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }  
        public float GamePrice { get; set; }  
        public DateTime ReleaseDate { get; set; }  
    }
}
