namespace Sitema_De_Punto_De_Venta
{
    partial class Sistema_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.But_Maxi = new System.Windows.Forms.PictureBox();
            this.Icono_Restaurar = new System.Windows.Forms.PictureBox();
            this.Icono_Minimiza = new System.Windows.Forms.PictureBox();
            this.Icono_Cerrar = new System.Windows.Forms.PictureBox();
            this.BotonDeslizando = new System.Windows.Forms.PictureBox();
            this.Menu_vertical = new System.Windows.Forms.Panel();
            this.But_Bodegas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.But_Empleados = new System.Windows.Forms.Button();
            this.But_Compras = new System.Windows.Forms.Button();
            this.But_Ventas = new System.Windows.Forms.Button();
            this.But_Productos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Hora = new System.Windows.Forms.Label();
            this.Lbl_Perfil = new System.Windows.Forms.Label();
            this.Pic_Usuario = new System.Windows.Forms.PictureBox();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Panel_Contenedor = new System.Windows.Forms.Panel();
            this.Hora_Fecha = new System.Windows.Forms.Timer(this.components);
            this.But_Cerrar_Seción = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.But_Maxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Minimiza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonDeslizando)).BeginInit();
            this.Menu_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.But_Maxi);
            this.panel1.Controls.Add(this.Icono_Restaurar);
            this.panel1.Controls.Add(this.Icono_Minimiza);
            this.panel1.Controls.Add(this.Icono_Cerrar);
            this.panel1.Controls.Add(this.BotonDeslizando);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(269, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 44);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // But_Maxi
            // 
            this.But_Maxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.But_Maxi.Image = ((System.Drawing.Image)(resources.GetObject("But_Maxi.Image")));
            this.But_Maxi.Location = new System.Drawing.Point(980, 3);
            this.But_Maxi.Name = "But_Maxi";
            this.But_Maxi.Size = new System.Drawing.Size(20, 20);
            this.But_Maxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.But_Maxi.TabIndex = 3;
            this.But_Maxi.TabStop = false;
            this.But_Maxi.Click += new System.EventHandler(this.But_Maxi_Click);
            // 
            // Icono_Restaurar
            // 
            this.Icono_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icono_Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Icono_Restaurar.Image")));
            this.Icono_Restaurar.Location = new System.Drawing.Point(980, 3);
            this.Icono_Restaurar.Name = "Icono_Restaurar";
            this.Icono_Restaurar.Size = new System.Drawing.Size(20, 20);
            this.Icono_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icono_Restaurar.TabIndex = 0;
            this.Icono_Restaurar.TabStop = false;
            this.Icono_Restaurar.Click += new System.EventHandler(this.Icono_Restaurar_Click);
            // 
            // Icono_Minimiza
            // 
            this.Icono_Minimiza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icono_Minimiza.Image = ((System.Drawing.Image)(resources.GetObject("Icono_Minimiza.Image")));
            this.Icono_Minimiza.Location = new System.Drawing.Point(957, 3);
            this.Icono_Minimiza.Name = "Icono_Minimiza";
            this.Icono_Minimiza.Size = new System.Drawing.Size(20, 20);
            this.Icono_Minimiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icono_Minimiza.TabIndex = 2;
            this.Icono_Minimiza.TabStop = false;
            this.Icono_Minimiza.Click += new System.EventHandler(this.Icono_Minimiza_Click);
            // 
            // Icono_Cerrar
            // 
            this.Icono_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icono_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Icono_Cerrar.Image")));
            this.Icono_Cerrar.Location = new System.Drawing.Point(1004, 3);
            this.Icono_Cerrar.Name = "Icono_Cerrar";
            this.Icono_Cerrar.Size = new System.Drawing.Size(20, 20);
            this.Icono_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icono_Cerrar.TabIndex = 0;
            this.Icono_Cerrar.TabStop = false;
            this.Icono_Cerrar.Click += new System.EventHandler(this.Icono_Cerrar_Click);
            // 
            // BotonDeslizando
            // 
            this.BotonDeslizando.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonDeslizando.Image = ((System.Drawing.Image)(resources.GetObject("BotonDeslizando.Image")));
            this.BotonDeslizando.Location = new System.Drawing.Point(6, 4);
            this.BotonDeslizando.Name = "BotonDeslizando";
            this.BotonDeslizando.Size = new System.Drawing.Size(35, 35);
            this.BotonDeslizando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonDeslizando.TabIndex = 0;
            this.BotonDeslizando.TabStop = false;
            this.BotonDeslizando.Click += new System.EventHandler(this.BotonDeslizando_Click);
            // 
            // Menu_vertical
            // 
            this.Menu_vertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.Menu_vertical.Controls.Add(this.But_Cerrar_Seción);
            this.Menu_vertical.Controls.Add(this.But_Bodegas);
            this.Menu_vertical.Controls.Add(this.pictureBox1);
            this.Menu_vertical.Controls.Add(this.button6);
            this.Menu_vertical.Controls.Add(this.But_Empleados);
            this.Menu_vertical.Controls.Add(this.But_Compras);
            this.Menu_vertical.Controls.Add(this.But_Ventas);
            this.Menu_vertical.Controls.Add(this.But_Productos);
            this.Menu_vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_vertical.Location = new System.Drawing.Point(0, 0);
            this.Menu_vertical.Name = "Menu_vertical";
            this.Menu_vertical.Size = new System.Drawing.Size(269, 777);
            this.Menu_vertical.TabIndex = 3;
            this.Menu_vertical.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_vertical_Paint);
            // 
            // But_Bodegas
            // 
            this.But_Bodegas.BackColor = System.Drawing.Color.Transparent;
            this.But_Bodegas.FlatAppearance.BorderSize = 0;
            this.But_Bodegas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.But_Bodegas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Bodegas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Bodegas.ForeColor = System.Drawing.Color.White;
            this.But_Bodegas.Image = ((System.Drawing.Image)(resources.GetObject("But_Bodegas.Image")));
            this.But_Bodegas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.But_Bodegas.Location = new System.Drawing.Point(0, 343);
            this.But_Bodegas.Name = "But_Bodegas";
            this.But_Bodegas.Size = new System.Drawing.Size(269, 45);
            this.But_Bodegas.TabIndex = 5;
            this.But_Bodegas.Text = "    Bodegas";
            this.But_Bodegas.UseVisualStyleBackColor = false;
            this.But_Bodegas.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 296);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(269, 45);
            this.button6.TabIndex = 4;
            this.button6.Text = "    Clientes";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // But_Empleados
            // 
            this.But_Empleados.BackColor = System.Drawing.Color.Transparent;
            this.But_Empleados.FlatAppearance.BorderSize = 0;
            this.But_Empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.But_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Empleados.ForeColor = System.Drawing.Color.White;
            this.But_Empleados.Image = ((System.Drawing.Image)(resources.GetObject("But_Empleados.Image")));
            this.But_Empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.But_Empleados.Location = new System.Drawing.Point(0, 251);
            this.But_Empleados.Name = "But_Empleados";
            this.But_Empleados.Size = new System.Drawing.Size(269, 45);
            this.But_Empleados.TabIndex = 3;
            this.But_Empleados.Text = "    Empleados";
            this.But_Empleados.UseVisualStyleBackColor = false;
            this.But_Empleados.Click += new System.EventHandler(this.But_Empleados_Click);
            // 
            // But_Compras
            // 
            this.But_Compras.BackColor = System.Drawing.Color.Transparent;
            this.But_Compras.FlatAppearance.BorderSize = 0;
            this.But_Compras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.But_Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Compras.ForeColor = System.Drawing.Color.White;
            this.But_Compras.Image = ((System.Drawing.Image)(resources.GetObject("But_Compras.Image")));
            this.But_Compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.But_Compras.Location = new System.Drawing.Point(0, 205);
            this.But_Compras.Name = "But_Compras";
            this.But_Compras.Size = new System.Drawing.Size(269, 45);
            this.But_Compras.TabIndex = 2;
            this.But_Compras.Text = "    Compras";
            this.But_Compras.UseVisualStyleBackColor = false;
            this.But_Compras.Click += new System.EventHandler(this.button3_Click);
            // 
            // But_Ventas
            // 
            this.But_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.But_Ventas.FlatAppearance.BorderSize = 0;
            this.But_Ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.But_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Ventas.ForeColor = System.Drawing.Color.White;
            this.But_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("But_Ventas.Image")));
            this.But_Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.But_Ventas.Location = new System.Drawing.Point(0, 160);
            this.But_Ventas.Name = "But_Ventas";
            this.But_Ventas.Size = new System.Drawing.Size(269, 45);
            this.But_Ventas.TabIndex = 1;
            this.But_Ventas.Text = "    Ventas";
            this.But_Ventas.UseVisualStyleBackColor = false;
            this.But_Ventas.Click += new System.EventHandler(this.But_ventas_Click);
            // 
            // But_Productos
            // 
            this.But_Productos.BackColor = System.Drawing.Color.Transparent;
            this.But_Productos.FlatAppearance.BorderSize = 0;
            this.But_Productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.But_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Productos.ForeColor = System.Drawing.Color.White;
            this.But_Productos.Image = ((System.Drawing.Image)(resources.GetObject("But_Productos.Image")));
            this.But_Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.But_Productos.Location = new System.Drawing.Point(0, 115);
            this.But_Productos.Name = "But_Productos";
            this.But_Productos.Size = new System.Drawing.Size(269, 45);
            this.But_Productos.TabIndex = 0;
            this.But_Productos.Text = "    Productos";
            this.But_Productos.UseVisualStyleBackColor = false;
            this.But_Productos.Click += new System.EventHandler(this.But_Productos_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Lbl_Fecha);
            this.panel2.Controls.Add(this.Lbl_Hora);
            this.panel2.Controls.Add(this.Lbl_Perfil);
            this.panel2.Controls.Add(this.Pic_Usuario);
            this.panel2.Controls.Add(this.Lbl_Usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(269, 687);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 90);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.ForeColor = System.Drawing.Color.White;
            this.Lbl_Fecha.Location = new System.Drawing.Point(798, 51);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(0, 18);
            this.Lbl_Fecha.TabIndex = 4;
            // 
            // Lbl_Hora
            // 
            this.Lbl_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Hora.AutoSize = true;
            this.Lbl_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hora.ForeColor = System.Drawing.Color.White;
            this.Lbl_Hora.Location = new System.Drawing.Point(826, 9);
            this.Lbl_Hora.Name = "Lbl_Hora";
            this.Lbl_Hora.Size = new System.Drawing.Size(0, 42);
            this.Lbl_Hora.TabIndex = 3;
            // 
            // Lbl_Perfil
            // 
            this.Lbl_Perfil.AutoSize = true;
            this.Lbl_Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Perfil.ForeColor = System.Drawing.Color.White;
            this.Lbl_Perfil.Location = new System.Drawing.Point(120, 51);
            this.Lbl_Perfil.Name = "Lbl_Perfil";
            this.Lbl_Perfil.Size = new System.Drawing.Size(112, 18);
            this.Lbl_Perfil.TabIndex = 2;
            this.Lbl_Perfil.Text = "Administrador";
            // 
            // Pic_Usuario
            // 
            this.Pic_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Usuario.Image")));
            this.Pic_Usuario.Location = new System.Drawing.Point(27, 11);
            this.Pic_Usuario.Name = "Pic_Usuario";
            this.Pic_Usuario.Size = new System.Drawing.Size(78, 72);
            this.Pic_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Usuario.TabIndex = 0;
            this.Pic_Usuario.TabStop = false;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.ForeColor = System.Drawing.Color.White;
            this.Lbl_Usuario.Location = new System.Drawing.Point(120, 29);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(107, 18);
            this.Lbl_Usuario.TabIndex = 0;
            this.Lbl_Usuario.Text = "Jairon Adrian";
            // 
            // Panel_Contenedor
            // 
            this.Panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.Panel_Contenedor.BackgroundImage = global::Sitema_De_Punto_De_Venta.Properties.Resources.Fondo_Del_Contenedor1;
            this.Panel_Contenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Contenedor.Location = new System.Drawing.Point(269, 44);
            this.Panel_Contenedor.Name = "Panel_Contenedor";
            this.Panel_Contenedor.Size = new System.Drawing.Size(1034, 643);
            this.Panel_Contenedor.TabIndex = 5;
            this.Panel_Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Contenedor_Paint);
            // 
            // Hora_Fecha
            // 
            this.Hora_Fecha.Enabled = true;
            this.Hora_Fecha.Tick += new System.EventHandler(this.Hora_Fecha_Tick);
            // 
            // But_Cerrar_Seción
            // 
            this.But_Cerrar_Seción.BackColor = System.Drawing.Color.Transparent;
            this.But_Cerrar_Seción.FlatAppearance.BorderSize = 0;
            this.But_Cerrar_Seción.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.But_Cerrar_Seción.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Cerrar_Seción.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Cerrar_Seción.ForeColor = System.Drawing.Color.White;
            this.But_Cerrar_Seción.Image = ((System.Drawing.Image)(resources.GetObject("But_Cerrar_Seción.Image")));
            this.But_Cerrar_Seción.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.But_Cerrar_Seción.Location = new System.Drawing.Point(0, 712);
            this.But_Cerrar_Seción.Name = "But_Cerrar_Seción";
            this.But_Cerrar_Seción.Size = new System.Drawing.Size(269, 45);
            this.But_Cerrar_Seción.TabIndex = 6;
            this.But_Cerrar_Seción.Text = "    Cerrar Seción";
            this.But_Cerrar_Seción.UseVisualStyleBackColor = false;
            this.But_Cerrar_Seción.Click += new System.EventHandler(this.But_Cerrar_Seción_Click);
            // 
            // Sistema_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(1303, 777);
            this.Controls.Add(this.Panel_Contenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Menu_vertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Sistema_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema_Principal";
            this.Load += new System.EventHandler(this.Sistema_Principal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.But_Maxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Minimiza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonDeslizando)).EndInit();
            this.Menu_vertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BotonDeslizando;
        private System.Windows.Forms.Panel Menu_vertical;
        private System.Windows.Forms.PictureBox Icono_Restaurar;
        private System.Windows.Forms.PictureBox Icono_Minimiza;
        private System.Windows.Forms.PictureBox Icono_Cerrar;
        private System.Windows.Forms.Button But_Productos;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button But_Empleados;
        private System.Windows.Forms.Button But_Compras;
        private System.Windows.Forms.Button But_Ventas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox But_Maxi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Panel_Contenedor;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.PictureBox Pic_Usuario;
        private System.Windows.Forms.Label Lbl_Perfil;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Hora;
        private System.Windows.Forms.Timer Hora_Fecha;
        private System.Windows.Forms.Button But_Bodegas;
        private System.Windows.Forms.Button But_Cerrar_Seción;
    }
}