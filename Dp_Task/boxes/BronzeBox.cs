using System;
using System.Collections.Generic;
using System.Text;
using Dp_Task.Keys;

namespace Dp_Task.boxes
{
    class BronzeBox : Ibox
    {
        public bool Available { get; set ; }
        public BronzeBox()
        {
            Available = false;
        }
        public void Increase_Values(IActor user)
        {
            if(Available)
                user.Health += 20;
        }
    }
}
