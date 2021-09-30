using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using MySql.Data.MySqlClient;

namespace CapaPresentacion
{


    public partial class FormUnidades : Form
    {
        public FormUnidades()
        {
            InitializeComponent();
        }

        private void FormUnidades_Load(object sender, EventArgs e)
        {
            prueba();

      


        }

        public void prueba()
        {

            CapaDatos.CDClientes cDClientes = new CDClientes();

            cDClientes.PruebaConexion();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prueba();
        }
    }
}
