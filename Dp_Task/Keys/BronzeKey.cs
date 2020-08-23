using System;
using System.Collections.Generic;
using System.Text;

namespace Dp_Task.Keys
{
    class BronzeKey : Ikey
    {
        public string Key { get; set; }

        public BronzeKey()
        {
            Key = "Bronze Key";
        }
        public void openBox(Ibox box)
        {
            box.Available = true;
        }
    }
}
