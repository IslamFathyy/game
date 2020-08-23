using System;
using System.Collections.Generic;
using System.Text;

namespace Dp_Task.Ground
{
    interface IBuilder
    {
        void SetKey();
        void SetBox();
        void SetEnemy();
        void SetUser();
        void SetMagicalDiamond();
        dessert Build();
    }
}
