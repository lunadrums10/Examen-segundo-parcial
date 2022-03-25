using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Acceso
{
    public class PedidosDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=2examen; Uid=root; Pwd=12345;";

        MySqlConnection conn;
        MySqlCommand cmd;
        public DataTable ListarPedidos()
        {
            DataTable listaP = new DataTable();

            try
            {
                string sql = "SELECT * FROM pedido;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaP.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return listaP;
        }
    }
}
