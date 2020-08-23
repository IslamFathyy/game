using System;
using System.Collections.Generic;
using System.Text;
using Dp_Task.boxes;

namespace Dp_Task.Keys
{
    class GoldKey : Ikey
    {
        public string Key { get; set; }

        public GoldKey()
        {
            Key = "Gold key";
        }
        public void openBox(Ibox box)
        {
            box.Available = true;
        }
    }
}
