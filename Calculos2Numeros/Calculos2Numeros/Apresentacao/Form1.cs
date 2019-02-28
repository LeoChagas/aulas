using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculos2Numeros.Modelo;

namespace Calculos2Numeros
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.num1 = txbNum1.Text;
            controle.num2 = txbNum2.Text;
            controle.Executar();
            if (controle.mensagem.Equals(""))
            {
                lblResultado.Text = controle.resultado;
            }
            else
            {
                MessageBox.Show(controle.mensagem, "Erro de Conversão");
            }
        }
    }
}
