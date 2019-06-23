namespace Sitema_De_Punto_De_Venta
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.label1 = new System.Windows.Forms.Label();
            this.Icono_Cerrar = new System.Windows.Forms.PictureBox();
            this.But_Productos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // Icono_Cerrar
            // 
            this.Icono_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icono_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icono_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Icono_Cerrar.Image")));
            this.Icono_Cerrar.Location = new System.Drawing.Point(882, 12);
            this.Icono_Cerrar.Name = "Icono_Cerrar";
            this.Icono_Cerrar.Size = new System.Drawing.Size(20, 20);
            this.Icono_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icono_Cerrar.TabIndex = 1;
            this.Icono_Cerrar.TabStop = false;
            this.Icono_Cerrar.Click += new System.EventHandler(this.Icono_Cerrar_Click);
            // 
            // But_Productos
            // 
            this.But_Productos.BackColor = System.Drawing.Color.Teal;
            this.But_Productos.FlatAppearance.BorderSize = 0;
            this.But_Productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.But_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Productos.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Productos.ForeColor = System.Drawing.Color.Black;
            this.But_Productos.Image = ((System.Drawing.Image)(resources.GetObject("But_Productos.Image")));
            this.But_Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.But_Productos.Location = new System.Drawing.Point(312, 467);
            this.But_Productos.Name = "But_Productos";
            this.But_Productos.Size = new System.Drawing.Size(269, 45);
            this.But_Productos.TabIndex = 2;
            this.But_Productos.Text = "    Registrar";
            this.But_Productos.UseVisualStyleBackColor = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 569);
            this.Controls.Add(this.But_Productos);
            this.Controls.Add(this.Icono_Cerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Icono_Cerrar;
        private System.Windows.Forms.Button But_Productos;
    }
}