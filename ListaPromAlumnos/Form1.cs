using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaProductos
{
    public partial class Form1 : Form
    {

        public Productos Productos = new Productos();
        public ProdSuper PromAlum = new ProdSuper();
        
       
      
        public Form1()
        {
            InitializeComponent();
            DGV.DataSource = PromAlum.DTsuper;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Productos.Codigo = System.Convert.ToInt32(txtP1.Text);
            Productos.Producto = txtP2.Text;
            Productos.Precio = System.Convert.ToInt32(txtP3.Text);
       
         


        }
        
        private void btCargar_Click(object sender, EventArgs e)
        {

            Productos.Codigo = txtP1.Text;
            Productos.Producto = txtP2.Text;
            Productos.Precio = txtP3.Text;
            PromAlum.Cargar(Productos);

           
            txtP1.Text = "";
            txtP2.Text = "";
            txtP3.Text = "";
         
          

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            ProdSuper.Borrar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
