using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoDSI.Clases;
using System.Data;

namespace MuseoDSI.Clases
{
    class Sede
    {
        public int nroSede { get; set; }
        public string nombreSede { get; set; }
        public string calle { get; set; }
        public int nroCalle { get; set; }
        public int CantidadMaximaVisitantes { get; set; }
        public int CantidadMaximaPorGuia { get; set; }

        Backend _BD = new Backend();
        public List<Sede> ListaSede = new List<Sede>();
        
        public List<Sede> BuscarlistaSedes()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Sede";
            tabla = _BD.Consulta(sql);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Sede sede = new Sede();
                sede.nroSede = int.Parse(tabla.Rows[i]["nroSede"].ToString());
                sede.nombreSede = tabla.Rows[i]["nombreSede"].ToString();
                sede.CantidadMaximaPorGuia = int.Parse(tabla.Rows[i]["CantidadMaximaPorGuia"].ToString());
                sede.CantidadMaximaVisitantes = int.Parse(tabla.Rows[i]["CantidadMaximaVisitantes"].ToString());
                
                ListaSede.Add(sede);
            }

            return ListaSede;
        }

        public List<Exposicion> ListaExposicion = new List<Exposicion>();
        Exposicion expo = new Exposicion();
        public List<Exposicion> BuscarListaExposicion(string nombreSede)
        {
            ListaExposicion.Clear();
            int nroSede = 0;
            for(int i = 0; i < ListaSede.Count; i++)
            {
                if(nombreSede == ListaSede[i].nombreSede)
                {
                    nroSede = ListaSede[i].nroSede;
                }
            }
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Exposicion WHERE nroSede = " + nroSede;
            
            tabla = _BD.Consulta(sql);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Exposicion exposicion = new Exposicion();
                exposicion.idExposicion = int.Parse(tabla.Rows[i]["idExposicion"].ToString());
                exposicion.nroSede = int.Parse(tabla.Rows[i]["nroSede"].ToString());
                exposicion.nombre = tabla.Rows[i]["nombreExposicion"].ToString();
                exposicion.idPublico =tabla.Rows[i]["idPublico"].ToString();
                exposicion.horaInicio = DateTime.Parse(tabla.Rows[i]["horaInicio"].ToString());
                exposicion.horaFin = DateTime.Parse(tabla.Rows[i]["horaCierre"].ToString());
                exposicion.fechaInicio = DateTime.Parse(tabla.Rows[i]["fechaInicio"].ToString());
                exposicion.fechaFin = DateTime.Parse(tabla.Rows[i]["fechaCierre"].ToString());
                ListaExposicion.Add(exposicion);
            }
            ListaExposicion = expo.ComprobarVigencia(ListaExposicion);
            return ListaExposicion;
            
            
        }

        public int MisReservasParaEstaFecha(string nombre, DateTime fecha)
        {
            Reserva reserva = new Reserva();
            List<Sede> listaSedes = this.BuscarlistaSedes();
            List<Reserva> reservasDeEstaSede = new List<Reserva>();
            List<Reserva> reservas = reserva.ListaReservas();
            List<Reserva> reservasParaXFecha = new List<Reserva>();
            for (int i = 0; i < reservas.Count; i++)
            {
                if (listaSedes[i].nombreSede == nombre)
                {
                    for (int j = 0; j < reservas.Count; j++)
                    {
                        if (reservas[j].nroSede == listaSedes[i].nroSede)
                        {
                            reservasDeEstaSede.Add(reservas[j]);
                        }
                    }
                }
            }
            for(int i = 0;i < reservasDeEstaSede.Count; i++)
            {
                if(reservasDeEstaSede[i].fechaReserva == fecha)
                {
                    reservasParaXFecha.Add(reservasDeEstaSede[i]);
                }
            }
            int CantAlumnos = 0;
            for(int i = 0; i < reservasParaXFecha.Count; i++)
            {
                CantAlumnos += reservasParaXFecha[i].cantidadAlumnos;
            }
            return CantAlumnos;
        }

        public int CalcularDuracionEstimada(List<Exposicion> lista)
        {
            int duracion = expo.CalcularDuracionEstimada(lista);
            return duracion;
        }
      
        public int GetCantidadMaximaPorGuia(string nombreSede,int visitantes)
        {
            int MaximoPorGuia = 0;
            List<Sede> ListaSede = this.BuscarlistaSedes();
            for(int i = 0; i < ListaSede.Count; i++)
            {
                if(ListaSede[i].nombreSede == nombreSede)
                {
                    MaximoPorGuia = ListaSede[i].CantidadMaximaPorGuia;
                }
            }

            int guiasNecesarios = Convert.ToInt32(visitantes / MaximoPorGuia);
            
            
            return guiasNecesarios;


        }


    }
}
