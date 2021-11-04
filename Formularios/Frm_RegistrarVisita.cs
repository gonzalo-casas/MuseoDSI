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
        
        public Frm_RegistrarVisita()
        {
            InitializeComponent();
        }

        private void MostrarListaEscuelas()
        {
            List<Escuela> ListaDeEscuelas = gestor.RecuperarListaEscuelas();
            for(int i = 0; i < ListaDeEscuelas.Count; i++)
            {
                cmb_Escuela.Items.Add(ListaDeEscuelas[i].nombre);
            }
         
        }
        private void MostrarListaDeSedes()
        {
            List<Sede> ListaDeSedes = gestor.RecuperarListaSedes();
            for (int i = 0; i < ListaDeSedes.Count; i++)
            {
                cmb_Sede.Items.Add(ListaDeSedes[i].nombreSede);
            }

        }

        private void MostrarListaDeTipoReserva()
        {
            List<TipoReserva> ListaDeTipoReserva = gestor.RecuperarListaTipoReserva();
            for (int i = 0; i < ListaDeTipoReserva.Count; i++)
            {
                cmb_TipoVisita.Items.Add(ListaDeTipoReserva[i].descripcion);
            }

        }

        Obras obra = new Obras();
        private void Frm_RegistrarVisita_Load(object sender, EventArgs e)
        {
            
            obra.LlenarListaObras();
            MostrarListaEscuelas();
            MostrarListaDeSedes();
            MostrarListaDeTipoReserva();
            lblDuracion.Visible = false;
            lbl_GuiasNecesarios.Visible = false;
        }



        private void cmb_Sede_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_Sede_SelectedValueChanged(object sender, EventArgs e)
        {

            
            //if (cmb_Sede.SelectedItem.ToString() != "")
            //{
             
            // List<Exposicion> listaExpos = gestor.BuscarExposiciones(cmb_Sede.SelectedIndex);
            // CargarGrilla(listaExpos);
            // return;

            //}
            
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
                for (int i = 0; i < lv_Exposiciones.Items.Count; i++)
                {
                    if (dgv_Exposiciones.CurrentRow.Cells[0].Value.ToString() == lv_Exposiciones.Items[i].Text)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    expoSeleccionada = new Exposicion();
                    lv_Exposiciones.Items.Add(dgv_Exposiciones.CurrentRow.Cells[0].Value.ToString());
                    expoSeleccionada.nombre = dgv_Exposiciones.CurrentRow.Cells[0].Value.ToString();
                    expoSeleccionada.idPublico = dgv_Exposiciones.CurrentRow.Cells[1].Value.ToString();
                    expoSeleccionada.horaInicio = DateTime.Parse(dgv_Exposiciones.CurrentRow.Cells[2].Value.ToString());
                    expoSeleccionada.horaFin = DateTime.Parse(dgv_Exposiciones.CurrentRow.Cells[3].Value.ToString());
                    exposicionesSeleccionadas.Add(expoSeleccionada);
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
        private void button2_Click(object sender, EventArgs e)
        {
            gestor.GuardarListaExposición(exposicionesSeleccionadas);
            int duracion = 0;
            int tipoExposicion = cmb_TipoVisita.SelectedIndex;
            duracion = gestor.CalcularDuracionEstimada(tipoExposicion);
            lblDuracion.Text += duracion.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmb_Guias.Items.Clear();
            string respuesta = gestor.CalcularSobrepaso(txt_visitantes.Text,cmb_Sede.Text);
            if(respuesta == "sobrepasado")
            {
                MessageBox.Show("Cupo máximo de visitantes superados!","URGENTE");
            }
            else
            {
                int Guias = gestor.CalcularGuias(cmb_Sede.Text,txt_visitantes.Text);
                lbl_GuiasNecesarios.Text = Guias.ToString();
                List<Empleado> listaGuias = gestor.ObtenerEmpleado(DateTime.Parse(dtpFechaReserva.Text.ToString()));

                if (int.Parse(lbl_GuiasNecesarios.Text.ToString()) > listaGuias.Count())
                {
                    MessageBox.Show("No hay la cantidad suficiente de guias disponibles");

                }

                for (int i = 0;i < listaGuias.Count; i++)
                {
                    cmb_Guias.Items.Add(listaGuias[i].nombre);
                }
                
            }

            

        }

        private void btn_agregarGuia_Click(object sender, EventArgs e)
        {
            CargarGrillaGuia();
        }
        int guiasElegidos = 0;
        private void CargarGrillaGuia()
        {
            
            if (guiasElegidos != int.Parse(lbl_GuiasNecesarios.Text))
            {
                
                dataGridView2.Rows.Add();
                guiasElegidos += 1;
                int row = dataGridView2.Rows.Count;
                dataGridView2.Rows[row - 2].Cells[0].Value = cmb_Guias.Text;
            }
            else
            {
                MessageBox.Show("Ya se seleccionaron los guias necesarios", "ATENCION");
            }
            
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numReserva = ObtenerCantidadReservas();
            int idSede = 0;
            List<Sede> sedes = gestor.RecuperarListaSedes();
            for(int i = 0;i < sedes.Count; i++)
            {
                if(sedes[i].nombreSede == cmb_Sede.Text)
                {
                    idSede = sedes[i].nroSede + 1 ;
                }
            }
            gestor.RegistrarReserva(numReserva, idSede, 1, DateTime.Parse(dtpFechaReserva.Text.ToString()), DateTime.Now, int.Parse(txt_visitantes.Text), 1, 1);
            MessageBox.Show("Reserva Creada Correctamente");
            this.Close();
        }
        private int ObtenerCantidadReservas()
        {
            Reserva reserva = new Reserva();
            List<Reserva> Reservas = reserva.ListaReservas();
            int num = 0;
            for(int i = 0; i < Reservas.Count; i++)
            {
                num = i + 1;
            }
            return num;
        }

       

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < exposicionesSeleccionadas.Count; i++) // para que guarde cada exposicion cargada en la listview  
            //{
            //    gestor.GuardarListaExposición(exposicionesSeleccionadas[i]);
            //}
       
           
        }

        private void cmb_TipoVisita_SelectedIndexChanged(object sender, EventArgs e) 
        {
            int estrategia = this.cmb_TipoVisita.SelectedIndex;
            gestor.crearEstrategia(estrategia); // tomarSeleccionarTipoVisita()

            if (cmb_Sede.SelectedItem.ToString() != "")
            {

                List<Exposicion> listaExpos = gestor.BuscarExposiciones(cmb_Sede.SelectedIndex);  // aca obtiene las lista de exposiones
                CargarGrilla(listaExpos);
                return;

            }
        }

        private void btn_quitar_Click(object sender, EventArgs e) // Para borrar exposicion de la listaview
        {
            for (int i = 0; i < lv_Exposiciones.SelectedItems.Count; i++)
            {
                if (exposicionesSeleccionadas[i].nombre.Contains(lv_Exposiciones.SelectedItems[i].Text.ToString()))
                {
                    exposicionesSeleccionadas.Remove(exposicionesSeleccionadas[i]);
                    lv_Exposiciones.Items.Remove(lv_Exposiciones.SelectedItems[i]);
                }

            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpFechaReserva_ValueChanged(object sender, EventArgs e)
        {
            gestor.GuardarListaExposición(exposicionesSeleccionadas);
            int duracion = 0;
            int tipoExposicion = cmb_TipoVisita.SelectedIndex;
            duracion = gestor.CalcularDuracionEstimada(tipoExposicion);
            lblDuracion.Text = duracion.ToString();
        }
    }
}
