using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamenSegundoParcial
{
    public partial class FremMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FremMenu()
        {
            InitializeComponent();
        }
        FrmProducto fremProducto = null;
        FrmPedido frmPedido = null;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (fremProducto == null)
            {
                fremProducto = new FrmProducto();
                
                fremProducto.Show();
            }
            else
            {
                fremProducto.Activate();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (frmPedido == null)
            {
                frmPedido = new FrmPedido();
                
                frmPedido.Show();
            }
            else
            {
                frmPedido.Activate();
            }
        }
    }
}
