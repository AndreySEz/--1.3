using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Triangle
        {
            public double a, b, c;
            public double Alpha, Betta, Gamma;

            public void LinesLength(double x1, double x2, double x3, double y1, double y2, double y3)
            {
                a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            }
            public bool testTriangle()
            {
                if (((a + b > c) && (b + c > a) && (c + a > b)) == false)
                    return false;
                else
                    return true;
            }
            public void AnglesTriangle()
            {
                Alpha = Math.Cos((b * b + c * c - a * a) / (2 * b * c))*180/Math.PI;
                Betta = Math.Cos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
                Gamma = Math.Cos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;
            }
        }



        private void buttonTest_Click(object sender, EventArgs e)
        {
            double x1= Convert.ToDouble(textBoxX1.Text);
            double x2 = Convert.ToDouble(textBoxX2.Text);
            double x3 = Convert.ToDouble(textBoxX3.Text);
            double y1 = Convert.ToDouble(textBoxY1.Text);
            double y2 = Convert.ToDouble(textBoxY2.Text);
            double y3 = Convert.ToDouble(textBoxY3.Text);
            Triangle triangleMain = new Triangle();
            triangleMain.LinesLength(x1, x2, x3, y1, y2, y3);
            triangleMain.AnglesTriangle();
            if (triangleMain.testTriangle()) labelOut.Text = $"Треугольник возможен. Его стороны: {Math.Round(triangleMain.a, 2)}," +
                    $"{Math.Round(triangleMain.b, 2)}, {Math.Round(triangleMain.c, 2)}. \n Его углы: {triangleMain.Alpha}, {triangleMain.Betta}, {triangleMain.Gamma}";
            else labelOut.Text = "Треугольник невозможен";
        }
    }
}
