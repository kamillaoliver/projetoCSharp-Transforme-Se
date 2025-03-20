using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LojaABC
{
    public partial class frmLogin : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Declarando as variáveis do tipo string
            string usuario, senha;

            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            if (usuario.Equals("kamel") && senha.Equals("12345"))
            {
                frmMenuPrincipal abrir= new frmMenuPrincipal();
                abrir.Show();
                this.Hide();

            }
            else 
            {
             MessageBox.Show("Usuário ou senha inválidos", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error , MessageBoxDefaultButton.Button1);
                txtUsuario.Clear();
                // Chamando o metódo limparCampos
                limparCampos();
            }
                
         
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Limpando janela
    public void limparCampos()
    {
        txtUsuario.Clear();
        txtSenha.Clear();
        txtUsuario.Focus();

    }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus(); 
            }
        }
    }
   

}
       