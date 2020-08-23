using System;
using System.Collections.Generic;
using System.Text;

namespace Dp_Task.Keys
{
    class KeyContext
    {
        private Ikey _key;
        public KeyContext(Ikey key)
        {
            _key = key;
        }
        public void openBox(Ibox box)
        {
            _key.openBox(box);
        }
    }
}
