using System;
using System.Collections.Generic;
using System.Text;

namespace Dp_Task
{
    public interface Ibox
    {
        bool Available { get; set; }
        void Increase_Values(IActor user);
    }
}
