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
        double[] codigo = new double[100];
        string f = "";
        public Codificador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fra = textBox1.Text;
            frase = fra.ToCharArray();
            convertir13();
            double a = codigo[1];
            label3.Text = "" + a;
            label2.Text = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
                    f = f + "H";
                    codigo[i] = 8;
                }
            }
        }
    }
}
