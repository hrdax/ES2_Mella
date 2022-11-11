using ES2_Mella.Controlador;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ES2_Mella
{
    public partial class FormularioUpdateCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //captura el id recibido
                string id_ccaptura = Request.QueryString["id_editar"];
                int id = int.Parse(id_ccaptura);
                txtIDC.Text = id_ccaptura;

                //crea el objeto del controlador
                categoriaControlador categoria = new categoriaControlador();
                //crea un sqldatareader para poder leer los datos de la tabla
                SqlDataReader datos = categoria.ContMostrar1Categoria(id);
                //lee los datos
                datos.Read();
                //da el valor al textbox de la categoria seleccionada
                TUpdateNombreCategoria.Text = datos.GetString(1);
            }
        }
        protected void B_Editar_Categoria_Click(object sender, EventArgs e)
        {
            //crea la variable que alamcena el nombre
            string nombre = TUpdateNombreCategoria.Text;
            // guarda el id en la variable que fue almacenada en el label
            int id = int.Parse(txtIDC.Text);
            //crea el objeto del controlador
            categoriaControlador categoria = new categoriaControlador();
            //se llama al metodo de update
            categoria.ContUpdateCategoria(id, nombre);
            
            //Redirige a las categorias
            Response.Redirect("Listacategorias.aspx");


        }

    }
}