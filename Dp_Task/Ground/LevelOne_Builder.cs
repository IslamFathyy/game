using Dp_Task.Actors;
using Dp_Task.boxes;
using Dp_Task.Keys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dp_Task.Ground
{
    public class LevelOne_Builder : IBuilder
    {
        dessert Dessert = dessert.GetDessert();

        public LevelOne_Builder()
        {
            Dessert.Ground = new object[5, 6];
            SetUser();
            SetEnemy();
            SetBox();
            SetKey();
            SetMagicalDiamond();
        }

        public void SetBox()
        {
            Dessert.Box = new GoldBox();
            Dessert.Ground[2, 5] = Dessert.Box;
        }

        public void SetEnemy()
        {
            Dessert.Enemy = new enemy();
            Dessert.Ground[4, 3] = Dessert.Enemy;
        }

        public void SetKey()
        {
            Dessert.Key = new GoldKey();
            Dessert.Ground[1, 1] = Dessert.Key;
        }

        public void SetMagicalDiamond()
        {
            Dessert.MagicalDiamond = new MagicalDiamond();
            Dessert.Ground[4, 5] = Dessert.MagicalDiamond;
        }

        public void SetUser()
        {
            Dessert.user = user.Get_User();
            Dessert.Ground[0, 0] = Dessert.user;
        }

        public dessert Build()
        {
            return Dessert;
        }
    }
}
