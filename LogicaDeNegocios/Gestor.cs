using System;
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
        Sede sedeSeleccionada = new Sede();
        TipoReserva tipoVisita = new TipoReserva();
        IEstrategiaTipoVisita estrategia;
        DateTime horaReservada;
        DateTime fechaReservada;
        int cantVisitantes;
        List<Exposicion> ListaexposicionesSeleccionadas;

        public List<Escuela> RecuperarListaEscuelas()
        {
            List<Escuela> ListaDeEscuelas = escuela.BuscarlistaEscuelas();
            return ListaDeEscuelas;
        }

        public void TomarSeleccionEscuela(Escuela escuelaSeleccionada)
        {
            escuela = escuelaSeleccionada;
        }


        public List<Sede> RecuperarListaSedes()
        {
            List<Sede> ListaDeSedes = sedeSeleccionada.BuscarlistaSedes();
            return ListaDeSedes;
        }

        public void TomarSeleccionSede(Sede sedeSeleccionada1)
        {
            sedeSeleccionada = sedeSeleccionada1;
        }



        public List<Exposicion> tomarSeleccionTipoVisita(TipoReserva tipoVisitaSeleccionada)
        {
            tipoVisita = tipoVisitaSeleccionada;
            this.crearEstrategia(); // creo la estrategia segun la eleccion
            return this.TomarExposiciones(); 

            
        }


       

        public List<TipoReserva> RecuperarListaTipoReserva()
        {
            List<TipoReserva> ListaDeTipoReserva = (tipoVisita.BuscarlistaTipoReserva());
            return ListaDeTipoReserva;
        }

        public List<Exposicion> TomarExposiciones()
        {
           return estrategia.TomarExposiciones(sedeSeleccionada);    
        }
       

     
        public  List<Exposicion> ExposicionesSeleccionadas = new List<Exposicion>();
      
        Obras obra = new Obras();

       
        public int tomarFechaHoraReserva(DateTime horaReservaSeleccionada, DateTime fechaReservaSeleccionada) // este deberia ser el tomarFechaHoraReserva()
        {
            horaReservada = horaReservaSeleccionada;
            fechaReservada  =  fechaReservaSeleccionada;


            return CalcularDuracionEstimadaResv(); // metodo self
        }


        public int CalcularDuracionEstimadaResv() 
        {

            return estrategia.CalcularDuracionEstimadaResv(ListaexposicionesSeleccionadas); // le delega el calculo de la duracion a la estrategia

        }




       
        
        private int CantAlumnos(string nombreSede)
        {
            int CantidadDeAlumnos = sedeSeleccionada.MisReservasParaEstaFecha(nombreSede,DateTime.Today);
            return CantidadDeAlumnos;
        }
        public string CalcularSobrepaso(string numvisitantes)
        {
            string estado = "";
            int AlumnosReservados = this.CantAlumnos(sedeSeleccionada.nombreSede);
            int AlumnosTotales = int.Parse(numvisitantes) + AlumnosReservados;
           
            

            if(AlumnosTotales > sedeSeleccionada.CantidadMaximaVisitantes)
            {
                estado = "sobrepasado";
            }

            //for(int i = 0; i < LS.Count; i++)
            //{
            //    if (LS[i].nombreSede == nombreSede)
            //    {
            //        if (AlumnosTotales > LS[i].CantidadMaximaVisitantes)
            //        {
            //            estado = "sobrepasado";
            //        }
            //    }  
            //}
            return estado;
        }
       

        public int CalcularGuias(string nombreSede,string visitantes)
        {
           int Guias = sedeSeleccionada.GetCantidadMaximaPorGuia(nombreSede,int.Parse(visitantes));
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

        public void RegistrarReserva ()
        {
            int idReserva = ObtenerCantidadReservas();
            reserva.nuevaReserva(idReserva, sedeSeleccionada.nroSede, escuela.idEscuela, horaReservada, fechaReservada, cantVisitantes, tipoVisita.idTipoReserva, 1);
        }

       public void crearEstrategia()
        {
            
            if (tipoVisita.descripcion.Equals("Visita Particular"))
            {
              estrategia = new EstrategiaPorExposicion();
            }else
                estrategia = new EstrategiaCompleta();

        }

        public int ObtenerCantidadReservas()
        {
            Reserva reserva = new Reserva();
            List<Reserva> Reservas = reserva.ListaReservas();
            int num = Reservas.Count + 1;

            return num;
        }

        public void TomarExposicionesSeleccionadas(List<Exposicion> exposicionesSeleccionadas)
        {
            ListaexposicionesSeleccionadas = exposicionesSeleccionadas;
        }

        public void TomarCantVisitantes(int cantVisitantesIngresado)
        {
            cantVisitantes = cantVisitantesIngresado;
        }

    }
}
