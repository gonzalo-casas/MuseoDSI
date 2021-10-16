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

namespace MuseoDSI.Formularios
{
    public partial class Frm_RegistrarVisita : Form
    {
        Gestor gestor = new Gestor();
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
        }



        private void cmb_Sede_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
          
            
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_Sede_SelectedValueChanged(object sender, EventArgs e)
        {

            
            if (cmb_Sede.SelectedItem.ToString() != "")
            {
             
             List<Exposicion> listaExpos = gestor.BuscarExposiciones(cmb_Sede.SelectedItem.ToString());
             CargarGrilla(listaExpos);
             return;

            }
            
        }
        private void CargarGrilla(List<Exposicion> lista)
        {


            dataGridView1.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = lista[i].nombre;
                dataGridView1.Rows[i].Cells[1].Value = lista[i].idPublico;
                dataGridView1.Rows[i].Cells[2].Value = lista[i].horaInicio.ToString("t");
                dataGridView1.Rows[i].Cells[3].Value = lista[i].horaFin.ToString("t");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count >= 1)
            {
                listView1.Items.Add(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Exposicion expoSeleccionada = new Exposicion();
                expoSeleccionada.nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                expoSeleccionada.idPublico = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                expoSeleccionada.horaInicio = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                expoSeleccionada.horaFin = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                gestor.GuardarListaExposición(expoSeleccionada);
            }
            
        }

        private void lbl_fecha_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int duracion = gestor.CalcularDuracionEstimada();
            textBox3.Text = duracion.ToString();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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
                txt_guiasNecesarios.Text = Guias.ToString();
                List<Empleado> listaGuias = gestor.ObtenerEmpleado(DateTime.Parse(maskedTextBox2.Text.ToString()));
                for(int i = 0;i < listaGuias.Count; i++)
                {
                    cmb_Guias.Items.Add(listaGuias[i].nombre);
                }
                
            }

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregarGuia_Click(object sender, EventArgs e)
        {
            CargarGrillaGuia();
        }
        int guiasElegidos = 0;
        private void CargarGrillaGuia()
        {
            
            if (guiasElegidos != int.Parse(txt_guiasNecesarios.Text))
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
                    idSede = sedes[i].nroSede;
                }
            }
            gestor.RegistrarReserva(numReserva, idSede, 1, DateTime.Parse(maskedTextBox2.Text.ToString()), DateTime.Now, int.Parse(txt_visitantes.Text), 1, 1);
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
    }
}
