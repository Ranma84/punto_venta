namespace Sitema_De_Punto_De_Venta
{
    partial class Loguin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loguin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Txt_Usuarios = new System.Windows.Forms.TextBox();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.But_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.But_Minimiza = new System.Windows.Forms.PictureBox();
            this.But_Cerrar = new System.Windows.Forms.PictureBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.But_Minimiza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.But_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 298);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(701, 298);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 279;
            this.lineShape2.X2 = 666;
            this.lineShape2.Y1 = 166;
            this.lineShape2.Y2 = 166;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 281;
            this.lineShape1.X2 = 668;
            this.lineShape1.Y1 = 108;
            this.lineShape1.Y2 = 108;
            // 
            // Txt_Usuarios
            // 
            this.Txt_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.Txt_Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuarios.ForeColor = System.Drawing.Color.White;
            this.Txt_Usuarios.Location = new System.Drawing.Point(283, 86);
            this.Txt_Usuarios.Name = "Txt_Usuarios";
            this.Txt_Usuarios.Size = new System.Drawing.Size(388, 19);
            this.Txt_Usuarios.TabIndex = 2;
            this.Txt_Usuarios.Text = "Usuario";
            this.Txt_Usuarios.TextChanged += new System.EventHandler(this.Txt_Usuarios_TextChanged);
            this.Txt_Usuarios.Enter += new System.EventHandler(this.Txt_Usuarios_Enter);
            this.Txt_Usuarios.MouseLeave += new System.EventHandler(this.Txt_Usuarios_MouseLeave);
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.Txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contraseña.ForeColor = System.Drawing.Color.White;
            this.Txt_Contraseña.HideSelection = false;
            this.Txt_Contraseña.Location = new System.Drawing.Point(283, 143);
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.Size = new System.Drawing.Size(388, 19);
            this.Txt_Contraseña.TabIndex = 3;
            this.Txt_Contraseña.Text = "Contraseña";
            this.Txt_Contraseña.Enter += new System.EventHandler(this.Txt_Contraseña_Enter);
            this.Txt_Contraseña.MouseLeave += new System.EventHandler(this.Txt_Contraseña_MouseLeave);
            // 
            // But_Login
            // 
            this.But_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(78)))));
            this.But_Login.FlatAppearance.BorderSize = 0;
            this.But_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Login.ForeColor = System.Drawing.Color.White;
            this.But_Login.Location = new System.Drawing.Point(279, 228);
            this.But_Login.Name = "But_Login";
            this.But_Login.Size = new System.Drawing.Size(389, 40);
            this.But_Login.TabIndex = 4;
            this.But_Login.Text = "ACCEDER";
            this.But_Login.UseVisualStyleBackColor = false;
            this.But_Login.Click += new System.EventHandler(this.But_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(428, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // But_Minimiza
            // 
            this.But_Minimiza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.But_Minimiza.Image = ((System.Drawing.Image)(resources.GetObject("But_Minimiza.Image")));
            this.But_Minimiza.Location = new System.Drawing.Point(655, 4);
            this.But_Minimiza.Name = "But_Minimiza";
            this.But_Minimiza.Size = new System.Drawing.Size(17, 17);
            this.But_Minimiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.But_Minimiza.TabIndex = 8;
            this.But_Minimiza.TabStop = false;
            this.But_Minimiza.Click += new System.EventHandler(this.But_Minimiza_Click);
            // 
            // But_Cerrar
            // 
            this.But_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.But_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("But_Cerrar.Image")));
            this.But_Cerrar.Location = new System.Drawing.Point(675, 4);
            this.But_Cerrar.Name = "But_Cerrar";
            this.But_Cerrar.Size = new System.Drawing.Size(17, 17);
            this.But_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.But_Cerrar.TabIndex = 7;
            this.But_Cerrar.TabStop = false;
            this.But_Cerrar.Click += new System.EventHandler(this.But_Cerrar_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.White;
            this.lblErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMessage.Location = new System.Drawing.Point(283, 184);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 15);
            this.lblErrorMessage.TabIndex = 9;
            // 
            // linkpass
            // 
            this.linkpass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkpass.AutoSize = true;
            this.linkpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkpass.LinkColor = System.Drawing.Color.White;
            this.linkpass.Location = new System.Drawing.Point(382, 271);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(182, 17);
            this.linkpass.TabIndex = 10;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "¿Ha olvidado contraseña?";
            // 
            // Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(701, 298);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.But_Minimiza);
            this.Controls.Add(this.But_Cerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.But_Login);
            this.Controls.Add(this.Txt_Contraseña);
            this.Controls.Add(this.Txt_Usuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loguin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loguin";
            this.Load += new System.EventHandler(this.Loguin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.But_Minimiza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.But_Cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox Txt_Usuarios;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.Button But_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox But_Minimiza;
        private System.Windows.Forms.PictureBox But_Cerrar;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.LinkLabel linkpass;
    }
}