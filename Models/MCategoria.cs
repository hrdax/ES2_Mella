using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ES2_Mella.Models
{
    public class MCategoria
    {
        //Servira para poder hacer el insert a la tabla de la bd
        public void InsertarCategoria(string nombre)
        {
            //Hace una variable que servirá de conector con la bd que fue configurada con el conectionstrings en web.config
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);
            
            //Abre la conexión con la bd
            conexion.Open();
            
            //variable que almacena la query que se le hará a la bd
            string query_insert = "INSERT INTO Categoria(Nombre) VALUES('" + nombre + "')";
            
            //Variable que servira para almacenar la query y la conexion para poder ser ejecutada
            SqlCommand cmd = new SqlCommand(query_insert, conexion);
            //Ejecuta la query
            cmd.ExecuteNonQuery();

            //Cierra la BD
            conexion.Close();
        }
        //Otorga la posibilidad de leer un flujo de filas de la bd osea para poder hacer consultas tipo select
        public SqlDataReader MostrarCategoria()
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);
            conexion.Open();

            string query_select = "SELECT * FROM Categoria ORDER BY Id";

            SqlCommand cmd = new SqlCommand(query_select, conexion);
            
            //retorna la información que fue solicitada con el select
            return cmd.ExecuteReader();
            conexion.Close();
        }

        //Muestra 1 categoria especificado por id
        public SqlDataReader Mostrar1Categoria(int id)
        {

            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);
            conexion.Open();

            string query_select = "SELECT * FROM Categoria WHERE Id = '" + id + "'";

            SqlCommand cmd = new SqlCommand(query_select, conexion);

            //retorna la información que fue solicitada con el select
            return cmd.ExecuteReader();
            conexion.Close();
        }

        //Eliminará la categoría en la tabla
        public void EliminarCategoria(int id)
        {
            //Hace una variable que servirá de conector con la bd que fue configurada con el conectionstrings en web.config
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);

            //Abre la conexión con la bd
            conexion.Open();

            //variable que almacena la query que se le hará a la bd
            string query_delete = "DELETE FROM Categoria WHERE Id='" + id + "'";

            //Variable que servira para almacenar la query y la conexion para poder ser ejecutada
            SqlCommand cmd = new SqlCommand(query_delete, conexion);
            //Ejecuta la query
            cmd.ExecuteNonQuery();

            //Cierra la BD
            conexion.Close();
        }

        //Servira para poder hacer el update a la tabla de la bd
        public void UpdateCategoria(int id, string nombre)
        {
            //Hace una variable que servirá de conector con la bd que fue configurada con el conectionstrings en web.config
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);
            //Abre la conexión con la bd
            conexion.Open();

            //variable que almacena la query que se le hará a la bd
            string query_update = "UPDATE Categoria SET Nombre = '" + nombre + "' WHERE Id = '" + id + "'";

            //Variable que servira para almacenar la query y la conexion para poder ser ejecutada
            SqlCommand cmd = new SqlCommand(query_update, conexion);

            //Ejecuta la query y devuelve las filas afectadas
            cmd.ExecuteNonQuery();
            //Cierra la BD
            conexion.Close();

        }

    }
}