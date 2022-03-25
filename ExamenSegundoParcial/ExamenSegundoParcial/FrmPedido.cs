using Datos.Acceso;
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
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        string operacion = string.Empty;

        PedidosDA pedidosDA = new PedidosDA();
        private void FrmPedido_Load(object sender, EventArgs e)
        {
            PedidosdataGridView1.DataSource=pedidosDA.ListarPedidos();
        }
    }
}
