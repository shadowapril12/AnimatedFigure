using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    /// <summary>
    /// Интерфейс для определения функционала класса Shape.
    /// Свойства X и Y, служат для хранения координат. Метод Draw для отрисовки
    /// </summary>
    interface IShape
    {
        int X { get; set; }

        int Y { get; set; }

        void Draw(IRender render);
    }
}
