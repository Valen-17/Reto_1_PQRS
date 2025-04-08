namespace Reto_1_PQRS
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.Btn_Nueva_Solicitud = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnResponder = new System.Windows.Forms.Button();
            this.BtnEstado = new System.Windows.Forms.Button();
            this.dvg_Solicitudes = new System.Windows.Forms.DataGridView();
            this.FelicitacionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox5 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Ingreso = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_Inicio = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes3 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Solicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ingreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Inicio)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Nueva_Solicitud
            // 
            this.Btn_Nueva_Solicitud.AutoSize = false;
            this.Btn_Nueva_Solicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.Btn_Nueva_Solicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Btn_Nueva_Solicitud.ForeColor = System.Drawing.Color.White;
            this.Btn_Nueva_Solicitud.Location = new System.Drawing.Point(173, 40);
            this.Btn_Nueva_Solicitud.Name = "Btn_Nueva_Solicitud";
            this.Btn_Nueva_Solicitud.Size = new System.Drawing.Size(366, 24);
            this.Btn_Nueva_Solicitud.TabIndex = 48;
            this.Btn_Nueva_Solicitud.Text = "/ Vista Adminitrador";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.BtnEliminar);
            this.guna2Panel2.Controls.Add(this.BtnResponder);
            this.guna2Panel2.Controls.Add(this.BtnEstado);
            this.guna2Panel2.Controls.Add(this.dvg_Solicitudes);
            this.guna2Panel2.Controls.Add(this.FelicitacionLabel);
            this.guna2Panel2.Location = new System.Drawing.Point(122, 80);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(958, 388);
            this.guna2Panel2.TabIndex = 47;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(170)))), ((int)(((byte)(136)))));
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(651, 275);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(200, 60);
            this.BtnEliminar.TabIndex = 26;
            this.BtnEliminar.Text = "Eliminar Solicitud";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnResponder
            // 
            this.BtnResponder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(170)))), ((int)(((byte)(136)))));
            this.BtnResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResponder.Location = new System.Drawing.Point(651, 192);
            this.BtnResponder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnResponder.Name = "BtnResponder";
            this.BtnResponder.Size = new System.Drawing.Size(200, 60);
            this.BtnResponder.TabIndex = 25;
            this.BtnResponder.Text = "Responder Solicitud";
            this.BtnResponder.UseVisualStyleBackColor = false;
            this.BtnResponder.Click += new System.EventHandler(this.BtnResponder_Click);
            // 
            // BtnEstado
            // 
            this.BtnEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(170)))), ((int)(((byte)(136)))));
            this.BtnEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEstado.Location = new System.Drawing.Point(651, 115);
            this.BtnEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEstado.Name = "BtnEstado";
            this.BtnEstado.Size = new System.Drawing.Size(200, 60);
            this.BtnEstado.TabIndex = 24;
            this.BtnEstado.Text = "Estado Solicitud ";
            this.BtnEstado.UseVisualStyleBackColor = false;
            this.BtnEstado.Click += new System.EventHandler(this.BtnEstado_Click);
            // 
            // dvg_Solicitudes
            // 
            this.dvg_Solicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Solicitudes.Location = new System.Drawing.Point(92, 73);
            this.dvg_Solicitudes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvg_Solicitudes.Name = "dvg_Solicitudes";
            this.dvg_Solicitudes.RowHeadersWidth = 62;
            this.dvg_Solicitudes.RowTemplate.Height = 28;
            this.dvg_Solicitudes.Size = new System.Drawing.Size(521, 280);
            this.dvg_Solicitudes.TabIndex = 23;
            // 
            // FelicitacionLabel
            // 
            this.FelicitacionLabel.AutoSize = false;
            this.FelicitacionLabel.BackColor = System.Drawing.Color.Transparent;
            this.FelicitacionLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FelicitacionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(170)))), ((int)(((byte)(136)))));
            this.FelicitacionLabel.Location = new System.Drawing.Point(340, 12);
            this.FelicitacionLabel.Name = "FelicitacionLabel";
            this.FelicitacionLabel.Size = new System.Drawing.Size(524, 43);
            this.FelicitacionLabel.TabIndex = 18;
            this.FelicitacionLabel.Text = "Vista Administrador";
            // 
            // guna2CirclePictureBox5
            // 
            this.guna2CirclePictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox5.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox5.Image")));
            this.guna2CirclePictureBox5.ImageRotate = 0F;
            this.guna2CirclePictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2CirclePictureBox5.Location = new System.Drawing.Point(1081, 26);
            this.guna2CirclePictureBox5.Name = "guna2CirclePictureBox5";
            this.guna2CirclePictureBox5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox5.Size = new System.Drawing.Size(42, 45);
            this.guna2CirclePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox5.TabIndex = 46;
            this.guna2CirclePictureBox5.TabStop = false;
            this.guna2CirclePictureBox5.UseTransparentBackground = true;
            // 
            // guna2CirclePictureBox4
            // 
            this.guna2CirclePictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox4.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox4.Image")));
            this.guna2CirclePictureBox4.ImageRotate = 0F;
            this.guna2CirclePictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2CirclePictureBox4.Location = new System.Drawing.Point(1040, 29);
            this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox4.Size = new System.Drawing.Size(35, 39);
            this.guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox4.TabIndex = 45;
            this.guna2CirclePictureBox4.TabStop = false;
            this.guna2CirclePictureBox4.UseTransparentBackground = true;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(992, 28);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(42, 41);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox3.TabIndex = 44;
            this.guna2CirclePictureBox3.TabStop = false;
            this.guna2CirclePictureBox3.UseTransparentBackground = true;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(950, 30);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(36, 38);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 43;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.UseTransparentBackground = true;
            // 
            // Ingreso
            // 
            this.Ingreso.BackColor = System.Drawing.Color.Transparent;
            this.Ingreso.FillColor = System.Drawing.Color.Transparent;
            this.Ingreso.Image = ((System.Drawing.Image)(resources.GetObject("Ingreso.Image")));
            this.Ingreso.ImageRotate = 0F;
            this.Ingreso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Ingreso.Location = new System.Drawing.Point(898, 25);
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Ingreso.Size = new System.Drawing.Size(45, 45);
            this.Ingreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ingreso.TabIndex = 42;
            this.Ingreso.TabStop = false;
            this.Ingreso.UseTransparentBackground = true;
            this.Ingreso.Click += new System.EventHandler(this.Ingreso_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(122, 40);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(169, 24);
            this.guna2HtmlLabel1.TabIndex = 41;
            this.guna2HtmlLabel1.Text = "Inicio";
            // 
            // Btn_Inicio
            // 
            this.Btn_Inicio.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Inicio.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Inicio.Image")));
            this.Btn_Inicio.ImageRotate = 0F;
            this.Btn_Inicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Inicio.Location = new System.Drawing.Point(67, 35);
            this.Btn_Inicio.Name = "Btn_Inicio";
            this.Btn_Inicio.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_Inicio.Size = new System.Drawing.Size(42, 34);
            this.Btn_Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Inicio.TabIndex = 40;
            this.Btn_Inicio.TabStop = false;
            this.Btn_Inicio.UseTransparentBackground = true;
            this.Btn_Inicio.Click += new System.EventHandler(this.Btn_Inicio_Click);
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.guna2Shapes2.Location = new System.Drawing.Point(-3, 25);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes2.Size = new System.Drawing.Size(1217, 55);
            this.guna2Shapes2.TabIndex = 39;
            this.guna2Shapes2.Text = "guna2Shapes2";
            this.guna2Shapes2.Zoom = 100;
            // 
            // guna2Shapes3
            // 
            this.guna2Shapes3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.guna2Shapes3.Location = new System.Drawing.Point(436, 0);
            this.guna2Shapes3.Name = "guna2Shapes3";
            this.guna2Shapes3.PolygonSkip = 1;
            this.guna2Shapes3.Rotate = 0F;
            this.guna2Shapes3.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes3.Size = new System.Drawing.Size(317, 32);
            this.guna2Shapes3.TabIndex = 38;
            this.guna2Shapes3.Text = "guna2Shapes3";
            this.guna2Shapes3.Zoom = 100;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(68)))), ((int)(((byte)(5)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(-3, -7);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes1.Size = new System.Drawing.Size(1214, 32);
            this.guna2Shapes1.TabIndex = 37;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1211, 547);
            this.Controls.Add(this.Btn_Nueva_Solicitud);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2CirclePictureBox5);
            this.Controls.Add(this.guna2CirclePictureBox4);
            this.Controls.Add(this.guna2CirclePictureBox3);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.Ingreso);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Btn_Inicio);
            this.Controls.Add(this.guna2Shapes2);
            this.Controls.Add(this.guna2Shapes3);
            this.Controls.Add(this.guna2Shapes1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Solicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ingreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Inicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Btn_Nueva_Solicitud;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnResponder;
        private System.Windows.Forms.Button BtnEstado;
        private System.Windows.Forms.DataGridView dvg_Solicitudes;
        private Guna.UI2.WinForms.Guna2HtmlLabel FelicitacionLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox5;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Ingreso;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Btn_Inicio;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes3;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
    }
}