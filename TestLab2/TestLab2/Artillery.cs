using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TestLab2
{
    class Artillery : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected readonly int artilleryWidth = 90;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        protected readonly int artilleryHeight = 50;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес артиллерийской установки</param>
        /// <param name="mainColor">Основной цвет корпуса</param>
        public Artillery(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструктор с изменением размеров машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="carWidth">Ширина отрисовки автомобиля</param>
        /// <param name="carHeight">Высота отрисовки автомобиля</param>
        protected Artillery(int maxSpeed, float weight, Color mainColor, int carWidth, int
        carHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.artilleryWidth = carWidth;
            this.artilleryHeight = carHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - artilleryWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - artilleryHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            SolidBrush body = new SolidBrush(MainColor);
            //тело самоходной артиллерийской установки
            g.FillRectangle(body, _startPosX, _startPosY + 20, artilleryWidth, 20);
            g.FillRectangle(body, _startPosX + 30, _startPosY, 40, 20);
            //гусеница
            SolidBrush caterpillar = new SolidBrush(Color.DarkGreen);          //цвет гусеницы танка
            g.FillEllipse(caterpillar, _startPosX, _startPosY + 39, 20, 20);
            g.FillEllipse(caterpillar, _startPosX + 80, _startPosY + 39, 20, 20);
            g.FillRectangle(caterpillar, _startPosX + 10, _startPosY + 39, 80, 20);
            SolidBrush detals = new SolidBrush(Color.Black);  //цвет колес в гусенице
            g.FillEllipse(detals, _startPosX + 5, _startPosY + 40, 16, 16);
            g.FillEllipse(detals, _startPosX + 80, _startPosY + 40, 16, 16);
            g.FillEllipse(detals, _startPosX + 23, _startPosY + 45, 12, 12);
            g.FillEllipse(detals, _startPosX + 38, _startPosY + 45, 12, 12);
            g.FillEllipse(detals, _startPosX + 53, _startPosY + 45, 12, 12);
            g.FillEllipse(detals, _startPosX + 68, _startPosY + 45, 12, 12);

        }
    }
}
