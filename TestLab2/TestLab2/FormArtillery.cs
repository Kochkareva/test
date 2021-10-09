﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLab2
{
    public partial class FormArtillery : Form
    {
        private IArtillery artillery;
        public FormArtillery()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод отрисовки самоходной артиллерийской установки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxArtillery.Width, pictureBoxArtillery.Height);
            Graphics gr = Graphics.FromImage(bmp);
            artillery.DrawTransport(gr);
            pictureBoxArtillery.Image = bmp;
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    artillery.MoveTransport(Direction.Up);

                    break;
                case "buttonDown":
                    artillery.MoveTransport(Direction.Down);

                    break;
                case "buttonLeft":
                    artillery.MoveTransport(Direction.Left);

                    break;
                case "buttonRight":
                    artillery.MoveTransport(Direction.Right);

                    break;
            }
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать артилерийскую установку"
        /// </summary>
        /// <param name="sender"></param>
        /// /// <param name="e"></param>
        private void buttonCreateArtillery_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            artillery = new Artillery(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green);
            artillery.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxArtillery.Width,
            pictureBoxArtillery.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать самоходную артилерийскую установку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateUpper_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            artillery = new SelfPropelledArtillery(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green,
            Color.Gray, true, true);
            artillery.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxArtillery.Width,
            pictureBoxArtillery.Height);
            Draw();
        }
    }
}
