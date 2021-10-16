using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseoDSI.Clases;
using MuseoDSI.Formularios;
using System.Data;

namespace MuseoDSI.Formularios
{
    public partial class Frm_Login : Form
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            
        }
        Usuario usu = new Usuario();
        private void btn_ingresar_Click(object sender, EventArgs e)
        {

         this.Usuario = txt_usuario.Text;
         this.Close();
         
            
        }
    }
}
