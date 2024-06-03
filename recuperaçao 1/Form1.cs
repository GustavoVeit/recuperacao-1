using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recuperaçao_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTela1_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();

            //mostrando o segundo formulario
            form2.Show();
        }

        private void btnTela2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            //mostrando o terceiro formulario
            form3.Show();
        }
    }
}
