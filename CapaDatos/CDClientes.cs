using System;
using MySql.Data.MySqlClient;
using CapaDatos;
using System.Data;


namespace CapaDatos
{
    public class CDClientes

    {

        string CNX = "Server=185.151.28.144; User= amunoz; Password=@lexander10; Port=57220; database=RescatesDB-31393698f0; SSL Mode= 0";


            public void PruebaConexion()
        {

            MySqlConnection conexion = new MySqlConnection(CNX);

            try
            {
                conexion.Open();
            


            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);

                
                
                
                
                
                
                return;

            }
            System.Windows.Forms.MessageBox.Show("Conectado");

        }


        public void pruebamysql()
        { 
        

        }

    }
}
