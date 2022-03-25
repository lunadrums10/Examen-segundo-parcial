using Datos.Acceso;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenSegundoParcial
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        string operacion = string.Empty;

        ProductoDA productoDA = new ProductoDA();

      

        private void ProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ProductosDataGridView.DataSource = productoDA.ListarProductos();
        }

        
    }
}
