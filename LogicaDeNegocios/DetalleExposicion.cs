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
        public int idObra { get; set; }
        public int idExposicion { get; set; }

        Backend _BD = new Backend();

        List<DetalleExposicion> listaDE = new List<DetalleExposicion>();

        //Recupero DetalleExposicion de la BD 
        public void LlenarListaDE()
        {

            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM DetalleExposicion";
            tabla = _BD.Consulta(sql);
            DetalleExposicion DE = new DetalleExposicion();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {

                DE.idExposicion = int.Parse(tabla.Rows[i]["idExposicion"].ToString());
                DE.idObra = int.Parse(tabla.Rows[i]["idObra"].ToString());
                listaDE.Add(DE);
            }


        }
        

        public int CalcularDuracionEstimada(List<Exposicion> lista)
        {
            Obras obra1 = new Obras();
            List<Obras> ListaObras = obra1.LlenarListaObras();

            int duracion = 0;
            Exposicion exposicion = new Exposicion();
            List<Exposicion> ListadeExpos = exposicion.BuscarListaDeExposiciones();
            for(int i = 0; i < ListadeExpos.Count; i++)
            {
                for(int j = 0; j < lista.Count; j++)
                {
                    if(lista[j].nombre == ListadeExpos[i].nombre)
                    {
                        for (int k = 0; k < ListaObras.Count; k++)
                        {

                            if (ListadeExpos[i].idExposicion == ListaObras[k].idExposicion)
                            {
                                duracion += ListaObras[k].duracionExtendida;
                            }
                        }
                    }
                }
            }
            return duracion;
        }

    }
}

