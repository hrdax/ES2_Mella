using ES2_Mella.Controlador;
using ES2_Mella.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ES2_Mella
{
    public partial class Formularioproducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Crea el objeto del controlador que servirá para usar los métodos
                categoriaControlador categoria = new categoriaControlador();
                //Se le entrega al dropdownlist la información que deberá mostrar, desde el método de categoria
                ListacategoriasProducto.DataSource = categoria.ContMostrarCategorias();
                //Se le dice al dropdownlist que solo enliste/muestre la columna "Nombre" de la Tabla
                ListacategoriasProducto.DataTextField = "Nombre";
                //Se le dice al dropdownlist que bindee la información osea que lo enliste
                ListacategoriasProducto.DataBind();
            }
            

        }
        protected void BRegistrarProducto(object sender, EventArgs e)
        {
            //Creación de variables que almacenarán los datos que servirán de registro
            string nombre = TxtNombreProducto.Text;
            string precio = TxtPrecioProducto.Text;
            string categoriat = ListacategoriasProducto.Text;

            //Crea el objeto
            productoControlador producto = new productoControlador();
            //Se llama al método para insertar el nuevo producto con las variables almacenadas
            producto.ContInsertarProducto(nombre, precio, categoriat);

            //redirecciona a mostrar productos
            Response.Redirect("Listaproductos.aspx");
        }
    }
}