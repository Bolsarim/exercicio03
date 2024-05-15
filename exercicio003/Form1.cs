using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeMaria = 19;
            int idadePatricia = 47;
            int idadeAdriano = 50;


            double mediaIdade = (idadeMaria + idadePatricia + idadeAdriano) / 3.0;
            MessageBox.Show($"A média das idades é: {mediaIdade:F2}", "Média de Idades");
        }
    }
}
