﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double UnitPrice { get; set; }
        public double DiscountPrice { get; set; }

    }
}