namespace WindowsFormsAppTheatherAsk
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRifiuta = new System.Windows.Forms.Button();
            this.buttonAccetta = new System.Windows.Forms.Button();
            this.listBoxDomande = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRifiuta
            // 
            this.buttonRifiuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRifiuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRifiuta.Location = new System.Drawing.Point(12, 217);
            this.buttonRifiuta.Name = "buttonRifiuta";
            this.buttonRifiuta.Size = new System.Drawing.Size(177, 23);
            this.buttonRifiuta.TabIndex = 0;
            this.buttonRifiuta.Text = "Rifiuta";
            this.buttonRifiuta.UseVisualStyleBackColor = false;
            this.buttonRifiuta.Click += new System.EventHandler(this.buttonRifiuta_Click);
            // 
            // buttonAccetta
            // 
            this.buttonAccetta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAccetta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccetta.Location = new System.Drawing.Point(195, 217);
            this.buttonAccetta.Name = "buttonAccetta";
            this.buttonAccetta.Size = new System.Drawing.Size(316, 23);
            this.buttonAccetta.TabIndex = 1;
            this.buttonAccetta.Text = "Accetta";
            this.buttonAccetta.UseVisualStyleBackColor = false;
            this.buttonAccetta.Click += new System.EventHandler(this.buttonAccetta_Click);
            // 
            // listBoxDomande
            // 
            this.listBoxDomande.FormattingEnabled = true;
            this.listBoxDomande.Location = new System.Drawing.Point(12, 25);
            this.listBoxDomande.Name = "listBoxDomande";
            this.listBoxDomande.Size = new System.Drawing.Size(499, 186);
            this.listBoxDomande.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleziona una domanda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDomande);
            this.Controls.Add(this.buttonAccetta);
            this.Controls.Add(this.buttonRifiuta);
            this.Name = "Form1";
            this.Text = "TSE Gestore Domande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRifiuta;
        private System.Windows.Forms.Button buttonAccetta;
        private System.Windows.Forms.ListBox listBoxDomande;
        private System.Windows.Forms.Label label1;
    }
}

