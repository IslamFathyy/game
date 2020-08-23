using System;
using System.Collections.Generic;
using System.Text;

namespace Dp_Task.Actors
{
    public class enemy : IActor
    {
        public int Health { get; set; }
        public int Weapon { get; set; }

        public enemy()
        {
            Health = 100;
            Weapon = 100;
        }
    }
}
