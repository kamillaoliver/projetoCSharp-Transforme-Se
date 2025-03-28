using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class frmFluxoCaixa : Form
    {
        public frmFluxoCaixa()
        {
            InitializeComponent();
            DesabilitarCampos();
            CarregaCombo();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        //limpando campos
        public void LimparCampos()
        {
            txtImpostoRenda.Clear();
            txtSalarioBruto.Clear();
            txtSalarioFolha.Clear();
            txtSalarioLiquido.Clear();
            ckbPlanoDeSaude.Checked = false;
            cbbClubeLazer.Text = "";

            txtSalarioBruto.Focus();

        }

        //desabiitando campos
        public void DesabilitarCampos()
        {
            txtSalarioFolha.Enabled = false;
            txtImpostoRenda.Enabled = false;
            txtSalarioLiquido.Enabled = false;

        }
        public void CarregaCombo()
        {
            cbbClubeLazer.Items.Add("Clube A - R$100,00");
            cbbClubeLazer.Items.Add("Clube B - R$50,00");
            cbbClubeLazer.Items.Add("Clube C - R$30,00");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salarioFolha, impostoRenda=0, salarioLiquido = 0;
          
            salarioFolha = Convert.ToDouble(txtSalarioFolha.Text);
           
            if (salarioFolha < 2259.20)
            {
                salarioLiquido = 0;
            }
            else if (salarioFolha >= 2259.21 && salarioFolha <= 2826.65)
            {
                impostoRenda = salarioFolha * 7.5 / 100;
                salarioLiquido = (salarioFolha - (impostoRenda));
               
            }
            else if (salarioFolha >= 2826.66 && salarioFolha <= 3751.05)
            {
                impostoRenda = salarioFolha * 15 / 100;
                salarioFolha = (salarioFolha - (impostoRenda));
            }
            else if (salarioFolha >= 3751.06 && salarioFolha <= 4664.68)
            {
                impostoRenda = salarioFolha * 22.5 / 100;
                salarioLiquido = (salarioFolha - (impostoRenda));
            }
            else if (salarioFolha>= 4664.69)
            {
                impostoRenda = salarioFolha * 27.5 / 100;
                salarioLiquido = (salarioFolha - (impostoRenda));
            }
            if( ckbPlanoDeSaude.Checked)
            {
                salarioLiquido = salarioLiquido - 200;
            }
            if (cbbClubeLazer.SelectedIndex == 0)
            {
                salarioLiquido = salarioLiquido - 100;
            }
            if (cbbClubeLazer.SelectedIndex == 1)
            {
                salarioLiquido = salarioLiquido - 50;
            }
            if (cbbClubeLazer.SelectedIndex == 2)
            {
                salarioLiquido = salarioLiquido - 30;
            }

            txtImpostoRenda.Text = impostoRenda.ToString();
            txtSalarioLiquido.Text = salarioLiquido.ToString();
        }

        private void txtSalarioBruto_TextChanged(object sender, EventArgs e)
        {
            txtSalarioFolha.Text = txtSalarioBruto.Text;
        }

        private void ckbPlanoDeSaude_CheckedChanged(object sender, EventArgs e)
        {
            lblPlanoSaude.Text = "R$ 400,00";

            if (ckbPlanoDeSaude.Checked == false)
            {
                lblPlanoSaude.Text = "";
            }
            
        }
    }
}
