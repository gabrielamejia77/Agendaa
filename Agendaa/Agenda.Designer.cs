namespace Agendaa
{
    partial class Agenda
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
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.app = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfdJson = new System.Windows.Forms.SaveFileDialog();
            this.ofdJson = new System.Windows.Forms.OpenFileDialog();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.relleno = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblActualizacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.cargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.app,
            this.apm,
            this.direccion,
            this.tel,
            this.correo});
            this.dgvAgenda.Location = new System.Drawing.Point(12, 12);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.RowHeadersWidth = 51;
            this.dgvAgenda.RowTemplate.Height = 24;
            this.dgvAgenda.Size = new System.Drawing.Size(1053, 237);
            this.dgvAgenda.TabIndex = 0;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nombre";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.Width = 125;
            // 
            // app
            // 
            this.app.HeaderText = "Apellido Paterno";
            this.app.MinimumWidth = 6;
            this.app.Name = "app";
            this.app.Width = 125;
            // 
            // apm
            // 
            this.apm.HeaderText = "Apellido Materno";
            this.apm.MinimumWidth = 6;
            this.apm.Name = "apm";
            this.apm.Width = 125;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.Width = 125;
            // 
            // tel
            // 
            this.tel.HeaderText = "Telefono";
            this.tel.MinimumWidth = 6;
            this.tel.Name = "tel";
            this.tel.Width = 125;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.Width = 125;
            // 
            // sfdJson
            // 
            this.sfdJson.Filter = "Archivo Json|*.json";
            // 
            // ofdJson
            // 
            this.ofdJson.Filter = "Archivo Json|*.json";
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRegistros,
            this.relleno,
            this.lblActualizacion});
            this.status.Location = new System.Drawing.Point(0, 416);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1136, 34);
            this.status.TabIndex = 1;
            this.status.Text = "statuus";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(101, 28);
            this.lblRegistros.Text = "Registros: ";
            // 
            // relleno
            // 
            this.relleno.Name = "relleno";
            this.relleno.Size = new System.Drawing.Size(433, 28);
            this.relleno.Text = "                                                                                 " +
    "                         ";
            // 
            // lblActualizacion
            // 
            this.lblActualizacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizacion.Name = "lblActualizacion";
            this.lblActualizacion.Size = new System.Drawing.Size(200, 28);
            this.lblActualizacion.Text = "Ultima Actualizacion: ";
            // 
            // cargar
            // 
            this.cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargar.Location = new System.Drawing.Point(663, 303);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(107, 38);
            this.cargar.TabIndex = 2;
            this.cargar.Text = "Cargar";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1136, 450);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.status);
            this.Controls.Add(this.dgvAgenda);
            this.Name = "Agenda";
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn app;
        private System.Windows.Forms.DataGridViewTextBoxColumn apm;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.SaveFileDialog sfdJson;
        private System.Windows.Forms.OpenFileDialog ofdJson;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistros;
        private System.Windows.Forms.ToolStripStatusLabel relleno;
        private System.Windows.Forms.ToolStripStatusLabel lblActualizacion;
        private System.Windows.Forms.Button cargar;
    }
}

