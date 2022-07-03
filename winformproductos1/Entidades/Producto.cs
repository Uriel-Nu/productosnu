using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidades
{
    public class Producto
    {//atributos

        private int codigo;
        private string descripcion;
        private int stock;
        private int cantidad;
        private object rows;

        //propiedades para ingresar fuera de la clase

        public int propcodigo

        {
            set { codigo = value; }
            get { return codigo; }

        }
        public string propdescrip
        {
            set { descripcion = value; }
            get { return descripcion; }

        }
        public int propstock
        {
            get { return stock; }
        }










        //constructor 
        public Producto()
        { }
        public Producto(int cod, string descr, int cant)
        {
            codigo = cod;
            descripcion = descr;
            stock = 0;
            cantidad = cant;
        }

        public Producto(int v, string text)
        {
        }

        public void ingreso(int cant)
        {
            stock = stock + cant;

        }
        public void salida(int cant)
        {
            stock = stock - cant;

        }
        
    }
   
            
            
            
            
        
        
        
            






    }

