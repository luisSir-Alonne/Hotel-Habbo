namespace MAP2A1HotelHeavens
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
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.msAreas = new System.Windows.Forms.MenuStrip();
            this.imiCheckIn = new FontAwesome.Sharp.IconMenuItem();
            this.imiCheckOut = new FontAwesome.Sharp.IconMenuItem();
            this.imiControlUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.imiVentas = new FontAwesome.Sharp.IconMenuItem();
            this.imiHotel = new FontAwesome.Sharp.IconMenuItem();
            this.imiControlEmpleados = new FontAwesome.Sharp.IconMenuItem();
            this.imiAdmin = new FontAwesome.Sharp.IconMenuItem();
            this.panMostrar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.msAreas.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.picMinimizar.Image = global::MAP2A1HotelHeavens.Properties.Resources.menos;
            this.picMinimizar.Location = new System.Drawing.Point(1280, 7);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(34, 43);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimizar.TabIndex = 7;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // picCerrar
            // 
            this.picCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.picCerrar.Image = global::MAP2A1HotelHeavens.Properties.Resources.cerrar;
            this.picCerrar.Location = new System.Drawing.Point(1320, 7);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(34, 43);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 6;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 58);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(204)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hotel Heaven\'s";
            // 
            // msAreas
            // 
            this.msAreas.AutoSize = false;
            this.msAreas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.msAreas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imiCheckIn,
            this.imiCheckOut,
            this.imiControlUsuario,
            this.imiVentas,
            this.imiHotel,
            this.imiControlEmpleados,
            this.imiAdmin});
            this.msAreas.Location = new System.Drawing.Point(0, 58);
            this.msAreas.Name = "msAreas";
            this.msAreas.Size = new System.Drawing.Size(1366, 73);
            this.msAreas.TabIndex = 20;
            this.msAreas.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msAreas_ItemClicked);
            // 
            // imiCheckIn
            // 
            this.imiCheckIn.AutoSize = false;
            this.imiCheckIn.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.imiCheckIn.ForeColor = System.Drawing.Color.White;
            this.imiCheckIn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.imiCheckIn.IconColor = System.Drawing.Color.White;
            this.imiCheckIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiCheckIn.IconSize = 50;
            this.imiCheckIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imiCheckIn.Name = "imiCheckIn";
            this.imiCheckIn.Size = new System.Drawing.Size(122, 69);
            this.imiCheckIn.Text = "CheckIn";
            this.imiCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.imiCheckIn.Click += new System.EventHandler(this.imiCheckIn_Click);
            // 
            // imiCheckOut
            // 
            this.imiCheckOut.AutoSize = false;
            this.imiCheckOut.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.imiCheckOut.ForeColor = System.Drawing.Color.White;
            this.imiCheckOut.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.imiCheckOut.IconColor = System.Drawing.Color.White;
            this.imiCheckOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiCheckOut.IconSize = 50;
            this.imiCheckOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imiCheckOut.Name = "imiCheckOut";
            this.imiCheckOut.Size = new System.Drawing.Size(122, 69);
            this.imiCheckOut.Text = "CheckOut";
            this.imiCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.imiCheckOut.Click += new System.EventHandler(this.imiCheckOut_Click);
            // 
            // imiControlUsuario
            // 
            this.imiControlUsuario.AutoSize = false;
            this.imiControlUsuario.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.imiControlUsuario.ForeColor = System.Drawing.Color.White;
            this.imiControlUsuario.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.imiControlUsuario.IconColor = System.Drawing.Color.White;
            this.imiControlUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiControlUsuario.IconSize = 50;
            this.imiControlUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imiControlUsuario.Name = "imiControlUsuario";
            this.imiControlUsuario.Size = new System.Drawing.Size(122, 69);
            this.imiControlUsuario.Text = "Control Usuario";
            this.imiControlUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.imiControlUsuario.Click += new System.EventHandler(this.imiControlUsuario_Click);
            // 
            // imiVentas
            // 
            this.imiVentas.AutoSize = false;
            this.imiVentas.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.imiVentas.ForeColor = System.Drawing.Color.White;
            this.imiVentas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.imiVentas.IconColor = System.Drawing.Color.White;
            this.imiVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiVentas.IconSize = 50;
            this.imiVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imiVentas.Name = "imiVentas";
            this.imiVentas.Size = new System.Drawing.Size(122, 69);
            this.imiVentas.Text = "Ventas";
            this.imiVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.imiVentas.Click += new System.EventHandler(this.imiVentas_Click);
            // 
            // imiHotel
            // 
            this.imiHotel.AutoSize = false;
            this.imiHotel.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.imiHotel.ForeColor = System.Drawing.Color.White;
            this.imiHotel.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.imiHotel.IconColor = System.Drawing.Color.White;
            this.imiHotel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiHotel.IconSize = 50;
            this.imiHotel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imiHotel.Name = "imiHotel";
            this.imiHotel.Size = new System.Drawing.Size(122, 69);
            this.imiHotel.Text = "Hotel";
            this.imiHotel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.imiHotel.Click += new System.EventHandler(this.imiHotel_Click);
            // 
            // imiControlEmpleados
            // 
            this.imiControlEmpleados.AutoSize = false;
            this.imiControlEmpleados.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.imiControlEmpleados.ForeColor = System.Drawing.Color.White;
            this.imiControlEmpleados.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.imiControlEmpleados.IconColor = System.Drawing.Color.White;
            this.imiControlEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiControlEmpleados.IconSize = 50;
            this.imiControlEmpleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imiControlEmpleados.Name = "imiControlEmpleados";
            this.imiControlEmpleados.Size = new System.Drawing.Size(122, 69);
            this.imiControlEmpleados.Text = "Control Empleados";
            this.imiControlEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.imiControlEmpleados.Click += new System.EventHandler(this.imiControlEmpleados_Click);
            // 
            // imiAdmin
            // 
            this.imiAdmin.AutoSize = false;
            this.imiAdmin.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.imiAdmin.ForeColor = System.Drawing.Color.White;
            this.imiAdmin.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.imiAdmin.IconColor = System.Drawing.Color.White;
            this.imiAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imiAdmin.IconSize = 50;
            this.imiAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imiAdmin.Name = "imiAdmin";
            this.imiAdmin.Size = new System.Drawing.Size(122, 69);
            this.imiAdmin.Text = "Control Jefes";
            this.imiAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.imiAdmin.Click += new System.EventHandler(this.imiAdmin_Click);
            // 
            // panMostrar
            // 
            this.panMostrar.Font = new System.Drawing.Font("HP Simplified", 8.25F);
            this.panMostrar.Location = new System.Drawing.Point(0, 131);
            this.panMostrar.Name = "panMostrar";
            this.panMostrar.Size = new System.Drawing.Size(1366, 637);
            this.panMostrar.TabIndex = 21;
            this.panMostrar.Paint += new System.Windows.Forms.PaintEventHandler(this.panMostrar_Paint);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(0, 725);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1366, 43);
            this.label3.TabIndex = 41;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblUsuario.Font = new System.Drawing.Font("HP Simplified", 12.25F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(204)))), ((int)(((byte)(200)))));
            this.lblUsuario.Location = new System.Drawing.Point(122, 736);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 20);
            this.lblUsuario.TabIndex = 43;
            this.lblUsuario.Text = "usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.label2.Font = new System.Drawing.Font("HP Simplified", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(204)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(12, 729);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "Usuario:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panMostrar);
            this.Controls.Add(this.msAreas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picMinimizar);
            this.Controls.Add(this.picCerrar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.msAreas.ResumeLayout(false);
            this.msAreas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip msAreas;
        private FontAwesome.Sharp.IconMenuItem imiCheckIn;
        private FontAwesome.Sharp.IconMenuItem imiCheckOut;
        private FontAwesome.Sharp.IconMenuItem imiControlUsuario;
        private FontAwesome.Sharp.IconMenuItem imiVentas;
        private FontAwesome.Sharp.IconMenuItem imiHotel;
        private FontAwesome.Sharp.IconMenuItem imiAdmin;
        private FontAwesome.Sharp.IconMenuItem imiControlEmpleados;
        private System.Windows.Forms.Panel panMostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label2;
    }
}

