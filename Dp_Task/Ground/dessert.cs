using Dp_Task.Actors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dp_Task.Ground
{
    public class dessert
    {
        private static dessert obj { get; set; }

        public Object[,] Ground;
        public Ikey Key { get; set; }
        public Ibox Box { get; set; }
        public enemy Enemy { get; set; }
        public user user { get; set; }
        public MagicalDiamond MagicalDiamond { get; set; }

        private dessert(){ }

        public static dessert GetDessert()
        {
            if (obj == null)
            {
                obj = new dessert();
                return obj;
            }
            else
                return obj;
        }
    }
}
