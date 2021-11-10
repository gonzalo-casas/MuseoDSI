﻿using System;
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
        private ISede dao;
        public Sede()
        {
            dao = new SedeDao();
        }

        public List<Sede> ListaSede = new List<Sede>();
        
        public List<Sede> BuscarlistaSedes()
        {
            return dao.BuscarlistaSedes();
        }

        public List<Exposicion> ListaExposicion = new List<Exposicion>();
        Exposicion expo = new Exposicion();

    

        public List<Exposicion> BuscarExposiciones(int nroSedee, string tipoExposicion) 
        {
            return dao.BuscarExposiciones(nroSedee, tipoExposicion);
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

        public int BuscarDuracionExposiciones(List<Exposicion> lista, string tipoVisita)
        {
            int duracion = expo.BuscarDuracionExtendidaObras(lista, tipoVisita);
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
