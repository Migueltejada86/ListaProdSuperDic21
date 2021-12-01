using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaProductos
{
    public class ProdSuper
    {
        public Productos[] producto { get; set; }

        public DataTable DTsuper { get; set; } = new DataTable();

        
        public ProdSuper()
        {
            //Constructor de DaTa
            DTsuper.TableName = "Lista de Productos";
            DTsuper.Columns.Add("Codigo");
            DTsuper.Columns.Add("Producto");
            DTsuper.Columns.Add("Precio");

   
            LeerDaTa_Archivo();
        }
        
        public void LeerDaTa_Archivo()
        {
            //Método leer archivo
            //if (System.IO.File.Exists("Super.xml"))
            if (System.IO.File.Exists("Super.xml"))
            {
                DTsuper.Clear();
                DTsuper.ReadXml("Super.xml");
               
            }
        }

       //Método para cargar
        public void Cargar (Productos productos) 
        {

            if (productos.Codigo != 0 &&
                productos.Producto != "" &&
                productos.Precio != 0 )
            {
                DTsuper.Rows.Add();
                int NuevoProducto = DTsuper.Rows.Count - 1;
                DTsuper.Rows[NuevoProducto]["Codigo"] = productos.Codigo;
                DTsuper.Rows[NuevoProducto]["Producto"] = productos.Producto;
                DTsuper.Rows[NuevoProducto]["Precio"] = productos.Precio;
                DTsuper.WriteXml("Super.xml");
            }
        }
        
        
        public void Borrar() //Botón de borrar
        {
            DTsuper.Rows.Clear();
            DTsuper.WriteXml("Super.xml");
        }



    }
}













