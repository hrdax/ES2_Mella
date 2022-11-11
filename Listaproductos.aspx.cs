using ES2_Mella.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ES2_Mella
{
    public partial class Listaproductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                //Crea el objeto del controlador que servirá para usar los métodos
                productoControlador producto = new productoControlador();
                //Se le entrega al gridview la información que deberá mostrar, desde el método de producto
                Listaproductosver.DataSource = producto.ContMostrarProducto();
                //Se le dice al gridview que bindee la información osea que lo enlaze/muestre
                Listaproductosver.DataBind();

            }
            
        
            
        }

        protected void Listaproductosver_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Crea la variable que almacenara el dato de la celda especificada (id)
            int id = int.Parse(Listaproductosver.Rows[e.RowIndex].Cells[3].Text);

            //Crea el objeto categoria del controlador
            productoControlador producto = new productoControlador();
            //Usa el método que borrara desde el modelo el producto
            producto.ContBorrarProducto(id);

            //Redirige a una url, en este caso es como si se presionara F5
            Response.Redirect("Listaproductos.aspx");

        }

        protected void Listaproductosver_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //guarda el id que se enviara al otro formulario de edicion
            int id_editar = int.Parse(Listaproductosver.Rows[e.NewEditIndex].Cells[3].Text);
            //redirije hacia el formulario pasando el id a editar
            Response.Redirect("FormularioUpdateProducto.aspx?id_editar="+id_editar);
        }

        protected void Listaproductosver_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            //Creación de variables que almacenarán los datos que servirán de registro
            string nombre = Listaproductosver.Rows[e.RowIndex].Cells[4].Text;
            string precio = Listaproductosver.Rows[e.RowIndex].Cells[5].Text;

            //Crea el objeto
            carroControlador carro = new carroControlador();
            //Se llama al método para insertar el producto al carro
            carro.ContInsertarCarro(nombre, precio);

            Response.Redirect("ListaCarrito.aspx");
        }
    }
}