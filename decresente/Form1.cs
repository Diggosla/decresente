using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decresente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int numer03 = int.Parse(textBox3.Text);
            int[] numero = { numero1, numero2, numer03 };
            Array.Sort(numero);
            Array.Reverse(numero);
            txtresposta.Text= string.Join(",", numero);
       

        }
    }
}
