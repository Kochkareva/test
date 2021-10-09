using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TestLab2
{
    public abstract class Vehicle : IArtillery
    {
        /// <summary>
        /// Левая координата отрисовки артиллерийской установки 
        /// </summary>
        protected float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки артиллерийской установки 
        /// </summary>
        protected float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        protected int _pictureHeight;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { protected set; get; }
        /// <summary>
        /// Вес артиллерийской установки
        /// </summary>
        public float Weight { protected set; get; }
        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color MainColor { protected set; get; }
        /// <summary>
        /// Установка позиции артиллерийской установки
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}
