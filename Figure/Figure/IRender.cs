using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    /// <summary>
    /// Интерфейс IRender описывает функционал, передаваемый на реализацию в класс Render.
    /// 
    /// </summary>
    interface IRender
    {
        /// <summary>
        /// Метод Draw служит для отрисовки элементов, запускается на каждом объкте в списке shapes,
        /// описывается в классе Render
        /// </summary>
        /// <param name="shapes">Список объектов</param>
        void Draw(IEnumerable<IShape> shapes);

        /// <summary>
        /// SetPixel служит для установки кординат и отрисовки пикселей
        /// </summary>
        /// <param name="x">Координата по оси x</param>
        /// <param name="y">Координта по оси y</param>
        /// <param name="color">Цвет отображаемого пикселя</param>
        void SetPixel(int x, int y, ConsoleColor color);

        //Служит для отрисовки двух пикселей
        void SetDoublePixel(int x, int y, ConsoleColor color);

        //Отрисовка четырех пикселей
        void SetQuadroPixel(int x, int y, ConsoleColor color);
        
        //Свойство - счетчик
        int Frame { get; }
    }
}
