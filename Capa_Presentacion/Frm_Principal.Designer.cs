namespace Capa_Presentacion
{
    partial class Frm_Principal
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
            this.components = new System.ComponentModel.Container();
            this.usuario_nombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDClinicaPetDataSet = new Capa_Presentacion.BDClinicaPetDataSet();
            this.citasTableAdapter = new Capa_Presentacion.BDClinicaPetDataSetTableAdapters.CitasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDClinicaPetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usuario_nombre
            // 
            this.usuario_nombre.AutoSize = true;
            this.usuario_nombre.Location = new System.Drawing.Point(12, 26);
            this.usuario_nombre.Name = "usuario_nombre";
            this.usuario_nombre.Size = new System.Drawing.Size(0, 13);
            this.usuario_nombre.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(140, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(140, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 34);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(140, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 31);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.idMascotaDataGridViewTextBoxColumn,
            this.fechaCitaDataGridViewTextBoxColumn,
            this.motivoDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn,
            this.habilitadoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.citasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(372, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 308);
            this.dataGridView1.TabIndex = 7;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "Id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "Id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // idMascotaDataGridViewTextBoxColumn
            // 
            this.idMascotaDataGridViewTextBoxColumn.DataPropertyName = "Id_Mascota";
            this.idMascotaDataGridViewTextBoxColumn.HeaderText = "Id_Mascota";
            this.idMascotaDataGridViewTextBoxColumn.Name = "idMascotaDataGridViewTextBoxColumn";
            // 
            // fechaCitaDataGridViewTextBoxColumn
            // 
            this.fechaCitaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Cita";
            this.fechaCitaDataGridViewTextBoxColumn.HeaderText = "Fecha_Cita";
            this.fechaCitaDataGridViewTextBoxColumn.Name = "fechaCitaDataGridViewTextBoxColumn";
            // 
            // motivoDataGridViewTextBoxColumn
            // 
            this.motivoDataGridViewTextBoxColumn.DataPropertyName = "Motivo";
            this.motivoDataGridViewTextBoxColumn.HeaderText = "Motivo";
            this.motivoDataGridViewTextBoxColumn.Name = "motivoDataGridViewTextBoxColumn";
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            // 
            // habilitadoDataGridViewCheckBoxColumn
            // 
            this.habilitadoDataGridViewCheckBoxColumn.DataPropertyName = "Habilitado";
            this.habilitadoDataGridViewCheckBoxColumn.HeaderText = "Habilitado";
            this.habilitadoDataGridViewCheckBoxColumn.Name = "habilitadoDataGridViewCheckBoxColumn";
            // 
            // citasBindingSource
            // 
            this.citasBindingSource.DataMember = "Citas";
            this.citasBindingSource.DataSource = this.bDClinicaPetDataSet;
            // 
            // bDClinicaPetDataSet
            // 
            this.bDClinicaPetDataSet.DataSetName = "BDClinicaPetDataSet";
            this.bDClinicaPetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasTableAdapter
            // 
            this.citasTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 302);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usuario_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDClinicaPetDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuario_nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDClinicaPetDataSet bDClinicaPetDataSet;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private BDClinicaPetDataSetTableAdapters.CitasTableAdapter citasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadoDataGridViewCheckBoxColumn;
    }
}

