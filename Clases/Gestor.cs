using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MuseoDSI.Clases;

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

        public List<Exposicion> BuscarExposiciones(string nombreSede)
        {
            
            List<Exposicion> ListaExpos = sede.BuscarListaExposicion(nombreSede);
            return ListaExpos;
        }

        //Guardamos lista de exposiciones seleccionadas desde la pantalla 
        public  List<Exposicion> ExposicionesSeleccionadas = new List<Exposicion>();
        public void GuardarListaExposición(Exposicion expo)
        {
            ExposicionesSeleccionadas.Add(expo);
        }
        Obras obra = new Obras();

        //Calcula La duracion estimada de la reserva
        public int CalcularDuracionEstimada()
        {
            int duracionEstimada = sede.CalcularDuracionEstimada(ExposicionesSeleccionadas);
            return duracionEstimada;
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
                if(empleado.VerificarGuia(ListaEmpleados[i].idCargo) == "Guia")
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

        public void RegistrarReserva (int idReserva, int nroSede, int idEscuela, DateTime horaInicio, DateTime fechaReserva, int CantidadAlumnos, int idTipoReserva, int idEstado)
        {
            
            reserva.nuevaReserva(idReserva, nroSede, idEscuela, horaInicio, fechaReserva, CantidadAlumnos, idTipoReserva, idEstado);
        }
        
        
        
    }
}
