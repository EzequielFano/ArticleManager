namespace TPWinforms_equipo24
{
    partial class frmAgregarArticulo
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.pbxArticuloCarga = new System.Windows.Forms.PictureBox();
            this.lblObliCodigo = new System.Windows.Forms.Label();
            this.lblObliNombre = new System.Windows.Forms.Label();
            this.lblObliDescr = new System.Windows.Forms.Label();
            this.lblObliMarca = new System.Windows.Forms.Label();
            this.lblObliCate = new System.Windows.Forms.Label();
            this.lblObliPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(154, 122);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(117, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(154, 205);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(117, 20);
            this.txtURL.TabIndex = 5;
            this.txtURL.Leave += new System.EventHandler(this.txtURL_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(154, 231);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(117, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(99, 99);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(80, 125);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(93, 181);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(103, 208);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(45, 13);
            this.lblImagen.TabIndex = 12;
            this.lblImagen.Text = "Imagen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(108, 234);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(71, 307);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(192, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(154, 178);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(117, 21);
            this.cboCategoria.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(103, 70);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(154, 67);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(117, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(154, 151);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(117, 21);
            this.cboMarca.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(106, 154);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 23;
            this.lblMarca.Text = "Marca:";
            // 
            // pbxArticuloCarga
            // 
            this.pbxArticuloCarga.Location = new System.Drawing.Point(294, 67);
            this.pbxArticuloCarga.Name = "pbxArticuloCarga";
            this.pbxArticuloCarga.Size = new System.Drawing.Size(226, 184);
            this.pbxArticuloCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticuloCarga.TabIndex = 24;
            this.pbxArticuloCarga.TabStop = false;
            // 
            // lblObliCodigo
            // 
            this.lblObliCodigo.AutoSize = true;
            this.lblObliCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblObliCodigo.Location = new System.Drawing.Point(95, 73);
            this.lblObliCodigo.Name = "lblObliCodigo";
            this.lblObliCodigo.Size = new System.Drawing.Size(11, 13);
            this.lblObliCodigo.TabIndex = 25;
            this.lblObliCodigo.Text = "*";
            // 
            // lblObliNombre
            // 
            this.lblObliNombre.AutoSize = true;
            this.lblObliNombre.ForeColor = System.Drawing.Color.Red;
            this.lblObliNombre.Location = new System.Drawing.Point(91, 102);
            this.lblObliNombre.Name = "lblObliNombre";
            this.lblObliNombre.Size = new System.Drawing.Size(11, 13);
            this.lblObliNombre.TabIndex = 26;
            this.lblObliNombre.Text = "*";
            // 
            // lblObliDescr
            // 
            this.lblObliDescr.AutoSize = true;
            this.lblObliDescr.ForeColor = System.Drawing.Color.Red;
            this.lblObliDescr.Location = new System.Drawing.Point(73, 128);
            this.lblObliDescr.Name = "lblObliDescr";
            this.lblObliDescr.Size = new System.Drawing.Size(11, 13);
            this.lblObliDescr.TabIndex = 27;
            this.lblObliDescr.Text = "*";
            // 
            // lblObliMarca
            // 
            this.lblObliMarca.AutoSize = true;
            this.lblObliMarca.ForeColor = System.Drawing.Color.Red;
            this.lblObliMarca.Location = new System.Drawing.Point(98, 157);
            this.lblObliMarca.Name = "lblObliMarca";
            this.lblObliMarca.Size = new System.Drawing.Size(11, 13);
            this.lblObliMarca.TabIndex = 28;
            this.lblObliMarca.Text = "*";
            // 
            // lblObliCate
            // 
            this.lblObliCate.AutoSize = true;
            this.lblObliCate.ForeColor = System.Drawing.Color.Red;
            this.lblObliCate.Location = new System.Drawing.Point(85, 184);
            this.lblObliCate.Name = "lblObliCate";
            this.lblObliCate.Size = new System.Drawing.Size(11, 13);
            this.lblObliCate.TabIndex = 29;
            this.lblObliCate.Text = "*";
            // 
            // lblObliPrecio
            // 
            this.lblObliPrecio.AutoSize = true;
            this.lblObliPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblObliPrecio.Location = new System.Drawing.Point(100, 237);
            this.lblObliPrecio.Name = "lblObliPrecio";
            this.lblObliPrecio.Size = new System.Drawing.Size(11, 13);
            this.lblObliPrecio.TabIndex = 30;
            this.lblObliPrecio.Text = "*";
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 390);
            this.Controls.Add(this.lblObliPrecio);
            this.Controls.Add(this.lblObliCate);
            this.Controls.Add(this.lblObliMarca);
            this.Controls.Add(this.lblObliDescr);
            this.Controls.Add(this.lblObliNombre);
            this.Controls.Add(this.lblObliCodigo);
            this.Controls.Add(this.pbxArticuloCarga);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "frmAgregarArticulo";
            this.Text = "AgregarArticulo";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloCarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.PictureBox pbxArticuloCarga;
        private System.Windows.Forms.Label lblObliCodigo;
        private System.Windows.Forms.Label lblObliNombre;
        private System.Windows.Forms.Label lblObliDescr;
        private System.Windows.Forms.Label lblObliMarca;
        private System.Windows.Forms.Label lblObliCate;
        private System.Windows.Forms.Label lblObliPrecio;
    }
}