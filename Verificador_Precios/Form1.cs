using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verificador_Precios
{
    public partial class Form1 : Form
    {
        private int segundos = 0;
        private string codigo = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logo.Location = new Point(this.Width/2-logo.Width/2, 10);
            pregunta.Location = new Point(this.Width / 2 - pregunta.Width / 2, logo.Height+250);
            nombreTienda.Location = new Point(this.Width / 2 - nombreTienda.Width / 2, logo.Height);
            instruccion.Location = new Point(this.Width / 2 - instruccion.Width / 2, logo.Height + 310);
            scannerImg.Location = new Point(this.Width / 2 - scannerImg.Width / 2, this.Height / 2 +200 );
            productoImg.Location = new Point(this.Width/7, this.Height / 3);
            nombreProducto.Location = new Point(this.Width / 2, this.Height / 3);
            precioProducto.Location = new Point(productoImg.Width, productoImg.Height + 400);
            cantProducto.Location = new Point(this.Width / 2, this.Height/2);

            productoImg.Visible = false;
            nombreProducto.Visible = false;
            precioProducto.Visible = false;
            cantProducto.Visible = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    MySqlConnection conn;
                    conn = new MySqlConnection("server=127.0.0.1; user= root; database= verificador; SSL Mode = None;");
                    conn.Open();
                    string query = "SELECT producto_nombre, producto_precio, producto_cantidad, producto_imagen FROM productos WHERE producto_codigo =" + codigo + ";";
                    //MessageBox.Show("Query: " + query);
                    MySqlCommand comm;
                    comm = new MySqlCommand(query,conn);
                    MySqlDataReader resultado = comm.ExecuteReader();

                    if (resultado.HasRows)
                    {
                        MessageBox.Show("Buscando producto ..");
                        resultado.Read();

                        nombreProducto.Visible = true;
                        productoImg.Visible = true;
                        precioProducto.Visible = true;
                        cantProducto.Visible = true;
                        scannerImg.Visible = false;
                        pregunta.Visible = false;
                        instruccion.Visible = false;


                        nombreProducto.Text = resultado.GetString(0);
                        precioProducto.Text = "$"+resultado.GetString(1);
                        cantProducto.Text = "Cantidad disponible: "+ resultado.GetString(2);
                            //Environment.NewLine + "Stock:" + 
                        productoImg.ImageLocation = resultado.GetString(3);
                        productoImg.SizeMode = PictureBoxSizeMode.StretchImage;


                        segundos = 0;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El producto no se encuentra");
                    }
                    
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString(), "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                codigo = "";
            }
            else
            {
                codigo += e.KeyChar;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;

            if (segundos == 4)
            {
                timer1.Enabled = false;
                scannerImg.Visible = true;
                pregunta.Visible = true;
                instruccion.Visible = true;
                productoImg.Visible = false;
                precioProducto.Visible = false;
                cantProducto.Visible = false;
                nombreProducto.Text = "";
                precioProducto.Text = "";
                cantProducto.Text = "";


            }
        }
    }
}
