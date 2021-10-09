
namespace TestLab2
{
    partial class FormArtillery
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateArtillery = new System.Windows.Forms.Button();
            this.buttonCreateUpper = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.pictureBoxArtillery = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtillery)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateArtillery
            // 
            this.buttonCreateArtillery.Location = new System.Drawing.Point(9, 10);
            this.buttonCreateArtillery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateArtillery.Name = "buttonCreateArtillery";
            this.buttonCreateArtillery.Size = new System.Drawing.Size(107, 50);
            this.buttonCreateArtillery.TabIndex = 1;
            this.buttonCreateArtillery.Text = "Создать артилерийскую установку";
            this.buttonCreateArtillery.UseVisualStyleBackColor = true;
            this.buttonCreateArtillery.Click += new System.EventHandler(this.buttonCreateArtillery_Click);
            // 
            // buttonCreateUpper
            // 
            this.buttonCreateUpper.Location = new System.Drawing.Point(9, 64);
            this.buttonCreateUpper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateUpper.Name = "buttonCreateUpper";
            this.buttonCreateUpper.Size = new System.Drawing.Size(107, 50);
            this.buttonCreateUpper.TabIndex = 2;
            this.buttonCreateUpper.Text = "Создать артилерийскую установку";
            this.buttonCreateUpper.UseVisualStyleBackColor = true;
            this.buttonCreateUpper.Click += new System.EventHandler(this.buttonCreateUpper_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::TestLab2.Properties.Resources.down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(603, 340);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(22, 24);
            this.buttonDown.TabIndex = 6;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::TestLab2.Properties.Resources.right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(630, 340);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(22, 24);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::TestLab2.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(576, 340);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(22, 24);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::TestLab2.Properties.Resources.up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(603, 310);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(22, 24);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxArtillery
            // 
            this.pictureBoxArtillery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxArtillery.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxArtillery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxArtillery.Name = "pictureBoxArtillery";
            this.pictureBoxArtillery.Size = new System.Drawing.Size(662, 368);
            this.pictureBoxArtillery.TabIndex = 0;
            this.pictureBoxArtillery.TabStop = false;
            // 
            // FormArtillery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 368);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateUpper);
            this.Controls.Add(this.buttonCreateArtillery);
            this.Controls.Add(this.pictureBoxArtillery);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormArtillery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtillery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxArtillery;
        private System.Windows.Forms.Button buttonCreateArtillery;
        private System.Windows.Forms.Button buttonCreateUpper;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
    }
}

