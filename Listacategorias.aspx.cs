using ES2_Mella.Controlador;
using ES2_Mella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ES2_Mella
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //Crea el objeto del controlador que servirá para usar los métodos
            categoriaControlador categoria = new categoriaControlador();
            //Se le entrega al gridview la información que deberá mostrar, desde el método
            dvgcategoria.DataSource = categoria.ContMostrarCategorias();
            //Se le dice al gridview que bindee la información osea que lo enlaze/muestre
            dvgcategoria.DataBind();
        }

        protected void dvgcategoria_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Crea la variable que almacenara el dato de la celda especificada (id)
            int id = int.Parse(dvgcategoria.Rows[e.RowIndex].Cells[2].Text);

            //Crea el objeto categoria del controlador
            categoriaControlador categoria = new categoriaControlador();
            //Usa el método que borrara desde el modelo la categoría
            categoria.ContBorrarCategoria(id);

            //Redirige a una url, en este caso es como si se presionara F5
            Response.Redirect("Listacategorias.aspx");
        }

        protected void dvgcategoria_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //guarda el id que se enviara al otro formulario de edicion
            int id_editar = int.Parse(dvgcategoria.Rows[e.NewEditIndex].Cells[2].Text);
            //redirije hacia el formulario pasando el id a editar
            Response.Redirect("FormularioUpdateCategoria.aspx?id_editar=" + id_editar);
        }

    }
}