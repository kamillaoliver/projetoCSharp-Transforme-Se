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
using System.Web;
using MySql.Data.MySqlClient;

namespace LojaABC
{
    public partial class frmPesquisarFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmPesquisarFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        //criando  o método Limpar campos
        public void LimparCampos()
        {

            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            ltbPesquisar.Items.Clear();
            txtDescricao.Clear();
            txtDescricao.Focus();
            txtDescricao.Enabled = false;

        }
        public void LimparCampos_pesquisar()
        {

            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
        
            txtDescricao.Clear();
            txtDescricao.Focus();
            txtDescricao.Enabled = false;

        }

        //criando método para pesquisar por código
        public void pesquisarPorCodigo(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc from tbFuncionarios where codFunc = (codFunc)";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codigo;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            ltbPesquisar.Items.Add(DR.GetString(0));


            Conexao.fecharConexao();
        }


        //Criando o metódo limpar campos
        public void desabilitarCampos()
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Focus();

        }
        //criando o metódo habilitar campos
        public void habilitarCampos()
        {
            txtDescricao.Enabled = true;
            btnlLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
            txtDescricao.Focus();
        }

        private void frmPesquisarFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            ltbPesquisar.Items.Clear();
            txtDescricao.Clear();
            txtDescricao.Focus();
            txtDescricao.Enabled = false;
        }

        public void pesquisarPorNome(string descricao)
        {
            MySqlCommand comm= new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios where nome like '%a%';";
            comm.CommandType =CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value = descricao;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                ltbPesquisar.Items.Add((DR.GetString(0)));
            }

            Conexao.fecharConexao();

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
          //tbPesquisar.Items.Clear();
          //tbPesquisar.Items.Add(txtDescricao.Text);
          //LimparCampos_pesquisar();
          if (rdbCodigo.Checked)           
          {
                pesquisarPorCodigo(Convert.ToInt32(txtDescricao.Text));
          }
          if(rdbNome.Checked )
          {
                pesquisarPorNome(txtDescricao.Text);
          }


        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();

        }
        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }



        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string descricao = ltbPesquisar.SelectedItem.ToString();
            frmFuncionarios abrir = new frmFuncionarios(descricao);
            abrir.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
