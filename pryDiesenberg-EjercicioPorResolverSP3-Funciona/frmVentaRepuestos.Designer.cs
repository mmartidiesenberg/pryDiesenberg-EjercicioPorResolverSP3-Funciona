namespace pryDiesenberg_EjercicioPorResolverSP3_Funciona
{
    partial class frmVentaRepuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentaRepuestos));
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.btnImportado = new System.Windows.Forms.RadioButton();
            this.btnNacional = new System.Windows.Forms.RadioButton();
            this.mskNumero = new System.Windows.Forms.MaskedTextBox();
            this.mskPrecio = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcionRep = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.cmbMarca);
            this.grpDatos.Controls.Add(this.btnImportado);
            this.grpDatos.Controls.Add(this.btnNacional);
            this.grpDatos.Controls.Add(this.mskNumero);
            this.grpDatos.Controls.Add(this.mskPrecio);
            this.grpDatos.Controls.Add(this.lblPrecio);
            this.grpDatos.Controls.Add(this.lblOrigen);
            this.grpDatos.Controls.Add(this.lblNumero);
            this.grpDatos.Controls.Add(this.lblMarca);
            this.grpDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(20, 19);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDatos.Size = new System.Drawing.Size(248, 201);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos de los Repuestos";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "P (Peugeot)",
            "F (Fiat)",
            "R (Renault)"});
            this.cmbMarca.Location = new System.Drawing.Point(129, 21);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(86, 24);
            this.cmbMarca.TabIndex = 8;
            // 
            // btnImportado
            // 
            this.btnImportado.AutoSize = true;
            this.btnImportado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportado.Location = new System.Drawing.Point(129, 136);
            this.btnImportado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImportado.Name = "btnImportado";
            this.btnImportado.Size = new System.Drawing.Size(89, 21);
            this.btnImportado.TabIndex = 7;
            this.btnImportado.TabStop = true;
            this.btnImportado.Text = "Importado";
            this.btnImportado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImportado.UseVisualStyleBackColor = true;
            // 
            // btnNacional
            // 
            this.btnNacional.AutoSize = true;
            this.btnNacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNacional.Location = new System.Drawing.Point(129, 102);
            this.btnNacional.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNacional.Name = "btnNacional";
            this.btnNacional.Size = new System.Drawing.Size(81, 21);
            this.btnNacional.TabIndex = 6;
            this.btnNacional.TabStop = true;
            this.btnNacional.Text = "Nacional";
            this.btnNacional.UseVisualStyleBackColor = true;
            // 
            // mskNumero
            // 
            this.mskNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNumero.Location = new System.Drawing.Point(129, 66);
            this.mskNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskNumero.Mask = "999999";
            this.mskNumero.Name = "mskNumero";
            this.mskNumero.Size = new System.Drawing.Size(86, 23);
            this.mskNumero.TabIndex = 5;
            this.mskNumero.ValidatingType = typeof(int);
            // 
            // mskPrecio
            // 
            this.mskPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPrecio.Location = new System.Drawing.Point(129, 172);
            this.mskPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskPrecio.Mask = "99999";
            this.mskPrecio.Name = "mskPrecio";
            this.mskPrecio.Size = new System.Drawing.Size(86, 23);
            this.mskPrecio.TabIndex = 4;
            this.mskPrecio.ValidatingType = typeof(int);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(10, 172);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(54, 17);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(10, 120);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(57, 17);
            this.lblOrigen.TabIndex = 2;
            this.lblOrigen.Text = "Origen";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(10, 66);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(64, 17);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(10, 25);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 17);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(298, 19);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(194, 17);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción del Repuesto";
            // 
            // txtDescripcionRep
            // 
            this.txtDescripcionRep.Location = new System.Drawing.Point(300, 41);
            this.txtDescripcionRep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcionRep.MaxLength = 50;
            this.txtDescripcionRep.Name = "txtDescripcionRep";
            this.txtDescripcionRep.Size = new System.Drawing.Size(250, 181);
            this.txtDescripcionRep.TabIndex = 9;
            this.txtDescripcionRep.Text = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(207, 223);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 26);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(300, 223);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(60, 26);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(207, 280);
            this.lstDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(156, 69);
            this.lstDatos.TabIndex = 12;
            // 
            // frmVentaRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(566, 358);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcionRep);
            this.Controls.Add(this.grpDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVentaRepuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta de Repuestos";
            this.Load += new System.EventHandler(this.frmVentaRepuestos_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.RadioButton btnImportado;
        private System.Windows.Forms.RadioButton btnNacional;
        private System.Windows.Forms.MaskedTextBox mskNumero;
        private System.Windows.Forms.MaskedTextBox mskPrecio;
        private System.Windows.Forms.RichTextBox txtDescripcionRep;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox lstDatos;
    }
}

