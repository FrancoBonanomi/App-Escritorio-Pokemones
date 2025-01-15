namespace winform_app
{
    partial class frmPokemonesActivos
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
            this.dgwPokemons = new System.Windows.Forms.DataGridView();
            this.pbxImagenPokemon = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.btnInactivos = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarAvanzado = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblNumerico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPokemons
            // 
            this.dgwPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwPokemons.Location = new System.Drawing.Point(41, 37);
            this.dgwPokemons.MultiSelect = false;
            this.dgwPokemons.Name = "dgwPokemons";
            this.dgwPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPokemons.Size = new System.Drawing.Size(636, 314);
            this.dgwPokemons.TabIndex = 0;
            this.dgwPokemons.SelectionChanged += new System.EventHandler(this.dgwPokemons_SelectionChanged);
            // 
            // pbxImagenPokemon
            // 
            this.pbxImagenPokemon.Location = new System.Drawing.Point(717, 37);
            this.pbxImagenPokemon.Name = "pbxImagenPokemon";
            this.pbxImagenPokemon.Size = new System.Drawing.Size(417, 314);
            this.pbxImagenPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenPokemon.TabIndex = 1;
            this.pbxImagenPokemon.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(41, 402);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(153, 401);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(264, 400);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.Location = new System.Drawing.Point(381, 402);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(158, 23);
            this.btnEliminarLogico.TabIndex = 5;
            this.btnEliminarLogico.Text = "Eliminar Logico";
            this.btnEliminarLogico.UseVisualStyleBackColor = true;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // btnInactivos
            // 
            this.btnInactivos.Location = new System.Drawing.Point(904, 401);
            this.btnInactivos.Name = "btnInactivos";
            this.btnInactivos.Size = new System.Drawing.Size(196, 23);
            this.btnInactivos.TabIndex = 6;
            this.btnInactivos.Text = "Ver inactivos";
            this.btnInactivos.UseVisualStyleBackColor = true;
            this.btnInactivos.Click += new System.EventHandler(this.btnInactivos_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(136, 14);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(223, 20);
            this.txtFiltro.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(365, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(107, 492);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 10;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Campo (*):";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(381, 492);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 12;
            this.cboCriterio.SelectedIndexChanged += new System.EventHandler(this.cboCriterio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Criterio (*)";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(623, 491);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(202, 20);
            this.txtFiltroAvanzado.TabIndex = 14;
            this.txtFiltroAvanzado.TextChanged += new System.EventHandler(this.txtFiltroAvanzado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Filtrar:";
            // 
            // btnBuscarAvanzado
            // 
            this.btnBuscarAvanzado.Location = new System.Drawing.Point(877, 492);
            this.btnBuscarAvanzado.Name = "btnBuscarAvanzado";
            this.btnBuscarAvanzado.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAvanzado.TabIndex = 16;
            this.btnBuscarAvanzado.Text = "Buscar";
            this.btnBuscarAvanzado.UseVisualStyleBackColor = true;
            this.btnBuscarAvanzado.Click += new System.EventHandler(this.btnBuscarAvanzado_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.ForeColor = System.Drawing.Color.Red;
            this.lblCampo.Location = new System.Drawing.Point(37, 520);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(180, 20);
            this.lblCampo.TabIndex = 17;
            this.lblCampo.Text = "Seleccione un campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.ForeColor = System.Drawing.Color.Red;
            this.lblCriterio.Location = new System.Drawing.Point(349, 520);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(0, 20);
            this.lblCriterio.TabIndex = 19;
            // 
            // lblNumerico
            // 
            this.lblNumerico.AutoSize = true;
            this.lblNumerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumerico.ForeColor = System.Drawing.Color.Red;
            this.lblNumerico.Location = new System.Drawing.Point(598, 520);
            this.lblNumerico.Name = "lblNumerico";
            this.lblNumerico.Size = new System.Drawing.Size(0, 20);
            this.lblNumerico.TabIndex = 20;
            // 
            // frmPokemonesActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 549);
            this.Controls.Add(this.lblNumerico);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnBuscarAvanzado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnInactivos);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxImagenPokemon);
            this.Controls.Add(this.dgwPokemons);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1224, 588);
            this.MinimumSize = new System.Drawing.Size(1224, 588);
            this.Name = "frmPokemonesActivos";
            this.Text = "Pokemones Activos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPokemons;
        private System.Windows.Forms.PictureBox pbxImagenPokemon;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Button btnInactivos;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarAvanzado;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblNumerico;
    }
}

