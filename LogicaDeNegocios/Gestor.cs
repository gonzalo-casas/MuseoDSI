﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MuseoDSI.Clases;
using MuseoDSI.LogicaDeNegocios;
using System.Windows.Forms;

namespace MuseoDSI.Clases
{
    class Gestor
    {
        Reserva reserva = new Reserva();
        public string usuarioActual { get; set; }
        Backend _BD = new Backend();
        Escuela escuela = new Escuela();
        Sede sede = new Sede();
        TipoReserva tipoReserva = new TipoReserva();
        IEstrategiaCalculoDuracion estrategia;

        public void tomarSeleccionTipoVisita(string estrategia)
        {
            gestor.crearEstrategia(estrategia);
        }


        public List<Escuela> RecuperarListaEscuelas()
        {
            List<Escuela> ListaDeEscuelas = escuela.BuscarlistaEscuelas();
            return ListaDeEscuelas;
        }
        public List<Sede> RecuperarListaSedes()
        {
            List<Sede> ListaDeSedes = sede.BuscarlistaSedes();
            return ListaDeSedes;
        }

        public List<TipoReserva> RecuperarListaTipoReserva()
        {
            List<TipoReserva> ListaDeTipoReserva = (tipoReserva.BuscarlistaTipoReserva());
            return ListaDeTipoReserva;
        }

        public List<Exposicion> TomarExposionesTempVig(string nombreSede)
        {
           return estrategia.TomarExposicionesTempVig(nombreSede);    //mostrarDatosTemp
        }
       

        //Guardamos lista de exposiciones seleccionadas desde la pantalla 
        public  List<Exposicion> ExposicionesSeleccionadas = new List<Exposicion>();
        public void GuardarListaExposición(List<Exposicion> exposiciones)
        {
            ExposicionesSeleccionadas = exposiciones;
           // ExposicionesSeleccionadas.Add(expo);
        }
        Obras obra = new Obras();

        //Calcula La duracion estimada de la reserva
        public int CalcularDuracionEstimada(int tipoExposicionn) /// 
        {

            if (tipoExposicionn.Equals(1))
            {
               return estrategia.CalcularDuracionEstimadaResv(ExposicionesSeleccionadas, "porExposicion");
            }
            else
            {
                return estrategia.CalcularDuracionEstimadaResv(ExposicionesSeleccionadas, "completa");
            }

        }



       
        
        private int CantAlumnos(string nombreSede)
        {
            int CantidadDeAlumnos = sede.MisReservasParaEstaFecha(nombreSede,DateTime.Today);
            return CantidadDeAlumnos;
        }
        public string CalcularSobrepaso(string numvisitantes,string nombreSede)
        {
            string estado = "";
            int AlumnosReservados = this.CantAlumnos(nombreSede);
            int AlumnosTotales = int.Parse(numvisitantes) + AlumnosReservados;
            List<Sede> LS = new List<Sede>();
            LS = sede.BuscarlistaSedes();
            for(int i = 0; i < LS.Count; i++)
            {
                if (LS[i].nombreSede == nombreSede)
                {
                    if (AlumnosTotales > LS[i].CantidadMaximaVisitantes)
                    {
                        estado = "sobrepasado";
                    }
                }  
            }
            return estado;
        }
       

        public int CalcularGuias(string nombreSede,string visitantes)
        {
           int Guias = sede.GetCantidadMaximaPorGuia(nombreSede,int.Parse(visitantes));
           return Guias;
        }

        
        public List<Empleado> ObtenerEmpleado(DateTime horaSeleccionada)
        {
            Empleado empleado = new Empleado();
            HorarioEmpleado HE = new HorarioEmpleado();
            List<Empleado> ListaEmpleados = empleado.LlenarListaEmpleados();
            List<HorarioEmpleado> HorarioEmpleado = HE.LlenarListaHorarioEmpleados();
            List<Empleado> listaGuias = new List<Empleado>();
            List<Empleado> listaGuiasDisponibles = new List<Empleado>();
            
            for (int i = 0; i <ListaEmpleados.Count; i++)
            {
                if(empleado.VerificarCargo(ListaEmpleados[i].idCargo) == "Guia")
                {
                    listaGuias.Add(ListaEmpleados[i]);
                }

            }
            for(int i = 0; i < listaGuias.Count; i++)
            {
                if(HE.VerificarHorario(HorarioEmpleado,listaGuias[i].idHorario, horaSeleccionada) == "Validado")
                {
                    listaGuiasDisponibles.Add(listaGuias[i]);
                }

            }


            return listaGuiasDisponibles;
                
        }

        public void RegistrarReserva (int nroSede, int idEscuela, DateTime horaInicio, DateTime fechaReserva, int CantidadAlumnos, int idTipoReserva, int idEstado)
        {
            int idReserva = ObtenerCantidadReservas();
            reserva.nuevaReserva(idReserva, nroSede, idEscuela, horaInicio, fechaReserva, CantidadAlumnos, idTipoReserva, idEstado);
        }

       public void crearEstrategia(string estrategiaSeleccionada)
        {
            
            if (estrategiaSeleccionada.Equals("Visita Particular"))
            {
              estrategia = new EstrategiaCalculoDuracionPorExposicion();
            }else
               estrategia = new EstrategiaCalculoDuracionCompleta();

           
        }

        public int ObtenerCantidadReservas()
        {
            Reserva reserva = new Reserva();
            List<Reserva> Reservas = reserva.ListaReservas();
            int num = Reservas.Count + 1;

            return num;
        }

    }
}
