using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MuseoDSI.Clases;

namespace MuseoDSI.Clases
{
    class DetalleExposicion
    {
        public int idDetalle { get; set; }
        public Obras Obra { get; set; }


        public int BuscarDuracionExtendidaObras()
        {
            return this.Obra.GetduracionExtendida();
            
        }

        public int BuscarDuracionResumidaObras()
        {
            return this.Obra.GetduracionResumida();

        }





        //Backend _BD = new Backend();

        //List<DetalleExposicion> listaDE = new List<DetalleExposicion>();

        //Recupero DetalleExposicion de la BD 
        //public void LlenarListaDE()
        //{

        //    DataTable tabla = new DataTable();
        //    string sql = "SELECT * FROM DetalleExposicion";
        //    tabla = _BD.Consulta(sql);
        //    DetalleExposicion DE = new DetalleExposicion();
        //    for (int i = 0; i < tabla.Rows.Count; i++)
        //    {

        //        DE.idExposicion = int.Parse(tabla.Rows[i]["idExposicion"].ToString());
        //        DE.idObra = int.Parse(tabla.Rows[i]["idObra"].ToString());
        //        listaDE.Add(DE);
        //    }
        //}


        //public int BuscarDuracionExtendidaObras(List<Exposicion> lista, string tipoVisita)
        //{

        //    Obras obra1 = new Obras();
        //    List<Obras> ListaObras = obra1.LlenarListaObras(); 

        //    int duracion = 0;
        //    Exposicion exposicion = new Exposicion();
        //    List<Exposicion> ListadeExpos = exposicion.BuscarListaDeExposiciones();
        //    for(int i = 0; i < ListadeExpos.Count; i++)
        //    {
        //        for(int j = 0; j < lista.Count; j++)
        //        {
        //            if(lista[j].nombre == ListadeExpos[i].nombre)
        //            {
        //                for (int k = 0; k < ListaObras.Count; k++)
        //                {

        //                    if (ListadeExpos[i].idExposicion == ListaObras[k].idExposicion)
        //                    {
        //                        if (tipoVisita.Equals("porExposicion"))
        //                        {
        //                            duracion += ListaObras[k].duracionExtendida;  // get duracion extendida()
        //                        }
        //                        else
        //                        {
        //                            duracion += ListaObras[k].duracionResumida;
        //                        }

        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return duracion;
        //}

    }
}

