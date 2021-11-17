using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoDSI.Clases;
using System.Data;
using MuseoDSI.Datos.EsquemaPersistencia.Interfaz;
using MuseoDSI.Datos.EsquemaPersistencia.Daos;

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
        public List<Exposicion> ListaExposiciones { get; set; }
        //public List<Exposicion> ListaExposiciones
        //{
        //    get
        //    {
        //        List<Exposicion> listaRetorno = new List<Exposicion>();
        //        foreach (Exposicion expo in ListaExposiciones)
        //        {
        //            listaRetorno.Add(expo);
        //        }
        //        return listaRetorno;
        //    }

        //    set => ListaExposiciones = value;
        //}



        private ISede daoSede;
        public Sede()
        {
            daoSede = new SedeDao();
        }

        public List<Sede> ListaSede = new List<Sede>();
        
        public List<Sede> BuscarlistaSedes()
        {
            return daoSede.BuscarlistaSedes();
        }

        public List<Exposicion> ColeccionExposicionesFiltradas = new List<Exposicion>();
        



        public List<Exposicion> BuscarExposiciones()
        {
            ColeccionExposicionesFiltradas.Clear();

            foreach (Exposicion exposicion in this.ListaExposiciones) // mientras haya exposiciones en la sede
            {
                if (exposicion.getExpoVigentes())  // le pide a exposicion que busque si es vigente
                {
                    ColeccionExposicionesFiltradas.Add(exposicion);
                }
                
            }

            return ColeccionExposicionesFiltradas;


        }

        public List<Exposicion> BuscarExposicionesCompleta()
        {
            ColeccionExposicionesFiltradas.Clear();

            foreach (Exposicion exposicion in this.ListaExposiciones) // mientras haya exposiciones en la sede
            {
                if (exposicion.getExpoVigentesCompleta())  // le pide a exposicion si es vigente
                {
                    ColeccionExposicionesFiltradas.Add(exposicion);
                }

            }

            return ColeccionExposicionesFiltradas;


        }




        public int MisReservasParaEstaFecha(string nombre, DateTime fecha)
        {
            Reserva reserva = new Reserva();
            //List<Sede> listaSedes = this.BuscarlistaSedes();
            List<Reserva> reservasDeEstaSede = new List<Reserva>();
            List<Reserva> reservas = reserva.ListaReservas();
            List<Reserva> reservasParaXFecha = new List<Reserva>();
            //for (int i = 0; i < listaSedes.Count; i++)
            //{
            //    if (listaSedes[i].nombreSede == nombre)
            //    {
            //        for (int j = 0; j < reservas.Count; j++)
            //        {
            //            if (reservas[j].nroSede == listaSedes[i].nroSede)
            //            {
            //                reservasDeEstaSede.Add(reservas[j]);
            //            }
            //        }
            //    }
            //}
            int CantAlumnos = 0;
            for (int j = 0; j < reservas.Count; j++)  // mientras haya reservas ...
            {
                if (reservas[j].nroSede == this.nroSede && reservas[j].fechaReserva == fecha)
                {
                    CantAlumnos += reservas[j].cantidadAlumnos;
                }
            }


            //for (int i = 0;i < reservasDeEstaSede.Count; i++)
            //{
            //    if(reservasDeEstaSede[i].fechaReserva == fecha)
            //    {
            //        reservasParaXFecha.Add(reservasDeEstaSede[i]);
            //    }
            //}
            ////int CantAlumnos = 0;
            //for(int i = 0; i < reservasParaXFecha.Count; i++)
            //{
            //    CantAlumnos += reservasParaXFecha[i].cantidadAlumnos;
            //}
            return CantAlumnos;
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

            int guiasNecesarios = Convert.ToInt32(Math.Ceiling((double)visitantes / MaximoPorGuia))  ;
            
            
            return guiasNecesarios;


        }

       public int BuscarDuracionExposiciones(List<Exposicion> ExposicionesSeleccionadas)
        {
            int duracionEstimada = 0;
            foreach (Exposicion expo in ExposicionesSeleccionadas)  // mientras haya exposiciones
            {
                duracionEstimada += expo.BuscarDuracionExtendidaObra();
            }

            return duracionEstimada;

        }



    }
}
