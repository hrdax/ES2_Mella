using ES2_Mella.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ES2_Mella.Controlador
{
    public class categoriaControlador
    {
        //Sevira para poder hacer el insert a la tabla y se piden valores
        public void ContInsertarCategoria(string nombre)
        {
            //se crea un objeto del modelo
            MCategoria categoria = new MCategoria();
            //se usa el metodo para insertar y se entrega los valores
            categoria.InsertarCategoria(nombre);
        }
        //Servira para poder pedir información de la tabla con modelo
        public SqlDataReader ContMostrarCategorias()
        {
            //Crea el objeto del modelo
            MCategoria categoria = new MCategoria();
            //Retorna el resultado del select del metodo mostrarproducto
            return categoria.MostrarCategoria();
        }

        //Servira para poder pedir información de 1 categoria
        public SqlDataReader ContMostrar1Categoria(int id)
        {
            //Crea el objeto del modelo
            MCategoria categoria = new MCategoria();
            //Retorna el resultado del select del metodo mostrar1categoria
            return categoria.Mostrar1Categoria(id);
        }

        //Servirá para borrar la categoría
        public void ContBorrarCategoria(int id)
        {
            //se crea un objeto del modelo
            MCategoria categoria = new MCategoria();
            //se usa el metodo para insertar y se entrega los valores
            categoria.EliminarCategoria(id);
        }

        //Sevira para poder hacer el update a la tabla y se piden valores
        public void ContUpdateCategoria(int id, string nombre)
        {
            //se crea un objeto del modelo
            MCategoria categoria = new MCategoria();
            //se usa el metodo para insertar y se entrega los valores
            categoria.UpdateCategoria(id, nombre);
        }

    }
}