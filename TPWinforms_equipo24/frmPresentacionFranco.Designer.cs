namespace TPWinforms_equipo24
{
    partial class frmPresentacionFranco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresentacionFranco));
            this.rtbFranco = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnvolverPresentacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbFranco
            // 
            this.rtbFranco.AccessibleName = "";
            this.rtbFranco.Location = new System.Drawing.Point(12, 29);
            this.rtbFranco.Name = "rtbFranco";
            this.rtbFranco.Size = new System.Drawing.Size(429, 117);
            this.rtbFranco.TabIndex = 0;
            this.rtbFranco.Text = resources.GetString("rtbFranco.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnvolverPresentacion
            // 
            this.btnvolverPresentacion.Location = new System.Drawing.Point(366, 270);
            this.btnvolverPresentacion.Name = "btnvolverPresentacion";
            this.btnvolverPresentacion.Size = new System.Drawing.Size(75, 23);
            this.btnvolverPresentacion.TabIndex = 2;
            this.btnvolverPresentacion.Text = "Volver";
            this.btnvolverPresentacion.UseVisualStyleBackColor = true;
            this.btnvolverPresentacion.Click += new System.EventHandler(this.btnvolverPresentacion_Click);
            // 
            // frmPresentacionFranco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 317);
            this.Controls.Add(this.btnvolverPresentacion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rtbFranco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPresentacionFranco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentacion Franco Danelon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFranco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnvolverPresentacion;
    }
}