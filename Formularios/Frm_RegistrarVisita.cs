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
using MuseoDSI.LogicaDeNegocios;

namespace MuseoDSI.Formularios
{
    public partial class Frm_RegistrarVisita : Form
    {
        Gestor gestor = new Gestor();
        Exposicion expoSeleccionada;
        List<Exposicion> exposicionesSeleccionadas = new List<Exposicion>();
        Empleado guiaSeleccionado;
        List<Empleado> guiasSeleccionados = new List<Empleado>();
        
        public Frm_RegistrarVisita()
        {
            InitializeComponent();
        }

       

        private void MostrarListaEscuelas()
        {
            List<Escuela> ListaDeEscuelas = gestor.RecuperarListaEscuelas();
            cmb_Escuela.DataSource = ListaDeEscuelas;
            cmb_Escuela.DisplayMember = "nombre";
            cmb_Escuela.ValueMember = "idEscuela";
            cmb_Escuela.SelectedIndex = -1;
            cmb_Escuela.Enabled = true;
        }
        private void MostrarListaDeSedes()
        {
            List<Sede> ListaDeSedes = gestor.RecuperarListaSedes();
            cmb_Sede.DataSource = ListaDeSedes;
            cmb_Sede.DisplayMember = "nombreSede";
            cmb_Sede.ValueMember = "nroSede";
            cmb_Sede.SelectedIndex = -1;
            cmb_Sede.Enabled = true;

        }

        private void MostrarListaDeTipoReserva()
        {
            List<TipoReserva> ListaDeTipoReserva = gestor.RecuperarListaTipoReserva();
            cmb_TipoVisita.DataSource = ListaDeTipoReserva;
            cmb_TipoVisita.DisplayMember = "descripcion";
            cmb_TipoVisita.ValueMember = "idTipoReserva";
            cmb_TipoVisita.SelectedIndex = -1;
            cmb_TipoVisita.Enabled = true;
        }

        Obras obra = new Obras();
        private void Frm_RegistrarVisita_Load(object sender, EventArgs e)
        {
            
            obra.LlenarListaObras();
            MostrarListaEscuelas();
            panelGuiasNecesarios.Visible = false;
            panelGuiasSeleccionados.Visible = false;
            dtpFechaReserva.MinDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day + 1);
            //dtpHoraReserva.
        }

        private void CargarGrilla(List<Exposicion> lista)
        {


            dgv_Exposiciones.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                
                dgv_Exposiciones.Rows.Add();
                dgv_Exposiciones.Rows[i].Cells[0].Value = lista[i].nombre;
                dgv_Exposiciones.Rows[i].Cells[1].Value = lista[i].idPublico;
                dgv_Exposiciones.Rows[i].Cells[2].Value = lista[i].horaInicio.ToString("t");
                dgv_Exposiciones.Rows[i].Cells[3].Value = lista[i].horaFin.ToString("t");

            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if(dgv_Exposiciones.Rows.Count >= 1)
            {
                bool flag = true;
                for (int i = 0; i < dgv_ExposicionesSeleccionadas.Rows.Count; i++)
                {
                    if (dgv_Exposiciones.CurrentRow.Cells[0].Value.ToString() == dgv_ExposicionesSeleccionadas.Rows[i].Cells[0].Value.ToString())
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    expoSeleccionada = new Exposicion();
                    expoSeleccionada.nombre = dgv_Exposiciones.CurrentRow.Cells[0].Value.ToString();
                    expoSeleccionada.idPublico = dgv_Exposiciones.CurrentRow.Cells[1].Value.ToString();
                    expoSeleccionada.horaInicio = DateTime.Parse(dgv_Exposiciones.CurrentRow.Cells[2].Value.ToString());
                    expoSeleccionada.horaFin = DateTime.Parse(dgv_Exposiciones.CurrentRow.Cells[3].Value.ToString());
                    exposicionesSeleccionadas.Add(expoSeleccionada);

                    int index = dgv_ExposicionesSeleccionadas.Rows.Add(dgv_Exposiciones.CurrentRow.Clone() as DataGridViewRow);
                    foreach (DataGridViewCell o in dgv_Exposiciones.CurrentRow.Cells)
                    {
                        dgv_ExposicionesSeleccionadas.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                    }

                }
                else
                {
                    MessageBox.Show("Ya agregaste esta exposicion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No existe ninguna exposicion disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_quitar_Click(object sender, EventArgs e) // Para borrar exposicion de la listaview
        {
            if (dgv_ExposicionesSeleccionadas.SelectedRows.Count > 0)
            {
                exposicionesSeleccionadas.Remove(exposicionesSeleccionadas[dgv_ExposicionesSeleccionadas.CurrentRow.Index]);
                dgv_ExposicionesSeleccionadas.Rows.RemoveAt(dgv_ExposicionesSeleccionadas.CurrentRow.Index);
            }
        }

        private void MostrarVisitantes()
        {
            string respuesta = gestor.CalcularSobrepaso(txt_visitantes.Text, cmb_Sede.Text);
            if (respuesta == "sobrepasado")
            {
                MessageBox.Show("Cupo máximo de visitantes superados!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int guiasNecesarios = gestor.CalcularGuias(cmb_Sede.Text, txt_visitantes.Text);
                lbl_GuiasNecesarios.Text = guiasNecesarios.ToString();
                panelGuiasNecesarios.Visible = true;
                List<Empleado> listaGuias = gestor.ObtenerEmpleado(dtpHoraReserva.Value);
                

                if (guiasNecesarios > listaGuias.Count())
                {
                    MessageBox.Show("No hay suficientes guias disponibles para esta fecha y hora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CargarGrillaGuia(listaGuias);
                }
            }
        }
        

        private void tomarSeleccionTipoVisita(object sender, EventArgs e) 
        {
            if (cmb_TipoVisita.Enabled.Equals(true))
            {
                TipoReserva tipoVisitaSeleccionada = (TipoReserva)cmb_TipoVisita.SelectedItem; // obtengo el tipo visita seleccionada
                Sede sedeSeleccionada = (Sede)cmb_Sede.SelectedItem;
                List<Exposicion> listaExpos = gestor.tomarSeleccionTipoVisita(tipoVisitaSeleccionada, sedeSeleccionada);  // paso como parametro la estrategia y la sede
                CargarGrilla(listaExpos);
                switch (cmb_TipoVisita.SelectedIndex)
                {
                    case 1:

                        btn_agregar.Enabled = true;
                        btn_quitar.Enabled = true;
                        dgv_ExposicionesSeleccionadas.Rows.Clear();
                        exposicionesSeleccionadas.Clear();
                        break;

                    case 0:

                        btn_agregar.Enabled = false;
                        btn_quitar.Enabled = false;
                        dgv_ExposicionesSeleccionadas.Rows.Clear();
                        exposicionesSeleccionadas.Clear();
                        foreach (DataGridViewRow r in dgv_Exposiciones.Rows)
                        {
                            int index = dgv_ExposicionesSeleccionadas.Rows.Add(r.Clone() as DataGridViewRow);
                            foreach (DataGridViewCell o in r.Cells)
                            {
                                dgv_ExposicionesSeleccionadas.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                            }

                            expoSeleccionada = new Exposicion();
                            expoSeleccionada.nombre = dgv_Exposiciones.Rows[r.Index].Cells[0].Value.ToString();
                            expoSeleccionada.idPublico = dgv_Exposiciones.Rows[r.Index].Cells[1].Value.ToString();
                            expoSeleccionada.horaInicio = DateTime.Parse(dgv_Exposiciones.Rows[r.Index].Cells[2].Value.ToString());
                            expoSeleccionada.horaFin = DateTime.Parse(dgv_Exposiciones.Rows[r.Index].Cells[3].Value.ToString());
                            exposicionesSeleccionadas.Add(expoSeleccionada);
                        }

                        break;

                    default:
                        break;
                }

            }
        }


        private void MostrarDuracionEstimada()
        {
            lblDuracion.Enabled = true;
            //gestor.GuardarListaExposición(exposicionesSeleccionadas);
            //int tipoExposicion = cmb_TipoVisita.SelectedIndex;
            int duracionMinutos = gestor.calcularDuracion(exposicionesSeleccionadas); // le paso como parametro lista de las exposiciones seleccionadas
            TimeSpan duracion = TimeSpan.FromMinutes(duracionMinutos);
            lblDuracion.Text = duracion.ToString(@"hh\:mm") + " horas";
            panelDuracion.Visible = true;
        }


        private void CargarGrillaGuia(List<Empleado> lista)
        {
            dgv_Guias.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgv_Guias.Rows.Add();
                dgv_Guias.Rows[i].Cells[0].Value = lista[i].dni;
                dgv_Guias.Rows[i].Cells[1].Value = lista[i].nombre;
                dgv_Guias.Rows[i].Cells[2].Value = lista[i].apellido;
            }
        }

        private void cmb_Escuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Escuela.Enabled.Equals(true))
            {
                MostrarListaDeSedes();
            }


        }

        private void cmb_Sede_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Sede.Enabled.Equals(true))
            {
            MostrarListaDeTipoReserva();
            }
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            MostrarDuracionEstimada();
            MostrarVisitantes();
            btn_agregarGuia.Enabled = true;
            btn_QuitarGuia.Enabled = true;
        }

        private void btn_agregarGuia_Click_1(object sender, EventArgs e)
        {
            if (dgv_Guias.Rows.Count >= 1)
            {
                bool flag = true;
                for (int i = 0; i < dgv_GuiasSeleccionados.Rows.Count; i++)
                {
                    if (dgv_Guias.CurrentRow.Cells[0].Value.ToString() == dgv_GuiasSeleccionados.Rows[i].Cells[0].Value.ToString())
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    if (dgv_GuiasSeleccionados.Rows.Count < Int32.Parse(lbl_GuiasNecesarios.Text))
                    {
                    int index = dgv_GuiasSeleccionados.Rows.Add(dgv_Guias.CurrentRow.Clone() as DataGridViewRow);
                    foreach (DataGridViewCell o in dgv_Guias.CurrentRow.Cells)
                    {
                        dgv_GuiasSeleccionados.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                    }
                    guiaSeleccionado = new Empleado();
                    guiaSeleccionado.dni = Int32.Parse(dgv_Guias.CurrentRow.Cells[0].Value.ToString());
                    guiaSeleccionado.nombre = dgv_Guias.CurrentRow.Cells[1].Value.ToString();
                    guiaSeleccionado.apellido = dgv_Guias.CurrentRow.Cells[2].Value.ToString();
                    guiasSeleccionados.Add(guiaSeleccionado);
                    }
                    else
                    {
                        MessageBox.Show("Ya no hacen falta mas guias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ya agregaste a este guia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No existe ningun guia disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_QuitarGuia_Click(object sender, EventArgs e)
        {
            if (dgv_GuiasSeleccionados.SelectedRows.Count > 0)
            {
                guiasSeleccionados.Remove(guiasSeleccionados[dgv_GuiasSeleccionados.CurrentRow.Index]);
                dgv_GuiasSeleccionados.Rows.RemoveAt(dgv_GuiasSeleccionados.CurrentRow.Index);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea cancelar la reserva?\n Se perderan todos los datos", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                this.Close();
        }

        private void dgv_GuiasSeleccionados_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lbl_GuiasSeleccionados.Text = dgv_GuiasSeleccionados.Rows.Count.ToString();
            panelGuiasSeleccionados.Visible = true;
            if (lbl_GuiasSeleccionados.Text == lbl_GuiasNecesarios.Text)
            {
                btn_Registrar.Enabled = true;
            }
            else
            {
                btn_Registrar.Enabled = false;
            }
        }

        private void dgv_GuiasSeleccionados_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lbl_GuiasSeleccionados.Text = dgv_GuiasSeleccionados.Rows.Count.ToString();
            panelGuiasSeleccionados.Visible = true;
            if (lbl_GuiasSeleccionados.Text == lbl_GuiasNecesarios.Text)
            {
                btn_Registrar.Enabled = true;
            }
            else
            {
                btn_Registrar.Enabled = false;
            }
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            gestor.RegistrarReserva(Int32.Parse(cmb_Sede.SelectedValue.ToString()), Int32.Parse(cmb_Escuela.SelectedValue.ToString()), DateTime.Parse(dtpHoraReserva.Text.ToString()), DateTime.Parse(dtpFechaReserva.Text.ToString()), int.Parse(txt_visitantes.Text), Int32.Parse(cmb_TipoVisita.SelectedValue.ToString()), 1);
            MessageBox.Show("Reserva Creada Correctamente", "Reserva creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void dgv_ExposicionesSeleccionadas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgv_ExposicionesSeleccionadas.Rows.Count > 0)
            {
                dtpFechaReserva.Enabled = true;
                dtpHoraReserva.Enabled = true;
            }
        }

        private void dgv_ExposicionesSeleccionadas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgv_ExposicionesSeleccionadas.Rows.Count > 0)
            {
                dtpFechaReserva.Enabled = true;
                dtpHoraReserva.Enabled = true;
            }
        }

        private void dtpFechaReserva_Validating(object sender, CancelEventArgs e)
        {
            btn_Verificar.Enabled = true;
        }

       
    }
}
