﻿namespace TPWinforms_equipo24
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
            this.btnCargarImagenes = new System.Windows.Forms.Button();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.vivap = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.nudImagenes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(216, 89);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(117, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(216, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(216, 172);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(117, 20);
            this.txtURL.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(216, 198);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(117, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(161, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(142, 92);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(155, 148);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(165, 175);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(45, 13);
            this.lblImagen.TabIndex = 12;
            this.lblImagen.Text = "Imagen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(170, 201);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(82, 321);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(203, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(216, 145);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(117, 21);
            this.cboCategoria.TabIndex = 17;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(165, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(216, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(117, 20);
            this.txtCodigo.TabIndex = 19;
            // 
            // btnCargarImagenes
            // 
            this.btnCargarImagenes.Location = new System.Drawing.Point(227, 259);
            this.btnCargarImagenes.Name = "btnCargarImagenes";
            this.btnCargarImagenes.Size = new System.Drawing.Size(97, 23);
            this.btnCargarImagenes.TabIndex = 21;
            this.btnCargarImagenes.Text = "Cargar Imagenes";
            this.btnCargarImagenes.UseVisualStyleBackColor = true;
            
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(216, 118);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(117, 21);
            this.cboMarca.TabIndex = 22;
            // 
            // vivap
            // 
            this.vivap.AutoSize = true;
            this.vivap.Location = new System.Drawing.Point(168, 121);
            this.vivap.Name = "vivap";
            this.vivap.Size = new System.Drawing.Size(40, 13);
            this.vivap.TabIndex = 23;
            this.vivap.Text = "Marca:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(53, 235);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(157, 13);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Cantidad de imagenes a cargar:\r\n";
            // 
            // nudImagenes
            // 
            this.nudImagenes.Location = new System.Drawing.Point(218, 233);
            this.nudImagenes.Name = "nudImagenes";
            this.nudImagenes.Size = new System.Drawing.Size(115, 20);
            this.nudImagenes.TabIndex = 20;
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 390);
            this.Controls.Add(this.vivap);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.btnCargarImagenes);
            this.Controls.Add(this.nudImagenes);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "frmAgregarArticulo";
            this.Text = "AgregarArticulo";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudImagenes)).EndInit();
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
        private System.Windows.Forms.Button btnCargarImagenes;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label vivap;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.NumericUpDown nudImagenes;
    }
}