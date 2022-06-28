namespace Presentacion.Vistas
{
    partial class Contador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTituloListado = new System.Windows.Forms.Label();
            this.dgvContadores = new System.Windows.Forms.DataGridView();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cboContadores = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.lblListadoEmpleados = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 344);
            this.panel1.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(12, 115);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 26);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(12, 77);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 26);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(12, 37);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 25);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTituloListado
            // 
            this.lblTituloListado.AutoSize = true;
            this.lblTituloListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTituloListado.Location = new System.Drawing.Point(122, 19);
            this.lblTituloListado.Name = "lblTituloListado";
            this.lblTituloListado.Size = new System.Drawing.Size(170, 20);
            this.lblTituloListado.TabIndex = 3;
            this.lblTituloListado.Text = "Listado de Contadores";
            // 
            // dgvContadores
            // 
            this.dgvContadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContadores.Location = new System.Drawing.Point(126, 125);
            this.dgvContadores.Name = "dgvContadores";
            this.dgvContadores.RowHeadersVisible = false;
            this.dgvContadores.Size = new System.Drawing.Size(313, 154);
            this.dgvContadores.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescripcion.Location = new System.Drawing.Point(122, 92);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(26, 20);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "I...";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFiltrar.Location = new System.Drawing.Point(122, 57);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(59, 20);
            this.lblFiltrar.TabIndex = 7;
            this.lblFiltrar.Text = "Buscar";
            // 
            // cboContadores
            // 
            this.cboContadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboContadores.FormattingEnabled = true;
            this.cboContadores.Location = new System.Drawing.Point(187, 53);
            this.cboContadores.Name = "cboContadores";
            this.cboContadores.Size = new System.Drawing.Size(160, 24);
            this.cboContadores.TabIndex = 8;
            this.cboContadores.SelectedIndexChanged += new System.EventHandler(this.cboContadores_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(240, 89);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(199, 26);
            this.txtDescripcion.TabIndex = 9;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArea.Location = new System.Drawing.Point(122, 19);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(43, 20);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Area";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPuesto.Location = new System.Drawing.Point(122, 72);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(59, 20);
            this.lblPuesto.TabIndex = 11;
            this.lblPuesto.Text = "Puesto";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(126, 42);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(313, 26);
            this.txtArea.TabIndex = 12;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuesto.Location = new System.Drawing.Point(126, 95);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(313, 26);
            this.txtPuesto.TabIndex = 13;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(126, 148);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(313, 153);
            this.dgvEmpleados.TabIndex = 14;
            // 
            // lblListadoEmpleados
            // 
            this.lblListadoEmpleados.AutoSize = true;
            this.lblListadoEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblListadoEmpleados.Location = new System.Drawing.Point(122, 125);
            this.lblListadoEmpleados.Name = "lblListadoEmpleados";
            this.lblListadoEmpleados.Size = new System.Drawing.Size(167, 20);
            this.lblListadoEmpleados.TabIndex = 15;
            this.lblListadoEmpleados.Text = "Listado de Empleados";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(126, 307);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 25);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(218, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 25);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Contador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(460, 344);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblListadoEmpleados);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cboContadores);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dgvContadores);
            this.Controls.Add(this.lblTituloListado);
            this.Controls.Add(this.panel1);
            this.Name = "Contador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador";
            this.Load += new System.EventHandler(this.Contador_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Label lblTituloListado;
        public System.Windows.Forms.Label lblDescripcion;
        public System.Windows.Forms.Label lblFiltrar;
        public System.Windows.Forms.ComboBox cboContadores;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.Label lblArea;
        public System.Windows.Forms.Label lblPuesto;
        public System.Windows.Forms.Label lblListadoEmpleados;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtArea;
        public System.Windows.Forms.TextBox txtPuesto;
        public System.Windows.Forms.DataGridView dgvContadores;
        public System.Windows.Forms.DataGridView dgvEmpleados;
    }
}