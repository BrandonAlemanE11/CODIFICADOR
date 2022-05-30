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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Codificador cod = new Codificador();
            this.Hide();
            cod.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Descodificador des = new Descodificador();
            this.Hide();
            des.Show();
        }
    }
}
