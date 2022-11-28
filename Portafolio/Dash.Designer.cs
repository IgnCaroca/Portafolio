namespace Portafolio
{
    partial class Dash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dash));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.departamentosTotalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolfkyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arriendosBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arriendosBLLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosTotalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolfkyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arriendosBLLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arriendosBLLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblClientes);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(697, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 58);
            this.panel3.TabIndex = 9;
            // 
            // lblClientes
            // 
            this.lblClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(63, 33);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(19, 13);
            this.lblClientes.TabIndex = 8;
            this.lblClientes.Text = "30";
            this.lblClientes.Click += new System.EventHandler(this.lblClientes_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Clientes";
            // 
            // departamentosTotalesBindingSource
            // 
            this.departamentosTotalesBindingSource.DataSource = typeof(PortafolioBLL.DashboardBLL.DepartamentosTotales);
            // 
            // rolfkyBindingSource
            // 
            this.rolfkyBindingSource.DataSource = typeof(Comun.Cache.Rol_fky);
            // 
            // arriendosBLLBindingSource
            // 
            this.arriendosBLLBindingSource.DataSource = typeof(PortafolioBLL.ArriendosBLL);
            // 
            // arriendosBLLBindingSource1
            // 
            this.arriendosBLLBindingSource1.DataSource = typeof(PortafolioBLL.ArriendosBLL);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Portafolio.Properties.Resources.Ganancias_Temporadas_altas__1_;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 392);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(802, 309);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 713);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(845, 713);
            this.Name = "Dash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dash_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosTotalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolfkyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arriendosBLLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arriendosBLLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource arriendosBLLBindingSource;
        private System.Windows.Forms.BindingSource rolfkyBindingSource;
        private System.Windows.Forms.BindingSource arriendosBLLBindingSource1;
        private System.Windows.Forms.BindingSource departamentosTotalesBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}