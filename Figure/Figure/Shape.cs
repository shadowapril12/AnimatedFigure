using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    /// <summary>
    /// Абстрактный класс Shape, служит для базового описания функционала любой фигуры
    /// </summary>
    abstract class Shape : IShape
    {
        //Свойства X и Y, хранят значения координат
        public int X { get; set; }

        public int Y { get; set; }

        ///Абстрактный метод Draw, будет переопределяться в каждом производном классе.
        ///В зависимости от фигуры
        public abstract void Draw(IRender render);

        /// <summary>
        /// Конструктор класса Shape
        /// </summary>
        /// <param name="x">Координата оси x</param>
        /// <param name="y">Координтата оси y</param>
        public Shape(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
