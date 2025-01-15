namespace winform_app
{
    partial class frmPokemonesInactivos
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
            this.dgwInactivos = new System.Windows.Forms.DataGridView();
            this.pbxInactivos = new System.Windows.Forms.PictureBox();
            this.btnReactivar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnBuscarAvanzado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblNumerico = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.btnEliminarDefinitivamente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwInactivos
            // 
            this.dgwInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInactivos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwInactivos.Location = new System.Drawing.Point(23, 44);
            this.dgwInactivos.Name = "dgwInactivos";
            this.dgwInactivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwInactivos.Size = new System.Drawing.Size(577, 303);
            this.dgwInactivos.TabIndex = 0;
            this.dgwInactivos.SelectionChanged += new System.EventHandler(this.dgwInactivos_SelectionChanged);
            // 
            // pbxInactivos
            // 
            this.pbxInactivos.Location = new System.Drawing.Point(609, 44);
            this.pbxInactivos.Name = "pbxInactivos";
            this.pbxInactivos.Size = new System.Drawing.Size(271, 303);
            this.pbxInactivos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxInactivos.TabIndex = 1;
            this.pbxInactivos.TabStop = false;
            // 
            // btnReactivar
            // 
            this.btnReactivar.Location = new System.Drawing.Point(3, 406);
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Size = new System.Drawing.Size(75, 23);
            this.btnReactivar.TabIndex = 2;
            this.btnReactivar.Text = "Reactivar";
            this.btnReactivar.UseVisualStyleBackColor = true;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(23, 18);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(140, 20);
            this.txtFiltro.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(185, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(208, 406);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 5;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(406, 408);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 6;
            this.cboCriterio.SelectedIndexChanged += new System.EventHandler(this.cboCriterio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Campo";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(592, 406);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(157, 20);
            this.txtFiltroAvanzado.TabIndex = 9;
            this.txtFiltroAvanzado.TextChanged += new System.EventHandler(this.txtFiltroAvanzado_TextChanged_1);
            // 
            // btnBuscarAvanzado
            // 
            this.btnBuscarAvanzado.Location = new System.Drawing.Point(796, 406);
            this.btnBuscarAvanzado.Name = "btnBuscarAvanzado";
            this.btnBuscarAvanzado.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAvanzado.TabIndex = 10;
            this.btnBuscarAvanzado.Text = "Buscar";
            this.btnBuscarAvanzado.UseVisualStyleBackColor = true;
            this.btnBuscarAvanzado.Click += new System.EventHandler(this.btnBuscarAvanzado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Criterio";
            // 
            // lblCriterio
            // 
            this.lblCriterio.Location = new System.Drawing.Point(0, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(100, 23);
            this.lblCriterio.TabIndex = 19;
            // 
            // lblNumerico
            // 
            this.lblNumerico.Location = new System.Drawing.Point(0, 0);
            this.lblNumerico.Name = "lblNumerico";
            this.lblNumerico.Size = new System.Drawing.Size(100, 23);
            this.lblNumerico.TabIndex = 18;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.ForeColor = System.Drawing.Color.Red;
            this.lblCampo.Location = new System.Drawing.Point(208, 373);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(180, 20);
            this.lblCampo.TabIndex = 15;
            this.lblCampo.Text = "Seleccione un campo";
            // 
            // labelCriterio
            // 
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCriterio.ForeColor = System.Drawing.Color.Red;
            this.labelCriterio.Location = new System.Drawing.Point(402, 373);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(0, 20);
            this.labelCriterio.TabIndex = 16;
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltro.ForeColor = System.Drawing.Color.Red;
            this.labelFiltro.Location = new System.Drawing.Point(590, 373);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(0, 20);
            this.labelFiltro.TabIndex = 17;
            // 
            // btnEliminarDefinitivamente
            // 
            this.btnEliminarDefinitivamente.Location = new System.Drawing.Point(3, 373);
            this.btnEliminarDefinitivamente.Name = "btnEliminarDefinitivamente";
            this.btnEliminarDefinitivamente.Size = new System.Drawing.Size(174, 23);
            this.btnEliminarDefinitivamente.TabIndex = 20;
            this.btnEliminarDefinitivamente.Text = "Eliminar Definitivamente";
            this.btnEliminarDefinitivamente.UseVisualStyleBackColor = true;
            this.btnEliminarDefinitivamente.Click += new System.EventHandler(this.btnEliminarDefinitivamente_Click);
            // 
            // frmPokemonesInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 456);
            this.Controls.Add(this.btnEliminarDefinitivamente);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.lblNumerico);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarAvanzado);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnReactivar);
            this.Controls.Add(this.pbxInactivos);
            this.Controls.Add(this.dgwInactivos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(942, 495);
            this.MinimumSize = new System.Drawing.Size(942, 495);
            this.Name = "frmPokemonesInactivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemones Inactivos";
            this.Load += new System.EventHandler(this.frmPokemonesInactivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInactivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwInactivos;
        private System.Windows.Forms.PictureBox pbxInactivos;
        private System.Windows.Forms.Button btnReactivar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button btnBuscarAvanzado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblNumerico;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Button btnEliminarDefinitivamente;
    }
}