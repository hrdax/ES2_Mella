using ES2_Mella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ES2_Mella
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BRegistrarCategoria(object sender, EventArgs e)
        {
            //Se crea el objeto del controlador
            MCategoria categoria = new MCategoria();
            //variable que almacena el texto ingresado
            string nombre = TNombreCategoria.Text;

            //Uso del método que insertara
            categoria.InsertarCategoria(nombre);

            //Redirige a las categorias
            Response.Redirect("Listacategorias.aspx");

        }
    }
}