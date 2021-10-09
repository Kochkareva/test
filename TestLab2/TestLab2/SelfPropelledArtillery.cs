﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TestLab2
{
    class SelfPropelledArtillery : Artillery
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия боекомплекта
        /// </summary>
        public bool Ammunition { private set; get; }
        /// <summary>
        /// Признак наличия боевого орудия
        /// </summary>
        public bool Gun { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="ammunition">Признак наличия боекомплекта</param>
        /// <param name="gun">Признак наличия боевого орудия</param>
        public SelfPropelledArtillery(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool ammunition, bool gun) :
        base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            Ammunition = ammunition;
            Gun = gun;
        }
        public override void DrawTransport(Graphics g)
        {
            if (Ammunition)
            {
                SolidBrush ammunit = new SolidBrush(DopColor);
                g.FillRectangle(ammunit, _startPosX + 85, _startPosY + 10, 15, 10);
            }
            if (Gun)
            {
                SolidBrush guns = new SolidBrush(DopColor);
                g.FillRectangle(guns, _startPosX, _startPosY + 5, 30, 5);
            }
            base.DrawTransport(g);
        }
    }
}
