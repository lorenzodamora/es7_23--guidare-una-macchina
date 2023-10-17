namespace es7_17_10_23
{
	partial class Es7
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
			if(disposing && (components != null))
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
			this.btn_avanza = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_avanza
			// 
			this.btn_avanza.Location = new System.Drawing.Point(315, 115);
			this.btn_avanza.Name = "button1";
			this.btn_avanza.Size = new System.Drawing.Size(188, 23);
			this.btn_avanza.TabIndex = 0;
			this.btn_avanza.Text = "avanza (tempo++)";
			this.btn_avanza.UseVisualStyleBackColor = true;
			this.btn_avanza.Click += new System.EventHandler(this.Avanza_click);
			// 
			// Es7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 461);
			this.Controls.Add(this.btn_avanza);
			this.Name = "Es7";
			this.Text = "Guida";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_avanza;
	}
}
