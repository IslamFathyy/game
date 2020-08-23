using System;
using System.Collections.Generic;
using System.Text;

namespace Dp_Task.boxes
{
    class BoxContext
    {
        private Ibox _box;

        public BoxContext(Ibox box)
        {
            _box = box;
        }

        public void increase(IActor user)
        {
            _box.Increase_Values(user);
        }
    }
}
