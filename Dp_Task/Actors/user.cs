using System;
using System.Collections.Generic;
using System.Text;

namespace Dp_Task.Actors
{
    public class user : IActor
    {
        public int Health { get; set; }
        public int Weapon { get; set; }

        private static user obj { get; set; }

        private user()
        {
            Health = 100;
            Weapon = 100;
        }

        public static user Get_User()
        {
            if (obj == null)
            {
                obj = new user();
                return obj;
            }
            else
                return obj;
        }
    }
}
