using System;
using System.Collections.Generic;
using System.Threading;

namespace Figure
{
    /// <summary>
    /// Класс Render - реализовывает интерфейс IRender
    /// </summary>
    class Render : IRender
    {
        //Свойство-счетчик Frame
        public int Frame { get; private set; }

        /// <summary>
        /// Служит для скрытия курсора
        /// </summary>
        private void PrepareEnv()
        {
            Console.CursorVisible = false;
        }

        /// <summary>
        /// Служит для вызова метода Draw на каждом объекте в списке IEnemerable типа IShape
        /// </summary>
        /// <param name="shapes">Список объектов</param>
        public void Draw(IEnumerable<IShape> shapes)
        {
            ///Вызов функции для скрытия курсора
            this.PrepareEnv();
            //Вызов метода Draw на каждом объекте в списке
            while (true)
            {
                foreach (var shape in shapes)
                {
                    shape.Draw(this);
                }
                //Пауза
                Wait(300);
                //Очиска консоли
                Clear();
                //Увеличение счетчика
                this.Frame++;
            }
        }
        //Метод остановки основного потока на 300 милисекунд
        protected void Wait(int time)
        {
            Thread.Sleep(time);
        }

        //Метод очиски консоли
        private void Clear()
        {
            Console.Clear();
        }

        /// <summary>
        /// SetPixel служит для отрисовки пикселя
        /// </summary>
        /// <param name="x">Координата по оси x</param>
        /// <param name="y">Координата по оси y</param>
        /// <param name="color">Цвет пикселя</param>
        public void SetPixel(int x, int y, ConsoleColor color)
        {
            if (x < 0 || y < 0)
            {
                return;
            }

            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write("■");
        }
        //Вышеописанный метод, только для отрисовки двух пикселей
        public void SetDoublePixel(int x, int y, ConsoleColor color)
        {
            if (x < 0 || y < 0)
            {
                return;
            }
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write("■");
            Console.SetCursorPosition(x - 1, y);
            Console.Write("■");
        }

        //Метод для отрисовки четырех пикселей
        public void SetQuadroPixel(int x, int y, ConsoleColor color)
        {
            if (x < 0 || y < 0)
            {
                return;
            }
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write("■");
            Console.SetCursorPosition(x - 1, y);
            Console.Write("■");
            Console.SetCursorPosition(x - 1, y + 1);
            Console.Write("■");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("■");
        }
    }
}
