using System;
using System.Collections.Generic;
using System.Text;

namespace Dp_Task.Keys
{
    class SilverKey : Ikey
    {
        public string Key { get; set; }

        public SilverKey()
        {
            Key = "Silver Key";
        }
        public void openBox(Ibox box)
        {
            box.Available = true;
        }
    }
}
