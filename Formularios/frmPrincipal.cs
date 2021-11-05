using MuseoDSI.Clases;
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
        Gestor gestor = new Gestor();
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
                string cargo = fl.MiUsuario.empleado.VerificarCargo(fl.MiUsuario.empleado.idCargo);
                this.lblRolUsuario.Text = cargo;
                idUsuario = fl.MiUsuario.idUsuario;

                switch (cargo)
                {
                    case "Responsable Visitas":
                        btnRegistrarReserva.Enabled = true;
                        break;
                    case "Responsable Ventas":
                        btnVentas.Enabled = true;
                        btnRanking.Enabled = true;
                        break;
                    case "Administrador Exposiciones":
                        BtnExposiciones.Enabled = true;
                        break;
                    case "Responsable Infraestructura":
                        btnSede.Enabled = true;
                        break;
                    case "Responsable Obras":
                        btnObras.Enabled = true;
                        break;
                    default:
                        // code block
                        break;
                }
            }
                

            fl.Dispose();
        }

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
                btnRegistrarReserva.BackColor = Color.FromArgb(169, 224, 240);

        }

        private void btnRegistrarReserva_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_RegistrarVisita>();
            btnRegistrarReserva.BackColor = Color.FromArgb(202, 243, 255);
        }

    }
}