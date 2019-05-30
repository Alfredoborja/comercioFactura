using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class clientesDB
    {
        public string connectionString = "Server=kasai-sql; Database=KM_CFDI; User Id=sa; password=S0p0rt3+; trusted_connection=false";
        public List<listaDesplegable> ListaPed = new List<listaDesplegable>
        { 
            new listaDesplegable{ClavePed="A1"},
            new listaDesplegable{ClavePed="RT"}
        };
        List<clientes> listado = new List<clientes>();

        public List<clientes> listadoClientes ()
        {        
            using(SqlConnection conn = new SqlConnection(connectionString)){

                try 
                {
                    conn.Open();
                    SqlCommand com = new SqlCommand("sp_GetSCIClientes_ALL", conn);
                    com.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read()) {
                        listado.Add(new clientes
                        {
                            ID = (int)dr["ID"],
                            cliente = dr["Cliente"].ToString(),
                            tax_id = dr["TAXID"].ToString(),
                            calle = dr["Calle"].ToString(),
                            cp = dr["CP"].ToString(),
                            colonia = dr["Colonia"].ToString(),
                            entidad = dr["entidad"].ToString(),
                            pais = dr["Pais"].ToString(),
                            country_code = dr["Country Code"].ToString(),
                            incoterm = dr["Incoterm"].ToString(),
                            tipo_cambio = (decimal)dr["ExcRate"],
                            moneda = dr["curr"].ToString()
                        });
                    }
                    conn.Close();
               
                }

                catch 
                {
 
                }
                return listado;
            }  
        }

        public List<clientesXBusqueda> ClientesXBusqueda(string id)
        {
       

            List<clientesXBusqueda> Busqueda = new List<clientesXBusqueda>();

            Busqueda = (from row in listado
                        where (Convert.ToInt16(id) == row.ID)
                        select new clientesXBusqueda
                        {
                            ID = row.ID,
                            cliente = row.cliente,
                            tax_id = row.tax_id,
                            calle = row.calle,
                            cp = row.cp,
                            colonia = row.colonia,
                            entidad = row.entidad,
                            pais = row.pais,
                            country_code = row.country_code,
                            incoterm = row.incoterm,
                            tipo_cambio = row.tipo_cambio,
                            moneda = row.moneda
                        }
                ).ToList();
                                                    
                
            return Busqueda;
        } //
        

    }
}