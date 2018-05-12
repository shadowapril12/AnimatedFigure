using System;
using System.Threading;

namespace Figure
{
    /// <summary>
    /// Класс Smashes, производый от абстрактного класса Shapes
    /// </summary>
    class Smashes : Shape
    {
        //Свойство хранящее цвет 
        public ConsoleColor Color { get; set; }

        public enum Directions
        {
            Down,
            Left,
            Right,
            Up,
            LeftDown,
            LeftUp,
            RightUp,
            RightDown  
        }

        //Направление движения импровизированного осколка
        private Directions Dir { get;  }

        /// <summary>
        /// Конструктор класса Smashes
        /// </summary>
        /// <param name="x">Координата по оси x</param>
        /// <param name="y">Координата по оси y</param>
        /// <param name="color">Цвет импровизированного осколка</param>
        /// <param name="direction">Направление движения осколка</param>
        public Smashes(int x, int y, ConsoleColor color, Directions d) : base(x, y)
        {
            this.Color = color;
            this.Dir = d;
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

        protected void Wait(int time)
        {
            Thread.Sleep(time);
        }

        /// <summary>
        /// Переопределенный метод Draw для отрисовки осколков
        /// </summary>
        /// <param name="render">Экземпляр типа IRender</param>
        public override void Draw(IRender render)
        {

            switch(Dir)
            {
                //Если значение свойства 'Direction' равно 'down', то движение осколка направлено строго вниз
                case Directions.Down:
                    for (int i = Y; i < 20; i++)
                    {
                        //Осколко представляет собой 4 пикселя
                        SetQuadroPixel(X, i, Color);

                        //Остановка потока на 20 млсекунд
                        Wait(100);

                        //Очиска консоли
                        Console.Clear();
                    }
                    break;

                case Directions.Left:
                    for (int i = X; i > 0; i--)
                    {
                        SetQuadroPixel(i, Y, Color);
                        Wait(100);
                        Console.Clear();
                    }
                    break;

                case Directions.LeftDown:
                    for (int i = Y; i < 25; i++)
                    {
                        X--;
                        SetQuadroPixel(X, i, Color);
                        Wait(100);
                        Console.Clear();
                    }
                    break;

                case Directions.LeftUp:
                    for (int i = Y; i > 0; i--)
                    {
                        X--;
                        SetQuadroPixel(X, i, Color);
                        Wait(100);
                        Console.Clear();
                    }
                    break;

                case Directions.Right:
                    for (int i = X; i < 80; i++)
                    {
                        SetQuadroPixel(i, Y, Color);
                        Wait(100);
                        Console.Clear();
                    }
                    break;

                case Directions.RightDown:
                    for (int i = Y; i < 25; i++)
                    {
                        X++;
                        SetQuadroPixel(X, i, Color);
                        Wait(100);
                        Console.Clear();
                    }
                    break;

                case Directions.RightUp:
                    for (int i = Y; i > 0; i--)
                    {
                        X++;
                        SetQuadroPixel(X, i, Color);
                        Wait(100);
                        Console.Clear();
                    }
                    break;

                case Directions.Up:
                    for (int i = Y; i > 0; i--)
                    {
                        SetQuadroPixel(X, i, Color);
                        Wait(100);
                        Console.Clear();
                    }
                    break;
            }
        }
    }
}
