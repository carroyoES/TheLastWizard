namespace TheLastWizard {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.panelCentral = new System.Windows.Forms.RichTextBox();
            this.botonNorte = new System.Windows.Forms.Button();
            this.botonOeste = new System.Windows.Forms.Button();
            this.botonEste = new System.Windows.Forms.Button();
            this.botonSur = new System.Windows.Forms.Button();
            this.botonLanzarHechizo = new System.Windows.Forms.Button();
            this.textBoxHechizo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelCentral.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCentral.Location = new System.Drawing.Point(282, 12);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(804, 373);
            this.panelCentral.TabIndex = 0;
            this.panelCentral.Text = "";
            // 
            // botonNorte
            // 
            this.botonNorte.Location = new System.Drawing.Point(357, 400);
            this.botonNorte.Name = "botonNorte";
            this.botonNorte.Size = new System.Drawing.Size(75, 23);
            this.botonNorte.TabIndex = 1;
            this.botonNorte.Text = "Norte";
            this.botonNorte.UseVisualStyleBackColor = true;
            this.botonNorte.Click += new System.EventHandler(this.botonNorte_Click);
            // 
            // botonOeste
            // 
            this.botonOeste.Location = new System.Drawing.Point(282, 429);
            this.botonOeste.Name = "botonOeste";
            this.botonOeste.Size = new System.Drawing.Size(75, 23);
            this.botonOeste.TabIndex = 2;
            this.botonOeste.Text = "Oeste";
            this.botonOeste.UseVisualStyleBackColor = true;
            this.botonOeste.Click += new System.EventHandler(this.botonOeste_Click);
            // 
            // botonEste
            // 
            this.botonEste.Location = new System.Drawing.Point(431, 429);
            this.botonEste.Name = "botonEste";
            this.botonEste.Size = new System.Drawing.Size(75, 23);
            this.botonEste.TabIndex = 3;
            this.botonEste.Text = "Este";
            this.botonEste.UseVisualStyleBackColor = true;
            this.botonEste.Click += new System.EventHandler(this.botonEste_Click);
            // 
            // botonSur
            // 
            this.botonSur.Location = new System.Drawing.Point(357, 458);
            this.botonSur.Name = "botonSur";
            this.botonSur.Size = new System.Drawing.Size(75, 23);
            this.botonSur.TabIndex = 4;
            this.botonSur.Text = "Sur";
            this.botonSur.UseVisualStyleBackColor = true;
            this.botonSur.Click += new System.EventHandler(this.botonSur_Click);
            // 
            // botonLanzarHechizo
            // 
            this.botonLanzarHechizo.Location = new System.Drawing.Point(960, 429);
            this.botonLanzarHechizo.Name = "botonLanzarHechizo";
            this.botonLanzarHechizo.Size = new System.Drawing.Size(126, 33);
            this.botonLanzarHechizo.TabIndex = 5;
            this.botonLanzarHechizo.Text = "Lanzar Hechizo";
            this.botonLanzarHechizo.UseVisualStyleBackColor = true;
            this.botonLanzarHechizo.Click += new System.EventHandler(this.botonLanzarHechizo_Click);
            // 
            // textBoxHechizo
            // 
            this.textBoxHechizo.Location = new System.Drawing.Point(725, 442);
            this.textBoxHechizo.Name = "textBoxHechizo";
            this.textBoxHechizo.Size = new System.Drawing.Size(229, 20);
            this.textBoxHechizo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1410, 604);
            this.Controls.Add(this.textBoxHechizo);
            this.Controls.Add(this.botonLanzarHechizo);
            this.Controls.Add(this.botonSur);
            this.Controls.Add(this.botonEste);
            this.Controls.Add(this.botonOeste);
            this.Controls.Add(this.botonNorte);
            this.Controls.Add(this.panelCentral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox panelCentral;
        private System.Windows.Forms.Button botonNorte;
        private System.Windows.Forms.Button botonOeste;
        private System.Windows.Forms.Button botonEste;
        private System.Windows.Forms.Button botonSur;
        private System.Windows.Forms.Button botonLanzarHechizo;
        public System.Windows.Forms.TextBox textBoxHechizo;
    }
}

