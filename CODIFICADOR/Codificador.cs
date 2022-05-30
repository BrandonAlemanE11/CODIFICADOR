using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODIFICADOR
{
    public partial class Codificador : Form
    {
        char[] frase = new char[100];
        int[] codigo = new int[50];
        string f = "";
        string h, t, men;
        double total, total2, total3;
        public Codificador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total = 0;
            total2 = 0;
            total3 = 0;
            string fra = textBox1.Text;
            frase = fra.ToCharArray();
            convertir13();
            cifrar();
            men = men + fra;
            label5.Text = men;
            label3.Text = h;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = t;
            label2.Text = f;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void convertir13()
        {
            int i = 0;
            foreach (var fr in frase)
            {
                i = i + 1;
                if(fr == 'A')
                {
                    f = f + "N";
                    codigo[i] = 14;
                    h = h + " " + codigo[i];
                }
                if (fr == 'B')
                {
                    f = f + "O";
                    codigo[i] = 15;
                    h = h + " " + codigo[i];
                }
                if (fr == 'C')
                {
                    f = f + "P";
                    codigo[i] = 16;
                    h = h + " " + codigo[i];
                }
                if (fr == 'D')
                {
                    f = f + "Q";
                    codigo[i] = 17;
                    h = h + " " + codigo[i];
                }
                if (fr == 'E')
                {
                    f = f + "R";
                    codigo[i] = 18;
                    h = h + " " + codigo[i];
                }
                if (fr == 'F')
                {
                    f = f + "S";
                    codigo[i] = 19;
                    h = h + " " + codigo[i];
                }
                if (fr == 'G')
                {
                    f = f + "T";
                    codigo[i] = 20;
                    h = h + " " + codigo[i];
                }
                if (fr == 'H')
                {
                    f = f + "U";
                    codigo[i] = 21;
                    h = h + " " + codigo[i];
                }
                if (fr == 'I')
                {
                    f = f + "V";
                    codigo[i] = 22;
                    h = h + " " + codigo[i];
                }
                if (fr == 'J')
                {
                    f = f + "W";
                    codigo[i] = 23;
                    h = h + " " + codigo[i];
                }
                if (fr == 'K')
                {
                    f = f + "X";
                    codigo[i] = 24;
                    h = h + " " + codigo[i];
                }
                if (fr == 'L')
                {
                    f = f + "Y";
                    codigo[i] = 25;
                    h = h + " " + codigo[i];
                }
                if (fr == 'M')
                {
                    f = f + "Z";
                    codigo[i] = 26;
                    h = h + " " + codigo[i];
                }
                if (fr == 'N')
                {
                    f = f + "A";
                    codigo[i] = 1;
                    h = h + " " + codigo[i];
                }
                if (fr == 'O')
                {
                    f = f + "B";
                    codigo[i] = 2;
                    h = h + " " + codigo[i];
                }
                if (fr == 'P')
                {
                    f = f + "C";
                    codigo[i] = 3;
                    h = h + " " + codigo[i];
                }
                if (fr == 'Q')
                {
                    f = f + "D";
                    codigo[i] = 4;
                    h = h + " " + codigo[i];
                }
                if (fr == 'R')
                {
                    f = f + "E";
                    codigo[i] = 5;
                    h = h + " " + codigo[i];
                }
                if (fr == 'S')
                {
                    f = f + "F";
                    codigo[i] = 6;
                    h = h + " " + codigo[i];
                }
                if (fr == 'T')
                {
                    f = f + "G";
                    codigo[i] = 7;
                    h = h + " " + codigo[i];
                }
                if (fr == 'U')
                {
                    f = f + "H";
                    codigo[i] = 8;
                    h = h + " " + codigo[i];
                }
                if (fr == 'V')
                {
                    f = f + "I";
                    codigo[i] = 9;
                    h = h + " " + codigo[i];
                }
                if (fr == 'W')
                {
                    f = f + "J";
                    codigo[i] = 10;
                    h = h + " " + codigo[i];
                }
                if (fr == 'X')
                {
                    f = f + "K";
                    codigo[i] = 11;
                    h = h + " " + codigo[i];
                }
                if (fr == 'Y')
                {
                    f = f + "L";
                    codigo[i] = 12;
                    h = h + " " + codigo[i];
                }
                if (fr == 'Z')
                {
                    f = f + "M";
                    codigo[i] = 13;
                    h = h + " " + codigo[i];
                }
                if (fr == ' ')
                {
                    f = f + " ";
                    codigo[i] = 0;
                    h = h + " " + codigo[i];
                }
            }
        }

        public void cifrar()
        {
            int num = 0;
            num = num + 1;
            int a = codigo[num];
            double v = Convert.ToDouble(a);
            double suma = v * 1;
            double suma2 = v * 2;
            double suma3 = v * 1;
            total = total + suma;
            total2 = total2 + suma2;
            total3 = total3 + suma3;
            num = num + 1;
            a = codigo[num];
            v = Convert.ToDouble(a);
            suma = v * 0;
            suma2 = v * -1;
            suma3 = v * 3;
            total = total + suma;
            total2 = total2 + suma2;
            total3 = total3 + suma3;
            num = num + 1;
            a = codigo[num];
            v = Convert.ToDouble(a);
            suma = v * 2;
            suma2 = v * 1;
            suma3 = v * 0;
            total = total + suma;
            total2 = total2 + suma2;
            total3 = total3 + suma3;
            t = t + " " + total + " " + total2 + " " + total3;
        }

    }
}
