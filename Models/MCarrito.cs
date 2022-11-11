using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ES2_Mella.Models
{
    public class MCarrito
    {
        //Servira para poder hacer el insert a la tabla de la bd
        public void InsertarCarro(string nombre, string precio)
        {
            //Hace una variable que servirá de conector con la bd que fue configurada con el conectionstrings en web.config
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);

            //Abre la conexión con la bd
            conexion.Open();

            //variable que almacena la query que se le hará a la bd
            string query_insert = "INSERT INTO Carro(ProductoNombre, ProductoPrecio) VALUES('" + nombre + "', '"+ precio +"')";

            //Variable que servira para almacenar la query y la conexion para poder ser ejecutada
            SqlCommand cmd = new SqlCommand(query_insert, conexion);
            //Ejecuta la query
            cmd.ExecuteNonQuery();

            //Cierra la BD
            conexion.Close();
        }

        public SqlDataReader MostrarCarro()
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);
            conexion.Open();

            string query_select = "SELECT CarroId AS ID, ProductoNombre AS Nombre, ProductoPrecio AS Precio FROM Carro";

            SqlCommand cmd = new SqlCommand(query_select, conexion);

            //retorna la información que fue solicitada con el select
            return cmd.ExecuteReader();
            conexion.Close();
        }

        //Eliminará un producto del carro
        public void EliminarProductoCarro(int id)
        {
            //Hace una variable que servirá de conector con la bd que fue configurada con el conectionstrings en web.config
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);

            //Abre la conexión con la bd
            conexion.Open();

            //variable que almacena la query que se le hará a la bd
            string query_delete = "DELETE FROM Carro WHERE CarroId='" + id + "'";

            //Variable que servira para almacenar la query y la conexion para poder ser ejecutada
            SqlCommand cmd = new SqlCommand(query_delete, conexion);
            //Ejecuta la query
            cmd.ExecuteNonQuery();

            //Cierra la BD
            conexion.Close();
        }

    }
}