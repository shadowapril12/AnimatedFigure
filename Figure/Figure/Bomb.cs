using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Figure
{
    class Bomb : Shape
    {
        /// <summary>
        /// Свойство Color служит для хранения цвета отображаемого объекта
        /// </summary>
        public ConsoleColor Color { get; set; }

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

        protected void Wait(int time)
        {
            Thread.Sleep(time);
        }

        /// <summary>
        /// Метод Frame1 представляет первоначальную отрисовку бомбы
        /// </summary>
        /// <param name="render">Экземпляр типа Irender</param>
        private void Frame1(IRender render)
        {
            FrameBasisBomb(render);

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
            
        }

        ///Далее методы пронумерованные с Frame1 по Frame2 представляют отрисовки
        ///объекта на различных ///временных интервалах
        private void Frame2(IRender render)
        {
            FrameBasisBomb(render);

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
        }

        private void Frame3(IRender render)
        {
            FrameBasisBomb(render);

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
        }

        private void Frame4(IRender render)
        {
            FrameBasisBomb(render);

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
        }

        private void Frame5(IRender render)
        {
            FrameBasisBomb(render);

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
        }

        private void Frame6(IRender render)
        {
            FrameBasisBomb(render);

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
        }

        private void Frame7()
        {
            //Взрывная волна
            SetQuadroPixel(X, Y, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y, ConsoleColor.Red);
            SetQuadroPixel(X - 4, Y, ConsoleColor.Red);
            SetQuadroPixel(X - 6, Y, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y, ConsoleColor.Red);
            SetQuadroPixel(X + 4, Y, ConsoleColor.Red);
            SetQuadroPixel(X + 6, Y, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X - 4, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X - 6, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X - 8, Y - 2, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X + 4, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X + 6, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X + 8, Y - 2, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X - 4, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X - 6, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X - 8, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X - 10, Y - 4, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X + 4, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X + 6, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X + 8, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X + 10, Y - 4, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X - 4, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X - 6, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X - 8, Y - 6, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X + 4, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X + 6, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X + 8, Y - 6, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 8, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y - 8, ConsoleColor.Red);
            SetQuadroPixel(X - 4, Y - 8, ConsoleColor.Red);
            SetQuadroPixel(X - 6, Y - 8, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y - 8, ConsoleColor.Red);
            SetQuadroPixel(X + 4, Y - 8, ConsoleColor.Red);
            SetQuadroPixel(X + 6, Y - 8, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 10, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y - 10, ConsoleColor.Red);
            SetQuadroPixel(X - 4, Y - 10, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y - 10, ConsoleColor.Red);
            SetQuadroPixel(X + 4, Y - 10, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 12, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y - 12, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y - 12, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 14, ConsoleColor.Yellow);
        }

        private void Frame8()
        {
            //Взрывная волна, второй кадр
            SetQuadroPixel(X, Y, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y, ConsoleColor.Red);
            SetQuadroPixel(X - 4, Y, ConsoleColor.Red);
            SetQuadroPixel(X - 6, Y, ConsoleColor.Red);
            SetQuadroPixel(X - 8, Y, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y, ConsoleColor.Red);
            SetQuadroPixel(X + 4, Y, ConsoleColor.Red);
            SetQuadroPixel(X + 6, Y, ConsoleColor.Red);
            SetQuadroPixel(X + 8, Y, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X - 4, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X - 6, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X - 8, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X - 10, Y - 2, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X + 4, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X + 6, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X + 8, Y - 2, ConsoleColor.Red);
            SetQuadroPixel(X + 10, Y - 2, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X - 4, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X - 6, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X - 8, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X - 10, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X - 12, Y - 4, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X + 4, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X + 6, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X + 8, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X + 10, Y - 4, ConsoleColor.Red);
            SetQuadroPixel(X + 12, Y - 4, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X - 4, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X - 6, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X - 8, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X - 10, Y - 6, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X + 4, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X + 6, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X + 8, Y - 6, ConsoleColor.Red);
            SetQuadroPixel(X + 10, Y - 6, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 8, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y - 8, ConsoleColor.Red);
            SetQuadroPixel(X - 4, Y - 8, ConsoleColor.Red);
            SetQuadroPixel(X - 6, Y - 8, ConsoleColor.Red);
            SetQuadroPixel(X - 8, Y - 8, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y - 8, ConsoleColor.Red);
            SetQuadroPixel(X + 4, Y - 8, ConsoleColor.Red);
            SetQuadroPixel(X + 6, Y - 8, ConsoleColor.Red);
            SetQuadroPixel(X + 8, Y - 8, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 10, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y - 10, ConsoleColor.Red);
            SetQuadroPixel(X - 4, Y - 10, ConsoleColor.Red);
            SetQuadroPixel(X - 6, Y - 10, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y - 10, ConsoleColor.Red);
            SetQuadroPixel(X + 4, Y - 10, ConsoleColor.Red);
            SetQuadroPixel(X + 6, Y - 10, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 12, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y - 12, ConsoleColor.Red);
            SetQuadroPixel(X - 4, Y - 12, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y - 12, ConsoleColor.Red);
            SetQuadroPixel(X + 4, Y - 12, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 14, ConsoleColor.Red);
            SetQuadroPixel(X - 2, Y - 14, ConsoleColor.Yellow);
            SetQuadroPixel(X + 2, Y - 14, ConsoleColor.Yellow);
            SetQuadroPixel(X, Y - 16, ConsoleColor.Yellow);

        }

        private void Frame9(IRender render)
        {
            FrameBasisBomb(render);

            ///Фитиль усЁ
            ///Пламя усЁ
            ///Бомба деактивирована
        }

        private void FrameBasisBomb(IRender render)
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
                    Wait(500);

                    //Очистка консоли
                    Console.Clear();

                    //Выполенение метода Frame7, отображение взрыва, первый этап
                    this.Frame7();

                    //Опять пауза в 500 милиисекунд
                    Wait(500);
                    
                    //Очиска консоли
                    Console.Clear();
                    
                    //Выполнение метода Frame8, отображение второго кадра взрыва
                    this.Frame8();

                    ///Создание нескольких экземпляров класса Smashes. Визуально,
                    ///они представляют собой импровизируемые осколки от взрыва. Задаются
                    ///их начальные координаты, цвет, и направление.
                    Smashes sm1 = new Smashes(40, 15, ConsoleColor.Yellow, Smashes.Directions.Left);
                    Smashes sm2 = new Smashes(40, 15, ConsoleColor.Blue, Smashes.Directions.Down);
                    Smashes sm3 = new Smashes(40, 15, ConsoleColor.DarkGreen, Smashes.Directions.Right);
                    Smashes sm4 = new Smashes(40, 15, ConsoleColor.DarkGray, Smashes.Directions.Up);
                    Smashes sm5 = new Smashes(40, 15, ConsoleColor.Red, Smashes.Directions.LeftDown);
                    Smashes sm6 = new Smashes(40, 15, ConsoleColor.Cyan, Smashes.Directions.LeftUp);
                    Smashes sm7 = new Smashes(40, 15, ConsoleColor.Gray, Smashes.Directions.RightUp);
                    Smashes sm8 = new Smashes(40, 15, ConsoleColor.DarkMagenta, Smashes.Directions.RightDown);


                    /////Здесь класс Task, используется для асинхронного запуска методов. Служит для 
                    /////одновременного прохода по циклам, и анимации осколков бомбы
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
                    Wait(1000);
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
