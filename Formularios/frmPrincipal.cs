using MuseoDSI.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MuseoDSI.Formularios
{
    public partial class frmPrincipal : Form
    {
        private string idUsuario = "0";
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin fl;
            fl = new frmLogin();
            fl.ShowDialog();

            if (string.IsNullOrEmpty(fl.MiUsuario.nombre))
                Application.ExitThread();
                
            else
            {
                this.Text += " - Usuario: " + fl.MiUsuario.nombre;
                this.LblNombreUsuario.Text = fl.MiUsuario.nombre;
                idUsuario = fl.MiUsuario.idUsuario;

            }
                

            fl.Dispose();
        }

        //private void habilitarOpciones(bool x)
        //{
        //    btnClientes.Enabled = x;
        //    BtnProveedor.Enabled = x;
        //    btnEmpleados.Enabled = x;
        //    btnProductos.Enabled = x;
        //    btnPlantas.Enabled = x;
        //    btnCatalogos.Enabled = x;
        //}



        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea salir?", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            frmSalir fl;
            fl = new frmSalir();
            fl.ShowDialog();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelForms.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario

            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelForms.Controls.Add(formulario);
                panelForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Frm_RegistrarVisita"] == null)
                btnEmpleados.BackColor = Color.FromArgb(135, 181, 168);

        }

        private void btnRegistrarReserva_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_RegistrarVisita>();
            btnRegistrarReserva.BackColor = Color.FromArgb(205, 241, 231);
        }

    }
}