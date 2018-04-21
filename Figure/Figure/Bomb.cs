using System;
using System.Threading;
using System.Threading.Tasks;

namespace Figure
{
    class Bomb : Shape
    {
        /// <summary>
        /// Свойство Color служит для хранения цвета отображаемого объекта
        /// </summary>
        public ConsoleColor Color { get; set; }

        /// <summary>
        /// Конструктор класса Bomb
        /// </summary>
        /// <param name="x">Координата по оси x</param>
        /// <param name="y">Координата по оси y</param>
        /// <param name="color">Цвет отображаемого пикселя</param>
        public Bomb(int x, int y, ConsoleColor color) : base(x, y)
        {
            this.Color = color;
        }

        /// <summary>
        /// Метод Frame1 представляет первоначальную отрисовку бомбы
        /// </summary>
        /// <param name="render">Экземпляр типа Irender</param>
        private void Frame1(IRender render)
        {
            //Левая сторона бомбы
            render.SetDoublePixel(X, Y, Color);
            render.SetDoublePixel(X - 2, Y - 1, Color);
            render.SetDoublePixel(X - 4, Y - 2, Color);
            render.SetDoublePixel(X - 5, Y - 3, Color);
            render.SetDoublePixel(X - 5, Y - 4, Color);
            render.SetDoublePixel(X - 5, Y - 5, Color);
            render.SetDoublePixel(X - 5, Y - 6, Color);
            render.SetDoublePixel(X - 4, Y - 7, Color);
            render.SetDoublePixel(X - 2, Y - 8, Color);
            render.SetDoublePixel(X, Y - 9, Color);
            render.SetDoublePixel(X + 2, Y - 9, Color);
            render.SetDoublePixel(X + 4, Y - 9, Color);

            //Здесь возвращаемся и рисуем топчик с фитилем
            render.SetDoublePixel(X, Y - 10, Color);
            render.SetDoublePixel(X + 2, Y - 10, Color);
            render.SetDoublePixel(X + 4, Y - 10, Color);

            //Фитиль
            render.SetDoublePixel(X + 2, Y - 11, ConsoleColor.DarkYellow);
            render.SetDoublePixel(X + 2, Y - 12, ConsoleColor.DarkYellow);
            render.SetDoublePixel(X + 2, Y - 13, ConsoleColor.DarkYellow);
            render.SetDoublePixel(X + 3, Y - 14, ConsoleColor.DarkYellow);
            render.SetDoublePixel(X + 4, Y - 15, ConsoleColor.DarkYellow);

            //Пламя
            render.SetDoublePixel(X + 4, Y - 16, ConsoleColor.Yellow);
            render.SetPixel(X + 5, Y - 16, ConsoleColor.Red);
            render.SetPixel(X + 2, Y - 16, ConsoleColor.Red);
            render.SetDoublePixel(X + 5, Y - 17, ConsoleColor.Yellow);
            render.SetPixel(X + 6, Y - 17, ConsoleColor.Red);
            render.SetDoublePixel(X + 3, Y - 17, ConsoleColor.Yellow);
            render.SetPixel(X + 1, Y - 17, ConsoleColor.Red);
            render.SetDoublePixel(X + 4, Y - 18, ConsoleColor.Yellow);
            render.SetPixel(X + 5, Y - 18, ConsoleColor.Red);
            render.SetPixel(X + 2, Y - 18, ConsoleColor.Red);
            render.SetDoublePixel(X + 4, Y - 19, ConsoleColor.Red);



            //Правая сторона бомбы
            render.SetDoublePixel(X + 6, Y - 8, Color);
            render.SetDoublePixel(X + 8, Y - 7, Color);
            render.SetDoublePixel(X + 9, Y - 6, Color);
            render.SetDoublePixel(X + 9, Y - 5, Color);
            render.SetDoublePixel(X + 9, Y - 4, Color);
            render.SetDoublePixel(X + 9, Y - 3, Color);
            render.SetDoublePixel(X + 8, Y - 2, Color);
            render.SetDoublePixel(X + 6, Y - 1, Color);

            //Низ бомбы
            render.SetDoublePixel(X + 4, Y, Color);
            render.SetDoublePixel(X + 2, Y, Color);
        }

        ///Далее методы пронумерованные с Frame1 по Frame2 представляют отрисовки
        ///объекта на различных ///временных интервалах
        private void Frame2(IRender render)
        {
            //Левая сторона бомбы
            render.SetDoublePixel(X, Y, Color);
            render.SetDoublePixel(X - 2, Y - 1, Color);
            render.SetDoublePixel(X - 4, Y - 2, Color);
            render.SetDoublePixel(X - 5, Y - 3, Color);
            render.SetDoublePixel(X - 5, Y - 4, Color);
            render.SetDoublePixel(X - 5, Y - 5, Color);
            render.SetDoublePixel(X - 5, Y - 6, Color);
            render.SetDoublePixel(X - 4, Y - 7, Color);
            render.SetDoublePixel(X - 2, Y - 8, Color);
            render.SetDoublePixel(X, Y - 9, Color);
            render.SetDoublePixel(X + 2, Y - 9, Color);
            render.SetDoublePixel(X + 4, Y - 9, Color);

            //Здесь возвращаемся и рисуем топчик с фитилем
            render.SetDoublePixel(X, Y - 10, Color);
            render.SetDoublePixel(X + 2, Y - 10, Color);
            render.SetDoublePixel(X + 4, Y - 10, Color);

            //Фитиль
            render.SetDoublePixel(X + 2, Y - 11, ConsoleColor.DarkYellow);
            render.SetDoublePixel(X + 2, Y - 12, ConsoleColor.DarkYellow);
            render.SetDoublePixel(X + 2, Y - 13, ConsoleColor.DarkYellow);
            render.SetDoublePixel(X + 3, Y - 14, ConsoleColor.DarkYellow);


            //Пламя
            render.SetDoublePixel(X + 4, Y - 15, ConsoleColor.Yellow);
            render.SetPixel(X + 5, Y - 15, ConsoleColor.Red);
            render.SetPixel(X + 2, Y - 15, ConsoleColor.Red);
            render.SetDoublePixel(X + 5, Y - 16, ConsoleColor.Yellow);
            render.SetPixel(X + 6, Y - 16, ConsoleColor.Red);
            render.SetDoublePixel(X + 3, Y - 16, ConsoleColor.Yellow);
            render.SetPixel(X + 1, Y - 16, ConsoleColor.Red);
            render.SetDoublePixel(X + 4, Y - 17, ConsoleColor.Yellow);
            render.SetPixel(X + 5, Y - 17, ConsoleColor.Red);
            render.SetPixel(X + 2, Y - 17, ConsoleColor.Red);
            render.SetDoublePixel(X + 4, Y - 18, ConsoleColor.Red);


            //Правая сторона бомбы
            render.SetDoublePixel(X + 6, Y - 8, Color);
            render.SetDoublePixel(X + 8, Y - 7, Color);
            render.SetDoublePixel(X + 9, Y - 6, Color);
            render.SetDoublePixel(X + 9, Y - 5, Color);
            render.SetDoublePixel(X + 9, Y - 4, Color);
            render.SetDoublePixel(X + 9, Y - 3, Color);
            render.SetDoublePixel(X + 8, Y - 2, Color);
            render.SetDoublePixel(X + 6, Y - 1, Color);

            //Низ бомбы
            render.SetDoublePixel(X + 4, Y, Color);
            render.SetDoublePixel(X + 2, Y, Color);
        }

        private void Frame3(IRender render)
        {
            //Левая сторона бомбы
            render.SetDoublePixel(X, Y, Color);
            render.SetDoublePixel(X - 2, Y - 1, Color);
            render.SetDoublePixel(X - 4, Y - 2, Color);
            render.SetDoublePixel(X - 5, Y - 3, Color);
            render.SetDoublePixel(X - 5, Y - 4, Color);
            render.SetDoublePixel(X - 5, Y - 5, Color);
            render.SetDoublePixel(X - 5, Y - 6, Color);
            render.SetDoublePixel(X - 4, Y - 7, Color);
            render.SetDoublePixel(X - 2, Y - 8, Color);
            render.SetDoublePixel(X, Y - 9, Color);
            render.SetDoublePixel(X + 2, Y - 9, Color);
            render.SetDoublePixel(X + 4, Y - 9, Color);

            //Здесь возвращаемся и рисуем топчик с фитилем
            render.SetDoublePixel(X, Y - 10, Color);
            render.SetDoublePixel(X + 2, Y - 10, Color);
            render.SetDoublePixel(X + 4, Y - 10, Color);

            //Фитиль
            render.SetDoublePixel(X + 2, Y - 11, ConsoleColor.DarkYellow);
            render.SetDoublePixel(X + 2, Y - 12, ConsoleColor.DarkYellow);
            render.SetDoublePixel(X + 2, Y - 13, ConsoleColor.DarkYellow);


            //Пламя
            render.SetDoublePixel(X + 3, Y - 14, ConsoleColor.Yellow);
            render.SetPixel(X + 4, Y - 14, ConsoleColor.Red);
            render.SetPixel(X + 1, Y - 14, ConsoleColor.Red);
            render.SetDoublePixel(X + 4, Y - 15, ConsoleColor.Yellow);
            render.SetPixel(X + 5, Y - 15, ConsoleColor.Red);
            render.SetDoublePixel(X + 2, Y - 15, ConsoleColor.Yellow);
            render.SetPixel(X, Y - 15, ConsoleColor.Red);
            render.SetDoublePixel(X + 3, Y - 16, ConsoleColor.Yellow);
            render.SetPixel(X + 4, Y - 16, ConsoleColor.Red);
            render.SetPixel(X + 1, Y - 16, ConsoleColor.Red);
            render.SetDoublePixel(X + 3, Y - 17, ConsoleColor.Red);


            //Правая сторона бомбы
            render.SetDoublePixel(X + 6, Y - 8, Color);
            render.SetDoublePixel(X + 8, Y - 7, Color);
            render.SetDoublePixel(X + 9, Y - 6, Color);
            render.SetDoublePixel(X + 9, Y - 5, Color);
            render.SetDoublePixel(X + 9, Y - 4, Color);
            render.SetDoublePixel(X + 9, Y - 3, Color);
            render.SetDoublePixel(X + 8, Y - 2, Color);
            render.SetDoublePixel(X + 6, Y - 1, Color);

            //Низ бомбы
            render.SetDoublePixel(X + 4, Y, Color);
            render.SetDoublePixel(X + 2, Y, Color);
        }

        private void Frame4(IRender render)
        {
            //Левая сторона бомбы
            render.SetDoublePixel(X, Y, Color);
            render.SetDoublePixel(X - 2, Y - 1, Color);
            render.SetDoublePixel(X - 4, Y - 2, Color);
            render.SetDoublePixel(X - 5, Y - 3, Color);
            render.SetDoublePixel(X - 5, Y - 4, Color);
            render.SetDoublePixel(X - 5, Y - 5, Color);
            render.SetDoublePixel(X - 5, Y - 6, Color);
            render.SetDoublePixel(X - 4, Y - 7, Color);
            render.SetDoublePixel(X - 2, Y - 8, Color);
            render.SetDoublePixel(X, Y - 9, Color);
            render.SetDoublePixel(X + 2, Y - 9, Color);
            render.SetDoublePixel(X + 4, Y - 9, Color);

            //Здесь возвращаемся и рисуем топчик с фитилем
            render.SetDoublePixel(X, Y - 10, Color);
            render.SetDoublePixel(X + 2, Y - 10, Color);
            render.SetDoublePixel(X + 4, Y - 10, Color);

            //Фитиль
            render.SetDoublePixel(X + 2, Y - 11, ConsoleColor.DarkYellow);
            render.SetDoublePixel(X + 2, Y - 12, ConsoleColor.DarkYellow);


            //Пламя
            render.SetDoublePixel(X + 2, Y - 13, ConsoleColor.Yellow);
            render.SetPixel(X + 3, Y - 13, ConsoleColor.Red);
            render.SetPixel(X, Y - 13, ConsoleColor.Red);
            render.SetDoublePixel(X + 3, Y - 14, ConsoleColor.Yellow);
            render.SetPixel(X + 4, Y - 14, ConsoleColor.Red);
            render.SetDoublePixel(X + 1, Y - 14, ConsoleColor.Yellow);
            render.SetPixel(X - 1, Y - 14, ConsoleColor.Red);
            render.SetDoublePixel(X + 2, Y - 15, ConsoleColor.Yellow);
            render.SetPixel(X + 3, Y - 15, ConsoleColor.Red);
            render.SetPixel(X, Y - 15, ConsoleColor.Red);
            render.SetDoublePixel(X + 2, Y - 16, ConsoleColor.Red);


            //Правая сторона бомбы
            render.SetDoublePixel(X + 6, Y - 8, Color);
            render.SetDoublePixel(X + 8, Y - 7, Color);
            render.SetDoublePixel(X + 9, Y - 6, Color);
            render.SetDoublePixel(X + 9, Y - 5, Color);
            render.SetDoublePixel(X + 9, Y - 4, Color);
            render.SetDoublePixel(X + 9, Y - 3, Color);
            render.SetDoublePixel(X + 8, Y - 2, Color);
            render.SetDoublePixel(X + 6, Y - 1, Color);

            //Низ бомбы
            render.SetDoublePixel(X + 4, Y, Color);
            render.SetDoublePixel(X + 2, Y, Color);
        }

        private void Frame5(IRender render)
        {
            //Левая сторона бомбы
            render.SetDoublePixel(X, Y, Color);
            render.SetDoublePixel(X - 2, Y - 1, Color);
            render.SetDoublePixel(X - 4, Y - 2, Color);
            render.SetDoublePixel(X - 5, Y - 3, Color);
            render.SetDoublePixel(X - 5, Y - 4, Color);
            render.SetDoublePixel(X - 5, Y - 5, Color);
            render.SetDoublePixel(X - 5, Y - 6, Color);
            render.SetDoublePixel(X - 4, Y - 7, Color);
            render.SetDoublePixel(X - 2, Y - 8, Color);
            render.SetDoublePixel(X, Y - 9, Color);
            render.SetDoublePixel(X + 2, Y - 9, Color);
            render.SetDoublePixel(X + 4, Y - 9, Color);

            //Здесь возвращаемся и рисуем топчик с фитилем
            render.SetDoublePixel(X, Y - 10, Color);
            render.SetDoublePixel(X + 2, Y - 10, Color);
            render.SetDoublePixel(X + 4, Y - 10, Color);

            //Фитиль
            render.SetDoublePixel(X + 2, Y - 11, ConsoleColor.DarkYellow);

            //Пламя
            render.SetDoublePixel(X + 2, Y - 12, ConsoleColor.Yellow);
            render.SetPixel(X + 3, Y - 12, ConsoleColor.Red);
            render.SetPixel(X, Y - 12, ConsoleColor.Red);
            render.SetDoublePixel(X + 3, Y - 13, ConsoleColor.Yellow);
            render.SetPixel(X + 4, Y - 13, ConsoleColor.Red);
            render.SetDoublePixel(X + 1, Y - 13, ConsoleColor.Yellow);
            render.SetPixel(X - 1, Y - 13, ConsoleColor.Red);
            render.SetDoublePixel(X + 2, Y - 14, ConsoleColor.Yellow);
            render.SetPixel(X + 3, Y - 14, ConsoleColor.Red);
            render.SetPixel(X, Y - 14, ConsoleColor.Red);
            render.SetDoublePixel(X + 2, Y - 15, ConsoleColor.Red);


            //Правая сторона бомбы
            render.SetDoublePixel(X + 6, Y - 8, Color);
            render.SetDoublePixel(X + 8, Y - 7, Color);
            render.SetDoublePixel(X + 9, Y - 6, Color);
            render.SetDoublePixel(X + 9, Y - 5, Color);
            render.SetDoublePixel(X + 9, Y - 4, Color);
            render.SetDoublePixel(X + 9, Y - 3, Color);
            render.SetDoublePixel(X + 8, Y - 2, Color);
            render.SetDoublePixel(X + 6, Y - 1, Color);

            //Низ бомбы
            render.SetDoublePixel(X + 4, Y, Color);
            render.SetDoublePixel(X + 2, Y, Color);
        }

        private void Frame6(IRender render)
        {
            //Левая сторона бомбы
            render.SetDoublePixel(X, Y, Color);
            render.SetDoublePixel(X - 2, Y - 1, Color);
            render.SetDoublePixel(X - 4, Y - 2, Color);
            render.SetDoublePixel(X - 5, Y - 3, Color);
            render.SetDoublePixel(X - 5, Y - 4, Color);
            render.SetDoublePixel(X - 5, Y - 5, Color);
            render.SetDoublePixel(X - 5, Y - 6, Color);
            render.SetDoublePixel(X - 4, Y - 7, Color);
            render.SetDoublePixel(X - 2, Y - 8, Color);
            render.SetDoublePixel(X, Y - 9, Color);
            render.SetDoublePixel(X + 2, Y - 9, Color);
            render.SetDoublePixel(X + 4, Y - 9, Color);

            //Здесь возвращаемся и рисуем топчик с фитилем
            render.SetDoublePixel(X, Y - 10, Color);
            render.SetDoublePixel(X + 2, Y - 10, Color);
            render.SetDoublePixel(X + 4, Y - 10, Color);

            //Фитиль усЁ

            //Пламя
            render.SetDoublePixel(X + 2, Y - 11, ConsoleColor.Yellow);
            render.SetPixel(X + 3, Y - 11, ConsoleColor.Red);
            render.SetPixel(X, Y - 11, ConsoleColor.Red);
            render.SetDoublePixel(X + 3, Y - 12, ConsoleColor.Yellow);
            render.SetPixel(X + 4, Y - 12, ConsoleColor.Red);
            render.SetDoublePixel(X + 1, Y - 12, ConsoleColor.Yellow);
            render.SetPixel(X - 1, Y - 12, ConsoleColor.Red);
            render.SetDoublePixel(X + 2, Y - 13, ConsoleColor.Yellow);
            render.SetPixel(X + 3, Y - 13, ConsoleColor.Red);
            render.SetPixel(X, Y - 13, ConsoleColor.Red);
            render.SetDoublePixel(X + 2, Y - 14, ConsoleColor.Red);


            //Правая сторона бомбы
            render.SetDoublePixel(X + 6, Y - 8, Color);
            render.SetDoublePixel(X + 8, Y - 7, Color);
            render.SetDoublePixel(X + 9, Y - 6, Color);
            render.SetDoublePixel(X + 9, Y - 5, Color);
            render.SetDoublePixel(X + 9, Y - 4, Color);
            render.SetDoublePixel(X + 9, Y - 3, Color);
            render.SetDoublePixel(X + 8, Y - 2, Color);
            render.SetDoublePixel(X + 6, Y - 1, Color);

            //Низ бомбы
            render.SetDoublePixel(X + 4, Y, Color);
            render.SetDoublePixel(X + 2, Y, Color);
        }

        private void Frame7(IRender render)
        {
            //Взрывная волна
            render.SetQuadroPixel(X, Y, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y, ConsoleColor.Red);
            render.SetQuadroPixel(X - 4, Y, ConsoleColor.Red);
            render.SetQuadroPixel(X - 6, Y, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y, ConsoleColor.Red);
            render.SetQuadroPixel(X + 4, Y, ConsoleColor.Red);
            render.SetQuadroPixel(X + 6, Y, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X - 4, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X - 6, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X - 8, Y - 2, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X + 4, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X + 6, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X + 8, Y - 2, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X - 4, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X - 6, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X - 8, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X - 10, Y - 4, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X + 4, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X + 6, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X + 8, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X + 10, Y - 4, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X - 4, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X - 6, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X - 8, Y - 6, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X + 4, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X + 6, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X + 8, Y - 6, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 8, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y - 8, ConsoleColor.Red);
            render.SetQuadroPixel(X - 4, Y - 8, ConsoleColor.Red);
            render.SetQuadroPixel(X - 6, Y - 8, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y - 8, ConsoleColor.Red);
            render.SetQuadroPixel(X + 4, Y - 8, ConsoleColor.Red);
            render.SetQuadroPixel(X + 6, Y - 8, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 10, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y - 10, ConsoleColor.Red);
            render.SetQuadroPixel(X - 4, Y - 10, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y - 10, ConsoleColor.Red);
            render.SetQuadroPixel(X + 4, Y - 10, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 12, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y - 12, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y - 12, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 14, ConsoleColor.Yellow);
        }

        private void Frame8(IRender render)
        {
            //Взрывная волна, второй кадр
            render.SetQuadroPixel(X, Y, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y, ConsoleColor.Red);
            render.SetQuadroPixel(X - 4, Y, ConsoleColor.Red);
            render.SetQuadroPixel(X - 6, Y, ConsoleColor.Red);
            render.SetQuadroPixel(X - 8, Y, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y, ConsoleColor.Red);
            render.SetQuadroPixel(X + 4, Y, ConsoleColor.Red);
            render.SetQuadroPixel(X + 6, Y, ConsoleColor.Red);
            render.SetQuadroPixel(X + 8, Y, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X - 4, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X - 6, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X - 8, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X - 10, Y - 2, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X + 4, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X + 6, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X + 8, Y - 2, ConsoleColor.Red);
            render.SetQuadroPixel(X + 10, Y - 2, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X - 4, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X - 6, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X - 8, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X - 10, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X - 12, Y - 4, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X + 4, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X + 6, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X + 8, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X + 10, Y - 4, ConsoleColor.Red);
            render.SetQuadroPixel(X + 12, Y - 4, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X - 4, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X - 6, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X - 8, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X - 10, Y - 6, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X + 4, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X + 6, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X + 8, Y - 6, ConsoleColor.Red);
            render.SetQuadroPixel(X + 10, Y - 6, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 8, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y - 8, ConsoleColor.Red);
            render.SetQuadroPixel(X - 4, Y - 8, ConsoleColor.Red);
            render.SetQuadroPixel(X - 6, Y - 8, ConsoleColor.Red);
            render.SetQuadroPixel(X - 8, Y - 8, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y - 8, ConsoleColor.Red);
            render.SetQuadroPixel(X + 4, Y - 8, ConsoleColor.Red);
            render.SetQuadroPixel(X + 6, Y - 8, ConsoleColor.Red);
            render.SetQuadroPixel(X + 8, Y - 8, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 10, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y - 10, ConsoleColor.Red);
            render.SetQuadroPixel(X - 4, Y - 10, ConsoleColor.Red);
            render.SetQuadroPixel(X - 6, Y - 10, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y - 10, ConsoleColor.Red);
            render.SetQuadroPixel(X + 4, Y - 10, ConsoleColor.Red);
            render.SetQuadroPixel(X + 6, Y - 10, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 12, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y - 12, ConsoleColor.Red);
            render.SetQuadroPixel(X - 4, Y - 12, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y - 12, ConsoleColor.Red);
            render.SetQuadroPixel(X + 4, Y - 12, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 14, ConsoleColor.Red);
            render.SetQuadroPixel(X - 2, Y - 14, ConsoleColor.Yellow);
            render.SetQuadroPixel(X + 2, Y - 14, ConsoleColor.Yellow);
            render.SetQuadroPixel(X, Y - 16, ConsoleColor.Yellow);

        }

        private void Frame9(IRender render)
        {
            //Левая сторона бомбы
            render.SetDoublePixel(X, Y, Color);
            render.SetDoublePixel(X - 2, Y - 1, Color);
            render.SetDoublePixel(X - 4, Y - 2, Color);
            render.SetDoublePixel(X - 5, Y - 3, Color);
            render.SetDoublePixel(X - 5, Y - 4, Color);
            render.SetDoublePixel(X - 5, Y - 5, Color);
            render.SetDoublePixel(X - 5, Y - 6, Color);
            render.SetDoublePixel(X - 4, Y - 7, Color);
            render.SetDoublePixel(X - 2, Y - 8, Color);
            render.SetDoublePixel(X, Y - 9, Color);
            render.SetDoublePixel(X + 2, Y - 9, Color);
            render.SetDoublePixel(X + 4, Y - 9, Color);

            //Здесь возвращаемся и рисуем топчик с фитилем
            render.SetDoublePixel(X, Y - 10, Color);
            render.SetDoublePixel(X + 2, Y - 10, Color);
            render.SetDoublePixel(X + 4, Y - 10, Color);

            ///Фитиль усЁ
            ///Пламя усЁ
            ///Бомба деактивирована

            //Правая сторона бомбы
            render.SetDoublePixel(X + 6, Y - 8, Color);
            render.SetDoublePixel(X + 8, Y - 7, Color);
            render.SetDoublePixel(X + 9, Y - 6, Color);
            render.SetDoublePixel(X + 9, Y - 5, Color);
            render.SetDoublePixel(X + 9, Y - 4, Color);
            render.SetDoublePixel(X + 9, Y - 3, Color);
            render.SetDoublePixel(X + 8, Y - 2, Color);
            render.SetDoublePixel(X + 6, Y - 1, Color);

            //Низ бомбы
            render.SetDoublePixel(X + 4, Y, Color);
            render.SetDoublePixel(X + 2, Y, Color);
        }
        /// <summary>
        /// Метод BlowThisBomb на определенном этапе выводит сообщение, с предложением взорвать бомбу.
        /// Если нажать "Y", то бомба взорвется, любая другая кнопка приведет к выводу сообщения,
        /// что бомба деактивирована
        /// </summary>
        /// <param name="render">Экземпляр типа Irender</param>
        private void BlowThisBomb(IRender render)
        {
            Console.Write("Взорвать эту бомбу? (Y/N) \n");

            ///button - объект типа ConsoleKeyInfo
            ConsoleKeyInfo button = Console.ReadKey();

            ///Проверка нажатой клавиши
            switch (button.Key)
            {
                //Если была нажата клавиша "Y"
                case ConsoleKey.Y:
                    ///Выводится сообщение красным шрифтом "Бомба взорвана"
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nБомба взорвана");
                    ///Цвет шрифта возвращается на прежний
                    Console.ResetColor();
                    
                    //Выполняется метод Frame6, т.е отрисовка бомбы с сгоревшим до основания фитилем
                    this.Frame6(render);

                    //Пауза в 500 миллисекунд, для замедления отображения
                    Thread.Sleep(500);

                    //Очистка консоли
                    Console.Clear();

                    //Выполенение метода Frame7, отображение взрыва, первый этап
                    this.Frame7(render);

                    //Опять пауза в 500 милиисекунд
                    Thread.Sleep(500);
                    
                    //Очиска консоли
                    Console.Clear();
                    
                    //Выполнение метода Frame8, отображение второго кадра взрыва
                    this.Frame8(render);

                    ///Создание нескольких экземпляров класса Smashes. Визуально,
                    ///они представляют собой импровизируемые осколки от взрыва. Задаются
                    ///их начальные координаты, цвет, и направление.
                    Smashes sm1 = new Smashes(40, 15, ConsoleColor.Yellow, "left");
                    Smashes sm2 = new Smashes(40, 15, ConsoleColor.Blue, "down");
                    Smashes sm3 = new Smashes(40, 15, ConsoleColor.DarkGreen, "right");
                    Smashes sm4 = new Smashes(40, 15, ConsoleColor.DarkGray, "up");
                    Smashes sm5 = new Smashes(40, 15, ConsoleColor.Red, "left-down");
                    Smashes sm6 = new Smashes(40, 15, ConsoleColor.Cyan, "left-up");
                    Smashes sm7 = new Smashes(40, 15, ConsoleColor.Gray, "right-up");
                    Smashes sm8 = new Smashes(40, 15, ConsoleColor.DarkMagenta, "right-down");

                    ///Здесь класс Task, используется для синхронного запуска методов. Служит для 
                    ///одновременного прохода по циклам, и анимации осколков бомбы
                    Task.Factory.StartNew(() => 
                    {
                        Task.Factory.StartNew(() =>
                        {
                            sm1.Draw(render);
                        });

                        Task.Factory.StartNew(() =>
                        {
                            sm2.Draw(render);
                        });

                        Task.Factory.StartNew(() =>
                        {
                            sm3.Draw(render);
                        });

                        Task.Factory.StartNew(() =>
                        {
                            sm4.Draw(render);
                        });

                        Task.Factory.StartNew(() =>
                        {
                            sm5.Draw(render);
                        });

                        Task.Factory.StartNew(() =>
                        {
                            sm6.Draw(render);
                        });

                        Task.Factory.StartNew(() =>
                        {
                            sm7.Draw(render);
                        });

                        Task.Factory.StartNew(() =>
                        {
                            sm8.Draw(render);
                        });

                    });
                    break;
                    ///В случае нажатия любой другой клавиши, выводится сообщение ниже
                default:
                    Console.WriteLine("\nБомба деактивирована");
                    this.Frame9(render);
                    Thread.Sleep(1000);
                    break;
            }
        }

        /// <summary>
        /// Переопределенный метод Draw, унаследованный от абстрактного класса
        /// </summary>
        /// <param name="render">"Экземпляр интерфейса IRender</param>
        public override void Draw(IRender render)
        {
            ///Новый кадр отображается вместе с увеличением значения свойства Frame
            switch (render.Frame)
            {
                case 0:
                    this.Frame1(render);
                    break;
                case 1:
                    this.Frame2(render);
                    break;
                case 2:
                    this.Frame3(render);
                    break;
                case 3:
                    this.Frame4(render);
                    break;
                case 4:
                    this.Frame5(render);
                    break;
                case 5:
                    this.Frame6(render);
                    break;
                ///В случае значения Frame, равного 6, запускается метод BlowThisBomb
                case 6:
                    BlowThisBomb(render);
                    break;
            }

        }
    }
}
