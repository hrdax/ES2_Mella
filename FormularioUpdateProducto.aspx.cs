using ES2_Mella.Controlador;
using ES2_Mella.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ES2_Mella
{
    public partial class FormularioUpdateProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Ayudara a que pueda modificar bien evitando los valores preestablecidos
            //Comprueba que la pagina es refrescada
            if(!IsPostBack)
            {
                //recibe el id y lo guarda en la variable
                string id_capturado = Request.QueryString["id_editar"];
                //Parsea el id que fue recibido y lo guarda en una variable
                int id = int.Parse(id_capturado);

                //se usara el label para guardar el id que sera utilizado al dar click en el boton editar
                txtID.Text = id_capturado;

                //Crea el objeto del controlador
                productoControlador producto = new productoControlador();
                categoriaControlador categorias = new categoriaControlador();
                //Se crea un sqldatareader para que almacene el producto que fue escogido
                SqlDataReader datos = producto.ContMostrar1Producto(id);

                //Lee los datos
                datos.Read();
                //Le da los valores a los campos del producto a editar
                TxtUpdateNombreProducto.Text = datos.GetString(1);
                TxtUpdatePrecioProducto.Text = datos.GetString(2);
                //Se le entrega al dropdownlist la información que deberá mostrar, desde el método de categoria
                ListaUpdatecategoriasProducto.DataSource = categorias.ContMostrarCategorias();
                //Se le dice al dropdownlist que solo enliste/muestre la columna "Nombre" de la Tabla
                ListaUpdatecategoriasProducto.DataTextField = "Nombre";
                //Se le dice al dropdownlist que bindee la información osea que lo enliste
                ListaUpdatecategoriasProducto.DataBind();
            }    

                

        }

        protected void B_Editar_Click(object sender, EventArgs e)
        {
            //variables que guardaran los datos para editar
            string nombre = TxtUpdateNombreProducto.Text;
            string precio = TxtUpdatePrecioProducto.Text;
            string categoriat = ListaUpdatecategoriasProducto.Text;
            //variable que guarda el id almacenado en el label
            int id_editar = int.Parse(txtID.Text);

            //crea el objeto del controlador
            productoControlador producto = new productoControlador();
            //metodo que editara el producto
            producto.ContUpdateProducto(id_editar, nombre, precio, categoriat);

            //redirecciona a mostrar productos
            Response.Redirect("Listaproductos.aspx");
        }
    }
}