using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }
        public void limparCampos()
        {
            txtNome.Clear();
            ckbLivros.Checked = false;
            ckbComputador.Checked = false;
            ckbMesa.Checked = false;
            ckbBanana.Checked = false;
            ckbBanana.Focus();

        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores válidos");
            }
            else
            {
                if (e.KeyCode == Keys.Enter)

                {
                    cbbListarNomes.Items.Add(txtNome.Text);
                    txtNome.Clear();
                    txtNome.Focus();
                }
            }
        }

        private void ckbLivros_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLivros.Checked)
            {
                ltbListarProdutos.Items.Add("Livros");
                pcbImagens.Load(@".\imagens\Livros.png");
            }
            else
            {
                ltbListarProdutos.Items.RemoveAt(0);
                pcbImagens.Image = null;
            }
        }

        private void ckbComputador_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbComputador.Checked)
            {
                ltbListarProdutos.Items.Add("Computador");
                pcbImagens.Load(@".\imagens\Computador.png");
            }
            else
            {
                ltbListarProdutos.Items.RemoveAt(0);
                pcbImagens.Image = null;
            }
        }

        private void ckbMesa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMesa.Checked)
            {
                ltbListarProdutos.Items.Add("Mesa");
                pcbImagens.Load(@".\imagens\Mesa.png");
            }
            else
            {
                ltbListarProdutos.Items.RemoveAt(0);
                pcbImagens.Image = null;
            }
        }

        private void ckbBanana_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbBanana.Checked)
            {
                ltbListarProdutos.Items.Add("Banana");
                pcbImagens.Load(@".\imagens\Banana.png");
            }
            else
            {
                ltbListarProdutos.Items.RemoveAt(0);
                pcbImagens.Image = null;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "selecione a imagem";
            ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp|Todos os arquivos|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            pcbImagens.ImageLocation = ofd.FileName;
            pcbImagens.Load();



        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            pcbImagens.Image = null;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
