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
    public partial class Descodificador : Form
    {
        public static string[] fraseC = new string[3];
        public static int[] frase = new int[3];
        string nueva, antes, pro, ori;
        int resu;
        double suma, suma2, suma3, aa, bb, cc, resultado;

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = nueva;
            label3.Text = ori;
        }

        string a, b, c;

        public Descodificador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fra = textBox1.Text;
            fraseC = fra.Split(' ');
            a = fraseC[0];
            pro = pro + " " + a;
            aa = Convert.ToDouble(a);
            b = fraseC[1];
            pro = pro + " " + b;
            bb = Convert.ToDouble(b);
            c = fraseC[2];
            pro = pro + " " + c;
            cc = Convert.ToDouble(c);
            l1();
            l2();
            l3();
            Letra();
            label2.Text = antes;
            label4.Text = pro;
            textBox1.Text = "";
        }
        private void l1()
        {
            suma = -0.27272727 * aa;
            suma2 = 0.545454545 * bb;
            suma3 = 0.181818181 * cc;
            resultado = suma + suma2 + suma3;
            resu = Convert.ToInt32(resultado);
            antes = antes + " " + resu;
            frase[0] = resu;
        }

        private void l2()
        {
            suma = 0.090909090 * aa;
            suma2 = -0.18181818 * bb;
            suma3 = 0.272727272 * cc;
            resultado = suma + suma2 + suma3;
            resu = Convert.ToInt32(resultado);
            antes = antes + " " + resu;
            frase[1] = resu;
        }
        private void l3()
        {
            suma = 0.636363636 * aa;
            suma2 = -0.27272727 * bb;
            suma3 = -0.09090909 * cc;
            resultado = suma + suma2 + suma3;
            resu = Convert.ToInt32(resultado);
            antes = antes + " " + resu;
            frase[2] = resu;
        }
        public void Letra()
        {
            foreach (int letra in frase)
            {
                if (letra == 0)
                {
                    nueva = nueva + "" + " ";
                    ori = ori + " ";
                }
                if (letra == 14)
                {
                    nueva = nueva + "" + "A";
                    ori = ori + "N";
                }
                if (letra == 15)
                {
                    nueva = nueva + "" + "B";
                    ori = ori + "O";
                }
                if (letra == 16)
                {
                    nueva = nueva + "" + "C";
                    ori = ori + "P";
                }
                if (letra == 17)
                {
                    nueva = nueva + "" + "D";
                    ori = ori + "Q";
                }
                if (letra == 18)
                {
                    nueva = nueva + "" + "E";
                    ori = ori + "R";
                }
                if (letra == 19)
                {
                    nueva = nueva + "" + "F";
                    ori = ori + "S";
                }
                if (letra == 20)
                {
                    nueva = nueva + "" + "G";
                    ori = ori + "T";
                }
                if (letra == 21)
                {
                    nueva = nueva + "" + "H";
                    ori = ori + "U";
                }
                if (letra == 22)
                {
                    nueva = nueva + "" + "I";
                    ori = ori + "V";
                }
                if (letra == 23)
                {
                    nueva = nueva + "" + "J";
                    ori = ori + "W";
                }
                if (letra == 24)
                {
                    nueva = nueva + "" + "K";
                    ori = ori + "X";
                }
                if (letra == 25)
                {
                    nueva = nueva + "" + "L";
                    ori = ori + "Y";
                }
                if (letra == 26)
                {
                    nueva = nueva + "" + "M";
                    ori = ori + "Z";
                }
                if (letra == 1)
                {
                    nueva = nueva + "" + "N";
                    ori = ori + "A";
                }
                if (letra == 2)
                {
                    nueva = nueva + "" + "O";
                    ori = ori + "B";
                }
                if (letra == 3)
                {
                    nueva = nueva + "" + "P";
                    ori = ori + "C";
                }
                if (letra == 4)
                {
                    nueva = nueva + "" + "Q";
                    ori = ori + "D";
                }
                if (letra == 5)
                {
                    nueva = nueva + "" + "R";
                    ori = ori + "E";
                }
                if (letra == 6)
                {
                    nueva = nueva + "" + "S";
                    ori = ori + "F";
                }
                if (letra == 7)
                {
                    nueva = nueva + "" + "T";
                    ori = ori + "G";
                }
                if (letra == 8)
                {
                    nueva = nueva + "" + "U";
                    ori = ori + "H";
                }
                if (letra == 9)
                {
                    nueva = nueva + "" + "V";
                    ori = ori + "I";
                }
                if (letra == 10)
                {
                    nueva = nueva + "" + "W";
                    ori = ori + "J";
                }
                if (letra == 11)
                {
                    nueva = nueva + "" + "X";
                    ori = ori + "K";
                }
                if (letra == 12)
                {
                    nueva = nueva + "" + "Y";
                    ori = ori + "L";
                }
                if (letra == 13)
                {
                    nueva = nueva + "" + "Z";
                    ori = ori + "M";
                }
            }
        }
    }
}
