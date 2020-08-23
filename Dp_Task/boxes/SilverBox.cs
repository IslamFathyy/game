using System;
using System.Collections.Generic;
using System.Text;

namespace Dp_Task.boxes
{
    class SilverBox:Ibox
    {
        public bool Available { get; set; }
        public SilverBox()
        {
            Available = false;
        }
        public void Increase_Values(IActor user)
        {
            if (Available)
            {
                user.Health += 40;
                user.Weapon += 10;
            }     
        }
    }
}
