using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseoDSI.Formularios;

namespace MuseoDSI
{
    public partial class Frm_Escritorio : Form
    {
        public string usuario { get; set; }
        public Frm_Escritorio()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarReservaDeVisitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RegistrarVisita = new Frm_RegistrarVisita();
            RegistrarVisita.Show();
        }

        private void Frm_Escritorio_Load(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.ShowDialog();
            this.usuario = login.Usuario;
            
          
            
        }
    }
}
