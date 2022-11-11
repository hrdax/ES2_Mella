using ES2_Mella.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ES2_Mella
{
    public partial class ListaCarrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Crea el objeto del controlador que servirá para usar los métodos
            carroControlador carro = new carroControlador();
            //Se le entrega al gridview la información que deberá mostrar, desde el método
            dvgcarro.DataSource = carro.ContMostrarCarro();
            //Se le dice al gridview que bindee la información osea que lo enlaze/muestre
            dvgcarro.DataBind();
        }

        protected void dvgcarro_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Crea la variable que almacenara el dato de la celda especificada (id)
            int id = int.Parse(dvgcarro.Rows[e.RowIndex].Cells[1].Text);

            //Crea el objeto categoria del controlador
            carroControlador carro = new carroControlador();
            //Usa el método que borrara desde el modelo el producto del carro
            carro.ContBorrarProductoCarro(id);

            //Redirige a una url, en este caso es como si se presionara F5
            Response.Redirect("Listacarrito.aspx");
        }
    }
}