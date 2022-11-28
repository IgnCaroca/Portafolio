namespace Portafolio
{
    partial class Admin
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
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnPagArriendos = new System.Windows.Forms.Button();
            this.btnDepas = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnModiArri = new System.Windows.Forms.Button();
            this.BtnAdmArriendos = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnCargosAdicionales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(345, 28);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(172, 55);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPagArriendos
            // 
            this.btnPagArriendos.Location = new System.Drawing.Point(551, 28);
            this.btnPagArriendos.Name = "btnPagArriendos";
            this.btnPagArriendos.Size = new System.Drawing.Size(172, 55);
            this.btnPagArriendos.TabIndex = 1;
            this.btnPagArriendos.Text = "Página de arriendos";
            this.btnPagArriendos.UseVisualStyleBackColor = true;
            this.btnPagArriendos.Click += new System.EventHandler(this.btnPagArriendos_Click);
            // 
            // btnDepas
            // 
            this.btnDepas.Location = new System.Drawing.Point(189, 386);
            this.btnDepas.Name = "btnDepas";
            this.btnDepas.Size = new System.Drawing.Size(198, 123);
            this.btnDepas.TabIndex = 2;
            this.btnDepas.Text = "Departamentos";
            this.btnDepas.UseVisualStyleBackColor = true;
            // 
            // BtnClientes
            // 
            this.BtnClientes.Location = new System.Drawing.Point(427, 184);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(198, 123);
            this.BtnClientes.TabIndex = 3;
            this.BtnClientes.Text = "Usuarios";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnModiArri
            // 
            this.BtnModiArri.Location = new System.Drawing.Point(189, 184);
            this.BtnModiArri.Name = "BtnModiArri";
            this.BtnModiArri.Size = new System.Drawing.Size(198, 123);
            this.BtnModiArri.TabIndex = 4;
            this.BtnModiArri.Text = "Modificar departamentos";
            this.BtnModiArri.UseVisualStyleBackColor = true;
            this.BtnModiArri.Click += new System.EventHandler(this.BtnModiArri_Click);
            // 
            // BtnAdmArriendos
            // 
            this.BtnAdmArriendos.Location = new System.Drawing.Point(681, 184);
            this.BtnAdmArriendos.Name = "BtnAdmArriendos";
            this.BtnAdmArriendos.Size = new System.Drawing.Size(198, 123);
            this.BtnAdmArriendos.TabIndex = 5;
            this.BtnAdmArriendos.Text = "Administrar página de arriendos";
            this.BtnAdmArriendos.UseVisualStyleBackColor = true;
            this.BtnAdmArriendos.Click += new System.EventHandler(this.BtnAdmArriendos_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(681, 386);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(198, 123);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnCargosAdicionales
            // 
            this.btnCargosAdicionales.Location = new System.Drawing.Point(427, 386);
            this.btnCargosAdicionales.Name = "btnCargosAdicionales";
            this.btnCargosAdicionales.Size = new System.Drawing.Size(198, 123);
            this.btnCargosAdicionales.TabIndex = 7;
            this.btnCargosAdicionales.Text = "Cargos adicionales por persona";
            this.btnCargosAdicionales.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Portafolio.Properties.Resources.admin1;
            this.ClientSize = new System.Drawing.Size(964, 571);
            this.Controls.Add(this.btnCargosAdicionales);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.BtnAdmArriendos);
            this.Controls.Add(this.BtnModiArri);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.btnDepas);
            this.Controls.Add(this.btnPagArriendos);
            this.Controls.Add(this.btnInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnPagArriendos;
        private System.Windows.Forms.Button btnDepas;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnModiArri;
        private System.Windows.Forms.Button BtnAdmArriendos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnCargosAdicionales;
    }
}