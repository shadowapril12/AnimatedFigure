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

        //Направление движения импровизированного осколка
        string Direction { get; }

        /// <summary>
        /// Конструктор класса Smashes
        /// </summary>
        /// <param name="x">Координата по оси x</param>
        /// <param name="y">Координата по оси y</param>
        /// <param name="color">Цвет импровизированного осколка</param>
        /// <param name="direction">Направление движения осколка</param>
        public Smashes(int x, int y, ConsoleColor color, string direction) : base(x, y)
        {
            this.Color = color;
            this.Direction = direction;
        }

        /// <summary>
        /// Переопределенный метод Draw для отрисовки осколков
        /// </summary>
        /// <param name="render">Экземпляр типа IRender</param>
        public override void Draw(IRender render)
        {
            //Если значение свойства Direction равно "down", то движение осколка направлено строго вниз
            if (Direction == "down")
            {
                for (int i = Y; i < 20; i++)
                {
                    //Осколко представляет собой 4 пикселя
                    render.SetQuadroPixel(X, i, Color);

                    //Остановка потока на 20 млсекунд
                    Thread.Sleep(100);

                    //Очиска консоли
                    Console.Clear();
                }
            }
            //При значении Direction равного "left" движение осколка влево
            else if (Direction == "left")
            {
                for (int i = X; i > 0; i--)
                {
                    render.SetQuadroPixel(i, Y, Color);
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }
            //Движение осколка вправо
            else if (Direction == "right")
            {
                for (int i = X; i < 80; i++)
                {
                    render.SetQuadroPixel(i, Y, Color);
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }

            //Движение вверх
            else if (Direction == "up")
            {
                for (int i = Y; i > 0; i--)
                {
                    render.SetQuadroPixel(X, i, Color);
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }

            //Движение влево и вниз под углом и т.д
            else if (Direction == "left-down")
            {

                for (int i = Y; i < 25; i++)
                {
                    X--;
                    render.SetQuadroPixel(X, i, Color);
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }
            else if (Direction == "left-up")
            {

                for (int i = Y; i > 0; i--)
                {
                    X--;
                    render.SetQuadroPixel(X, i, Color);
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }

            else if (Direction == "right-up")
            {

                for (int i = Y; i > 0; i--)
                {
                    X++;
                    render.SetQuadroPixel(X, i, Color);
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }

            else if (Direction == "right-down")
            {

                for (int i = Y; i < 25; i++)
                {
                    X++;
                    render.SetQuadroPixel(X, i, Color);
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }
        }
    }
}
