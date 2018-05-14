using System;
using System.Collections.Generic;
using System.Linq;


namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание списка IEnumerable типа IShape
            var shapes = new List<IShape>();

            //Добавление в список экземпляра класса Bomb
            shapes.Add(new Bomb(40, 25, ConsoleColor.White));

            var engine = new Render();

            //Запуска метода Draw для списка
            engine.Draw(shapes);

            Console.ReadKey();
        }
    }


}