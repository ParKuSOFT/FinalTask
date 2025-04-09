namespace Laba3CSharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CommandInit = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            TextFi01 = new TextBox();
            TextFi02 = new TextBox();
            TextX01 = new TextBox();
            TextX02 = new TextBox();
            TextK1 = new TextBox();
            TextK2 = new TextBox();
            TextM1 = new TextBox();
            TextM2 = new TextBox();
            TextDeltat = new TextBox();
            TextBaset = new TextBox();
            TextOmega1 = new TextBox();
            TextOmega2 = new TextBox();
            TextT1 = new TextBox();
            TextT2 = new TextBox();
            TextV01 = new TextBox();
            TextV02 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CommandInit
            // 
            CommandInit.Location = new Point(586, 226);
            CommandInit.Name = "CommandInit";
            CommandInit.Size = new Size(157, 41);
            CommandInit.TabIndex = 0;
            CommandInit.Text = "button1";
            CommandInit.UseVisualStyleBackColor = true;
            CommandInit.Click += CommandInit_Click;
            // 
            // TextFi01
            // 
            TextFi01.Location = new Point(357, 52);
            TextFi01.Name = "TextFi01";
            TextFi01.Size = new Size(90, 27);
            TextFi01.TabIndex = 1;
            // 
            // TextFi02
            // 
            TextFi02.Location = new Point(469, 55);
            TextFi02.Name = "TextFi02";
            TextFi02.Size = new Size(60, 27);
            TextFi02.TabIndex = 2;
            // 
            // TextX01
            // 
            TextX01.Location = new Point(359, 98);
            TextX01.Name = "TextX01";
            TextX01.Size = new Size(86, 27);
            TextX01.TabIndex = 3;
            // 
            // TextX02
            // 
            TextX02.Location = new Point(469, 98);
            TextX02.Name = "TextX02";
            TextX02.Size = new Size(55, 27);
            TextX02.TabIndex = 4;
            // 
            // TextK1
            // 
            TextK1.Location = new Point(361, 145);
            TextK1.Name = "TextK1";
            TextK1.Size = new Size(84, 27);
            TextK1.TabIndex = 5;
            // 
            // TextK2
            // 
            TextK2.Location = new Point(474, 146);
            TextK2.Name = "TextK2";
            TextK2.Size = new Size(125, 27);
            TextK2.TabIndex = 6;
            // 
            // TextM1
            // 
            TextM1.Location = new Point(354, 205);
            TextM1.Name = "TextM1";
            TextM1.Size = new Size(125, 27);
            TextM1.TabIndex = 7;
            // 
            // TextM2
            // 
            TextM2.Location = new Point(498, 204);
            TextM2.Name = "TextM2";
            TextM2.Size = new Size(125, 27);
            TextM2.TabIndex = 8;
            // 
            // TextDeltat
            // 
            TextDeltat.Location = new Point(38, 40);
            TextDeltat.Name = "TextDeltat";
            TextDeltat.Size = new Size(125, 27);
            TextDeltat.TabIndex = 9;
            // 
            // TextBaset
            // 
            TextBaset.Location = new Point(44, 82);
            TextBaset.Name = "TextBaset";
            TextBaset.Size = new Size(125, 27);
            TextBaset.TabIndex = 10;
            // 
            // TextOmega1
            // 
            TextOmega1.Location = new Point(39, 231);
            TextOmega1.Name = "TextOmega1";
            TextOmega1.Size = new Size(125, 27);
            TextOmega1.TabIndex = 11;
            // 
            // TextOmega2
            // 
            TextOmega2.Location = new Point(40, 277);
            TextOmega2.Name = "TextOmega2";
            TextOmega2.Size = new Size(125, 27);
            TextOmega2.TabIndex = 12;
            // 
            // TextT1
            // 
            TextT1.Location = new Point(42, 324);
            TextT1.Name = "TextT1";
            TextT1.Size = new Size(125, 27);
            TextT1.TabIndex = 13;
            // 
            // TextT2
            // 
            TextT2.Location = new Point(42, 375);
            TextT2.Name = "TextT2";
            TextT2.Size = new Size(125, 27);
            TextT2.TabIndex = 14;
            // 
            // TextV01
            // 
            TextV01.Location = new Point(42, 423);
            TextV01.Name = "TextV01";
            TextV01.Size = new Size(125, 27);
            TextV01.TabIndex = 15;
            // 
            // TextV02
            // 
            TextV02.Location = new Point(43, 468);
            TextV02.Name = "TextV02";
            TextV02.Size = new Size(125, 27);
            TextV02.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(179, 251);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 100);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 562);
            Controls.Add(pictureBox1);
            Controls.Add(TextV02);
            Controls.Add(TextV01);
            Controls.Add(TextT2);
            Controls.Add(TextT1);
            Controls.Add(TextOmega2);
            Controls.Add(TextOmega1);
            Controls.Add(TextBaset);
            Controls.Add(TextDeltat);
            Controls.Add(TextM2);
            Controls.Add(TextM1);
            Controls.Add(TextK2);
            Controls.Add(TextK1);
            Controls.Add(TextX02);
            Controls.Add(TextX01);
            Controls.Add(TextFi02);
            Controls.Add(TextFi01);
            Controls.Add(CommandInit);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CommandInit;
        private System.Windows.Forms.Timer timer1;
        private TextBox TextFi01;
        private TextBox TextFi02;
        private TextBox TextX01;
        private TextBox TextX02;
        private TextBox TextK1;
        private TextBox TextK2;
        private TextBox TextM1;
        private TextBox TextM2;
        private TextBox TextDeltat;
        private TextBox TextBaset;
        private TextBox TextOmega1;
        private TextBox TextOmega2;
        private TextBox TextT1;
        private TextBox TextT2;
        private TextBox TextV01;
        private TextBox TextV02;
        private PictureBox pictureBox1;
    }
}
