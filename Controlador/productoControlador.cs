using ES2_Mella.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ES2_Mella.Controlador
{
    public class productoControlador
    {
        //Sevira para poder hacer el insert a la tabla y se piden valores
        public void ContInsertarProducto(string nombre, string precio, string categoria)
        { 
            //se crea un objeto del modelo
            MProducto producto = new MProducto();
            //se usa el metodo para insertar y se entrega los valores
            producto.InsertarProducto(nombre, precio, categoria);
        }
        //Servira para poder leer información de la tabla Producto
        public SqlDataReader ContMostrarProducto()
        {
            //Crea el objeto del modelo
            MProducto producto = new MProducto();
            //Retorna el resultado del select del metodo mostrarproducto
            return producto.MostrarProducto();
        }

        //Servira para poder pedir información de 1 producto
        public SqlDataReader ContMostrar1Producto(int id)
        {
            //Crea el objeto del modelo
            MProducto producto = new MProducto();
            //Retorna el resultado del select del metodo mostrarproducto
            return producto.Mostrar1Producto(id);
        }

        //Servirá para borrar el producto
        public void ContBorrarProducto(int id)
        {
            //se crea un objeto del modelo
            MProducto producto = new MProducto();
            //se usa el metodo para insertar y se entrega los valores
            producto.EliminarProducto(id);
        }

        //Sevira para poder hacer el update a la tabla y se piden valores
        public void ContUpdateProducto(int id, string nombre, string precio, string categoria)
        {
            //se crea un objeto del modelo
            MProducto producto = new MProducto();
            //se usa el metodo para insertar y se entrega los valores
            producto.UpdateProducto(id, nombre, precio, categoria);
        }

    }
}