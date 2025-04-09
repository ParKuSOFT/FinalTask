using System.Runtime.InteropServices;
using static System.Math;
using static System.Net.Mime.MediaTypeNames;

namespace Laba3CSharp
{
    public partial class Form1 : Form
    {
        const float Pi = 3.14159265358f; //

        float xBase; //
        float yBase; //
        float tBase; //

        float m1; //
        float m2; //    
        float K1; //
        float K2; //
        float Omega01; //
        float Omega02; //

        float V0; //начальная скорость
        float X01; //начальная координата первого маятника
        float X02; //начальная координата второго маятника
        float Fi01; //начальная фаза первого маятника
        float Fi02; //начальная фаза второго маятника

        float X1; //
        float X2; //
        float Fi1; //
        float Fi2; //
        float V1; //
        float V2; //
        float Ax1; //
        float Ax2; //

        float E1;  //
        float Ekin1; //
        float Epot1; //
        float E2; //
        float Ekin2; //
        float Epot2; //

        float t; //
        float Deltat; //
        float A1; //
        float A2; //

        public Form1()
        {
            InitializeComponent();
        }

        private void CommandInit_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            NewParam(); 
            //InitAxis(); 
            //Axis1.StatToDin()
            //Axis1.PixDraw(X01, 0, Blue, 2)
            //Axis1.PixDraw(X02, 0, Red, 2)
            //Axis1.DinToPic()
            //CommandStart.Enabled = True

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewParam();
        }

        private void NewParam()
        {
            t = 0;
            Fi01 = Convert.ToSingle(TextFi01.Text);
            Fi02 = Convert.ToSingle(TextFi02.Text);
            X01 = Convert.ToSingle(TextX01.Text);
            X02 = Convert.ToSingle(TextX02.Text);
            K1 = Convert.ToSingle(TextK1.Text);
            K2 = Convert.ToSingle(TextK2.Text);
            m1 = Convert.ToSingle(TextM1.Text);
            m2 = Convert.ToSingle(TextM2.Text);

            Deltat = Convert.ToSingle(TextDeltat.Text);
            tBase = Convert.ToSingle(TextBaset.Text);

            Omega01 = (float)Pow((K1 / m1), 0.5);
            Omega02 = (float)Pow((K2 / m2), 0.5);
            TextOmega1.Text = Omega01.ToString();
            TextOmega2.Text = Omega02.ToString();
            TextT1.Text = (2 * Pi / Omega01).ToString();
            TextT2.Text = (2 * Pi / Omega02).ToString();

            A1 = (float)(X01 / Cos(Fi01));
            V1 = (float)(-A1 * Omega01 * Sin(Fi01)); //начальная скорость

            A2 = (float)(X02 / Cos(Fi02));
            V2 = (float)(-A2 * Omega02 * Sin(Fi02)); //начальная скорость
            TextV01.Text = (Round(V1, 2)).ToString();
            TextV02.Text = (Round(V2, 2)).ToString();

            X1 = X01;
            X2 = X02;

        }

        private void InitAxis()
        {
            //инициализация
            xBase = 1;
            yBase = 1;

            Graphics gr;
            Color black = Color.Black;
            Pen p = new Pen(black, 2);

            float x = pictureBox1.Width / 2;
            float y = pictureBox1.Height / 2;
            //Axis1.Axis_Type = 1
            //Axis1.Pix_type = 4
            //Axis1.Pix_Size = 0.08 * xBase
            //Axis1.x_Name = "X"
            //Axis1.y_Name = "Y"
            //Axis1.x_Base = xBase
            //Axis1.y_Base = yBase

            //'координата
            //Axis2.Axis_Type = 2
            //Axis2.Pix_type = 1
            //Axis2.Pix_Size = 0
            //Axis2.x_Name = "t"
            //Axis2.y_Name = "X"
            //Axis2.x_Base = tBase
            //Axis2.y_Base = yBase

            //'фаза
            //Axis3.Axis_Type = 2
            //Axis3.Pix_type = 3
            //Axis3.x_Name = "Фаза"
            //Axis3.y_Name = "X,"
            //Axis3.x_Base = 2 * Pi
            //Axis3.y_Base = xBase

            //'энергия
            //Axis4.Axis_Type = 3
            //Axis4.Pix_Size = 0
            //Axis4.Pix_type = 1
            //Axis4.x_Name = "t"
            //Axis4.y_Name = "E1-черн., Е2.-красн"
            //Axis4.x_Base = tBase
            //E1 = (m1 * V1 ^ 2 / 2 + K1 * X01 ^ 2 / 2)
            //E2 = (m2 * V2 ^ 2 / 2 + K2 * X02 ^ 2 / 2)
            //If E1 > E2 Then
            //    Axis4.y_Base = E1 * 1.2
            //Else
            //    Axis4.y_Base = E2 * 1.2
            //End If

            //'энергия полная, кинетическая, поступательная
            //Axis5.Axis_Type = 3
            //Axis5.Pix_type = 1
            //Axis5.Pix_Size = 0
            //Axis5.x_Name = "t"
            //Axis5.y_Name = "E1-черн.,Е1пот.-син., Е1кин.-красн"""
            //Axis5.x_Base = tBase
            //Axis5.y_Base = E1 * 1.2

            //'фазовая траектория
            //Axis6.Axis_Type = 1
            //Axis6.Pix_type = 3
            //Axis6.Pix_Size = 0.01
            //Axis6.x_Name = "X"
            //Axis6.y_Name = "V"
            //Axis6.x_Base = xBase
            //Axis6.y_Base = yBase

            //Axis1.AxisDraw()
            //Axis2.AxisDraw()
            //Axis3.AxisDraw()
            //Axis4.AxisDraw()
            //Axis5.AxisDraw()
            //Axis6.AxisDraw()
        }
    }
}
