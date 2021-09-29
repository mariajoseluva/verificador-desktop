
namespace Verificador_Precios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logo = new System.Windows.Forms.PictureBox();
            this.pregunta = new System.Windows.Forms.Label();
            this.scannerImg = new System.Windows.Forms.PictureBox();
            this.nombreProducto = new System.Windows.Forms.Label();
            this.productoImg = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nombreTienda = new System.Windows.Forms.Label();
            this.instruccion = new System.Windows.Forms.Label();
            this.precioProducto = new System.Windows.Forms.Label();
            this.cantProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scannerImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(594, 13);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(230, 197);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // pregunta
            // 
            this.pregunta.AutoSize = true;
            this.pregunta.Font = new System.Drawing.Font("Verdana", 34.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregunta.ForeColor = System.Drawing.Color.White;
            this.pregunta.Location = new System.Drawing.Point(263, 326);
            this.pregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(936, 71);
            this.pregunta.TabIndex = 1;
            this.pregunta.Text = "¿Qué producto desea verificar?";
            // 
            // scannerImg
            // 
            this.scannerImg.BackColor = System.Drawing.Color.Khaki;
            this.scannerImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scannerImg.Image = ((System.Drawing.Image)(resources.GetObject("scannerImg.Image")));
            this.scannerImg.Location = new System.Drawing.Point(594, 603);
            this.scannerImg.Margin = new System.Windows.Forms.Padding(4);
            this.scannerImg.Name = "scannerImg";
            this.scannerImg.Size = new System.Drawing.Size(190, 139);
            this.scannerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scannerImg.TabIndex = 2;
            this.scannerImg.TabStop = false;
            // 
            // nombreProducto
            // 
            this.nombreProducto.AutoSize = true;
            this.nombreProducto.Font = new System.Drawing.Font("Verdana", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProducto.ForeColor = System.Drawing.Color.White;
            this.nombreProducto.Location = new System.Drawing.Point(646, 303);
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Size = new System.Drawing.Size(393, 46);
            this.nombreProducto.TabIndex = 3;
            this.nombreProducto.Text = "Nombre producto";
            // 
            // productoImg
            // 
            this.productoImg.Location = new System.Drawing.Point(36, 280);
            this.productoImg.Name = "productoImg";
            this.productoImg.Size = new System.Drawing.Size(430, 380);
            this.productoImg.TabIndex = 4;
            this.productoImg.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nombreTienda
            // 
            this.nombreTienda.AutoSize = true;
            this.nombreTienda.Font = new System.Drawing.Font("Edwardian Script ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTienda.ForeColor = System.Drawing.Color.Red;
            this.nombreTienda.Location = new System.Drawing.Point(513, 209);
            this.nombreTienda.Name = "nombreTienda";
            this.nombreTienda.Size = new System.Drawing.Size(391, 94);
            this.nombreTienda.TabIndex = 5;
            this.nombreTienda.Text = "Super del Sur";
            // 
            // instruccion
            // 
            this.instruccion.AutoSize = true;
            this.instruccion.Font = new System.Drawing.Font("Verdana", 19.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruccion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.instruccion.Location = new System.Drawing.Point(328, 400);
            this.instruccion.Name = "instruccion";
            this.instruccion.Size = new System.Drawing.Size(755, 40);
            this.instruccion.TabIndex = 6;
            this.instruccion.Text = "Pase el código de barras debajo del scanner";
            // 
            // precioProducto
            // 
            this.precioProducto.AutoSize = true;
            this.precioProducto.Font = new System.Drawing.Font("Verdana", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioProducto.ForeColor = System.Drawing.Color.Blue;
            this.precioProducto.Location = new System.Drawing.Point(211, 716);
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.Size = new System.Drawing.Size(153, 46);
            this.precioProducto.TabIndex = 7;
            this.precioProducto.Text = "Precio";
            // 
            // cantProducto
            // 
            this.cantProducto.AutoSize = true;
            this.cantProducto.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantProducto.ForeColor = System.Drawing.Color.White;
            this.cantProducto.Location = new System.Drawing.Point(648, 471);
            this.cantProducto.Name = "cantProducto";
            this.cantProducto.Size = new System.Drawing.Size(319, 34);
            this.cantProducto.TabIndex = 8;
            this.cantProducto.Text = "Cantidad disponible: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1559, 823);
            this.Controls.Add(this.cantProducto);
            this.Controls.Add(this.precioProducto);
            this.Controls.Add(this.instruccion);
            this.Controls.Add(this.nombreTienda);
            this.Controls.Add(this.nombreProducto);
            this.Controls.Add(this.scannerImg);
            this.Controls.Add(this.pregunta);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.productoImg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scannerImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label pregunta;
        private System.Windows.Forms.PictureBox scannerImg;
        private System.Windows.Forms.Label nombreProducto;
        private System.Windows.Forms.PictureBox productoImg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label nombreTienda;
        private System.Windows.Forms.Label instruccion;
        private System.Windows.Forms.Label precioProducto;
        private System.Windows.Forms.Label cantProducto;
    }
}

