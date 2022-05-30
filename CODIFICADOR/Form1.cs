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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int intentos = 0;
        string usuario = "admin@upt.com";
        string pass = "12345";
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usu = textBox1.Text;
            string pas = textBox2.Text;
            if (intentos == 5)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Demasiados intentos";
                button1.Enabled = false;
            }
            else
            {
                if (usu == usuario && pass == pas)
                {
                    inicio des = new inicio();
                    this.Hide();
                    des.Show();

                }
                else
                {
                    label4.Text = "Contraseña u correo incorrecto";
                    intentos = intentos + 1;
                }
            }
        }
    }
}
