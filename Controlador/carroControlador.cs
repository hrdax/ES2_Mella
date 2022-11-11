using ES2_Mella.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ES2_Mella.Controlador
{
    public class carroControlador
    {

        //Sevira para poder hacer el insert a la tabla y se piden valores
        public void ContInsertarCarro(string nombre, string precio)
        {
            //se crea un objeto del modelo
            MCarrito carro = new MCarrito();
            //se usa el metodo para insertar y se entrega los valores
            carro.InsertarCarro(nombre, precio);
        }

        //Servira para poder pedir información de la tabla
        public SqlDataReader ContMostrarCarro()
        {
            //Crea el objeto del modelo
            MCarrito carro = new MCarrito();
            //Retorna el resultado del select del metodo mostrarproducto
            return carro.MostrarCarro();
        }

        //Servirá para borrar un producto del carro
        public void ContBorrarProductoCarro(int id)
        {
            //se crea un objeto del modelo
            MCarrito carro = new MCarrito();
            //se usa el metodo para insertar y se entrega los valores
            carro.EliminarProductoCarro(id);
        }

    }
}