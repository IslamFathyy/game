using System;
using System.Collections.Generic;
using System.Text;

namespace Dp_Task
{
    public interface Ikey
    {
        string Key { get; set; }
        void openBox(Ibox box);
    }
}
