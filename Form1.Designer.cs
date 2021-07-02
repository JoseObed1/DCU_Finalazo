
namespace DCU_PFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboCamara = new System.Windows.Forms.ComboBox();
            this.btnDetectar = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.LbNombre = new System.Windows.Forms.Label();
            this.CbClases = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btAsistencia = new System.Windows.Forms.Button();
            this.GBoxCamara = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.GBoxCamara.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCamara
            // 
            this.cboCamara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamara.FormattingEnabled = true;
            this.cboCamara.Location = new System.Drawing.Point(11, 25);
            this.cboCamara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCamara.Name = "cboCamara";
            this.cboCamara.Size = new System.Drawing.Size(188, 21);
            this.cboCamara.TabIndex = 0;
            // 
            // btnDetectar
            // 
            this.btnDetectar.BackColor = System.Drawing.Color.Transparent;
            this.btnDetectar.Image = ((System.Drawing.Image)(resources.GetObject("btnDetectar.Image")));
            this.btnDetectar.Location = new System.Drawing.Point(224, 17);
            this.btnDetectar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetectar.Name = "btnDetectar";
            this.btnDetectar.Size = new System.Drawing.Size(40, 35);
            this.btnDetectar.TabIndex = 2;
            this.btnDetectar.UseVisualStyleBackColor = false;
            this.btnDetectar.Click += new System.EventHandler(this.btnDetectar_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic.Location = new System.Drawing.Point(9, 10);
            this.pic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(522, 323);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.BackColor = System.Drawing.Color.Transparent;
            this.LbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbNombre.Location = new System.Drawing.Point(152, 344);
            this.LbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(17, 18);
            this.LbNombre.TabIndex = 4;
            this.LbNombre.Text = "a";
            this.LbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbClases
            // 
            this.CbClases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbClases.FormattingEnabled = true;
            this.CbClases.Items.AddRange(new object[] {
            "Diseño Centrado al Usuario",
            "Cálculo Integral",
            "Programación 2",
            "Física I",
            "Laboratorio de Física I",
            "Inglés 10-12"});
            this.CbClases.Location = new System.Drawing.Point(11, 22);
            this.CbClases.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbClases.Name = "CbClases";
            this.CbClases.Size = new System.Drawing.Size(188, 21);
            this.CbClases.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(400, 487);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 29);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btAsistencia
            // 
            this.btAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.btAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("btAsistencia.Image")));
            this.btAsistencia.Location = new System.Drawing.Point(224, 11);
            this.btAsistencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAsistencia.Name = "btAsistencia";
            this.btAsistencia.Size = new System.Drawing.Size(40, 39);
            this.btAsistencia.TabIndex = 8;
            this.btAsistencia.UseVisualStyleBackColor = false;
            this.btAsistencia.Click += new System.EventHandler(this.btAsistencia_Click);
            // 
            // GBoxCamara
            // 
            this.GBoxCamara.Controls.Add(this.cboCamara);
            this.GBoxCamara.Controls.Add(this.btnDetectar);
            this.GBoxCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBoxCamara.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GBoxCamara.Location = new System.Drawing.Point(14, 378);
            this.GBoxCamara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBoxCamara.Name = "GBoxCamara";
            this.GBoxCamara.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBoxCamara.Size = new System.Drawing.Size(290, 63);
            this.GBoxCamara.TabIndex = 9;
            this.GBoxCamara.TabStop = false;
            this.GBoxCamara.Text = "Cámara";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbClases);
            this.groupBox1.Controls.Add(this.btAsistencia);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(14, 457);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(290, 58);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validación";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.AliceBlue;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(335, 378);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(195, 97);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 11;
            this.logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(539, 526);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBoxCamara);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.pic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasador de Lista";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.GBoxCamara.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCamara;
        private System.Windows.Forms.Button btnDetectar;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.ComboBox CbClases;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btAsistencia;
        private System.Windows.Forms.GroupBox GBoxCamara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox logo;
    }
}

