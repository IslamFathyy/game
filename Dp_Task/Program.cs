using Dp_Task.Ground;
using Newtonsoft.Json;
using System;


namespace Dp_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            LevelOne_Builder game = new LevelOne_Builder();

            //LevelTwo_Builder game = new LevelTwo_Builder();

            var ground = game.Build();

            Console.WriteLine(JsonConvert.SerializeObject(ground.Ground));


        }
    }
}
