namespace CV
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "controlli se i record del file sono della stessa dimensione";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(296, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "restituire la dimensione massima dei record presenti nel file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(12, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(356, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "impostare la dimensione di ogni record ad un numero di caratteri a scelta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(12, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(701, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Aggiungere una record, completo delle informazioni per tutti in campi, controllan" +
    "do che la dimensione del record non superi la dimensione massima";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(12, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(259, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Visualizzare tutti i record non cancellati logicamente";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(277, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "cancellare un record a scelta";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(437, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(318, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "scambiare la posizione, nel file, di due record a scelta dell\'utente";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

