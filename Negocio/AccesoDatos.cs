using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Negocio
{
    public class AccesoDatos
    {
        public List<Articulo> TraerListado()
        {
            List<Articulo> articulos = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand conexionCommand = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security = true; ";
                conexionCommand.CommandType = System.Data.CommandType.Text;
                conexionCommand.CommandText = "select Id, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS";
                conexionCommand.Connection = conexion;
                conexion.Open();
                lector = conexionCommand.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = lector.GetInt32(0);
                    aux.NombreArticulo = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = lector.GetInt32(3);
                    aux.Categoria = lector.GetInt32(4);
                    aux.Precio = (int)lector.GetSqlMoney(5);
                    articulos.Add(aux);

                }
                conexion.Close();
                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void agregarArticulo()
        {

        }
        public void eliminarArticulo()
        {

        }
    }

}
