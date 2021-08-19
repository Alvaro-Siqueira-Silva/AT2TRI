using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace earsras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2;

            n1 = Convert.ToDouble(txtpeso.Text);
            n2 = Convert.ToDouble(txtalt.Text);
            if (n1 >= 20000 || n2 >= 20)
            {
                MessageBox.Show("Você não pode passar pelas pontes: Cardoso, Ferreira, Naguaré "
                    + "Você não pode passar por baixo das pontes: Cardoso, Ferreira, Naguaré");
            }


            else if (n1 <= 19999 || n2 <= 19 && n2>= 15 || n1 >= 10000)
            {
                MessageBox.Show("Você não pode passar pelas pontes: Cardoso, Ferreira "
                    + "Você não pode passar por baixo das pontes: Cardoso, Ferreira");
            }

            else if (n1 <= 9999 || n2 <= 14 && n2 >= 9 || n1 >= 5000)
            {
                MessageBox.Show("Você não pode passar pelas pontes: Cardoso "
                    + "Você não pode passar por baixo das pontes: Cardoso");
            }

            else if (n1 <= 4999 || n2 <=9 )
            {
                MessageBox.Show("Você pode passar por baixo e por cima de todas as pontes");
            }

        }
    }
}
