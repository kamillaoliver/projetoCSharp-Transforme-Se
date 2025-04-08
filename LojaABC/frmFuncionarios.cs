using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//importando a biblioteca do banco de dados
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using MosaicoSolutions.ViaCep;


namespace LojaABC
{
    public partial class frmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmFuncionarios()
        {
            InitializeComponent();
            //executando desabilitar os campos
            desabilitarCampos();


        }
        public frmFuncionarios(string descricao)
        {
            InitializeComponent();
            //executando desabilitar os campos
            desabilitarCampos();
            txtNome.Text = descricao;
            habilitarCampos_pesquisar();


        }
        //Desabilitando os componentes
        public void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mskCPF.Enabled = false;
            dtpDataDeNascimento.Enabled = false;
            mskCelular.Enabled = false;
            gpbSexo.Enabled = false;

            txtLogradouro.Enabled = false;
            mskCEP.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            txtBairro.Enabled = false;
            cbbUF.Enabled = false;
            txtComplemento.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }
        //Habilitar os campos
             public void habilitarCampos()
             {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskCPF.Enabled = true;
            dtpDataDeNascimento.Enabled = true;
            mskCelular.Enabled = true;
            gpbSexo.Enabled = true;

            txtLogradouro.Enabled = true;
            mskCEP.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            cbbUF.Enabled = true;
            txtComplemento.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;

             }

        //Habilitar os campos pesquisar
        public void habilitarCampos_pesquisar()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskCPF.Enabled = true;
            dtpDataDeNascimento.Enabled = true;
            mskCelular.Enabled = true;
            gpbSexo.Enabled = true;

            txtLogradouro.Enabled = true;
            mskCEP.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            cbbUF.Enabled = true;
            txtComplemento.Enabled = true;

            btnNovo.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;

        }
        public void limparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mskCPF.Clear();
            dtpDataDeNascimento.Text ="";
            mskCelular.Clear();
            
            rdbFeminino.Checked = false;
            rdbMasculino.Checked = false;
            rdbNaoDesejoInformar.Checked = false;

            txtLogradouro.Clear();
            mskCEP.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            cbbUF.Text = ""; 
            txtComplemento.Clear();

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;

            txtNome.Focus();

        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void frmFuncionarios_Load_1(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //executanado habilitar campos
            habilitarCampos();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionarios abrir =new frmPesquisarFuncionarios();
            abrir.ShowDialog();   
            this.Hide();
        }
        public void cadastrarfuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "";
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || mskCPF.Text.Equals("   .   .   -") || mskCelular.Text.Equals("      -") 
                || txtLogradouro.Text.Equals("") ||txtNumero.Text.Equals("") || txtCidade.Text.Equals("") || txtBairro.Text.Equals("") ||
                mskCEP.Text.Equals("     -") || cbbUF.Text.Equals(""))

            {
                MessageBox.Show("Favor, preencher os campos!!!");
            }
            else
            {
                if (cadastrarFuncionarios() == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso!!!");
                    limparCampos();
                    desabilitarCampos();
                    btnNovo.Enabled = true;
                    btnNovo.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar");
                }
                
            }

        }
        public int cadastrarFuncionarios() 
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbFuncionarios(nome,email,cpf,dataNasc,telCel,sexo,logradouro,cep,numero,complemento,bairro,cidade,uf)values(@nome,@email,@cpf,@dataNasc,@telCel,@sexo,@logradouro,@cep,@numero,@complemento,@bairro,@cidade,@uf);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar,100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar,100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar,14).Value = mskCPF.Text;
            comm.Parameters.Add("@dataNasc", MySqlDbType.DateTime).Value = dtpDataDeNascimento.Value;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar,10).Value = mskCelular.Text;

            if (rdbFeminino.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "F";
            }
            if (rdbMasculino.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "M";
            }
            if (rdbNaoDesejoInformar.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "N";
            }
            
            comm.Parameters.Add("@logradouro",MySqlDbType.VarChar,100).Value = txtLogradouro.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar,9).Value = mskCEP.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar,10).Value = txtNumero.Text;
            comm.Parameters.Add("@complemento",MySqlDbType.VarChar,100).Value = txtComplemento;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar,100).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade",MySqlDbType.VarChar,100).Value = txtCidade.Text;
            comm.Parameters.Add("@uf", MySqlDbType.VarChar,2).Value = cbbUF.Text;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;




        }
        public void buscaCEP(string cep)
        {
            var viaCepService = ViaCepService.Default();
            try
            {
                var endereco = viaCepService.ObterEndereco(mskCEP.Text);

                txtLogradouro.Text = endereco.Logradouro;
                txtComplemento.Text = endereco.Complemento;
                txtCidade.Text = endereco.Localidade;
                txtBairro.Text = endereco.Bairro;
                cbbUF.Text = endereco.UF;
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir um CEP válido");
                mskCEP.Focus();
                mskCEP.Clear();
            }
            
        }

        private void mskCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscaCEP(mskCEP.Text);
                txtCidade.Focus();
            }

        }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
