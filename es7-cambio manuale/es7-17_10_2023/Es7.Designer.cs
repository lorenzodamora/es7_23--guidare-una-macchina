namespace es7_17_10_23
{
	partial class InternoAuto
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
			System.Windows.Forms.ColumnHeader header_risultato;
			this.btn_accelera = new System.Windows.Forms.Button();
			this.btn_on = new System.Windows.Forms.Button();
			this.btn_avanza = new System.Windows.Forms.Button();
			this.btn_avanza1 = new System.Windows.Forms.Button();
			this.btn_folle = new System.Windows.Forms.Button();
			this.btn_frena = new System.Windows.Forms.Button();
			this.btn_gear1 = new System.Windows.Forms.Button();
			this.btn_gear2 = new System.Windows.Forms.Button();
			this.btn_gear3 = new System.Windows.Forms.Button();
			this.btn_gear4 = new System.Windows.Forms.Button();
			this.btn_gear5 = new System.Windows.Forms.Button();
			this.btn_gear6 = new System.Windows.Forms.Button();
			this.btn_giu = new System.Windows.Forms.Button();
			this.btn_retro = new System.Windows.Forms.Button();
			this.btn_off = new System.Windows.Forms.Button();
			this.btn_su = new System.Windows.Forms.Button();
			this.lbl_gear = new System.Windows.Forms.Label();
			this.lbl_log = new System.Windows.Forms.Label();
			this.lbl_speed = new System.Windows.Forms.Label();
			this.led_accelera = new System.Windows.Forms.Button();
			this.led_frena = new System.Windows.Forms.Button();
			this.led_onOff = new System.Windows.Forms.Button();
			this.LogList = new System.Windows.Forms.ListView();
			this.header_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.header_azione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.header_spiegazione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txt_secondi = new System.Windows.Forms.RichTextBox();
			this.view_gear = new System.Windows.Forms.RichTextBox();
			this.view_speed = new System.Windows.Forms.RichTextBox();
			this.view_unit = new System.Windows.Forms.RichTextBox();
			this.btn_save = new System.Windows.Forms.Button();
			this.led_save = new System.Windows.Forms.Button();
			this.btn_speedConst = new System.Windows.Forms.Button();
			this.led_speedConst = new System.Windows.Forms.Button();
			this.led_on = new System.Windows.Forms.Button();
			this.led_off = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.btn_restart = new System.Windows.Forms.Button();
			header_risultato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// header_risultato
			// 
			header_risultato.Text = "Risultati";
			header_risultato.Width = 200;
			// 
			// btn_accelera
			// 
			this.btn_accelera.BackColor = System.Drawing.Color.White;
			this.btn_accelera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_accelera.ForeColor = System.Drawing.Color.Black;
			this.btn_accelera.Location = new System.Drawing.Point(192, 367);
			this.btn_accelera.Name = "btn_accelera";
			this.btn_accelera.Size = new System.Drawing.Size(103, 99);
			this.btn_accelera.TabIndex = 1;
			this.btn_accelera.Text = "Accelera";
			this.btn_accelera.UseVisualStyleBackColor = false;
			this.btn_accelera.Click += new System.EventHandler(this.Accelera_Click);
			// 
			// btn_on
			// 
			this.btn_on.BackColor = System.Drawing.Color.White;
			this.btn_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_on.ForeColor = System.Drawing.Color.Black;
			this.btn_on.Location = new System.Drawing.Point(39, 150);
			this.btn_on.Name = "btn_on";
			this.btn_on.Size = new System.Drawing.Size(91, 47);
			this.btn_on.TabIndex = 0;
			this.btn_on.Text = "Accendi";
			this.btn_on.UseVisualStyleBackColor = false;
			this.btn_on.Click += new System.EventHandler(this.Accendi_Click);
			// 
			// btn_avanza
			// 
			this.btn_avanza.BackColor = System.Drawing.Color.White;
			this.btn_avanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_avanza.ForeColor = System.Drawing.Color.Black;
			this.btn_avanza.Location = new System.Drawing.Point(367, 76);
			this.btn_avanza.Name = "btn_avanza";
			this.btn_avanza.Size = new System.Drawing.Size(111, 47);
			this.btn_avanza.TabIndex = 32;
			this.btn_avanza.Text = "avanza (s)";
			this.btn_avanza.UseVisualStyleBackColor = false;
			this.btn_avanza.Click += new System.EventHandler(this.Avanza_Click);
			// 
			// btn_avanza1
			// 
			this.btn_avanza1.BackColor = System.Drawing.Color.White;
			this.btn_avanza1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_avanza1.ForeColor = System.Drawing.Color.Black;
			this.btn_avanza1.Location = new System.Drawing.Point(367, 12);
			this.btn_avanza1.Name = "btn_avanza1";
			this.btn_avanza1.Size = new System.Drawing.Size(188, 47);
			this.btn_avanza1.TabIndex = 0;
			this.btn_avanza1.Text = "avanza di 1 secondo";
			this.btn_avanza1.UseVisualStyleBackColor = false;
			this.btn_avanza1.Click += new System.EventHandler(this.Avanza1_Click);
			// 
			// btn_folle
			// 
			this.btn_folle.BackColor = System.Drawing.Color.White;
			this.btn_folle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_folle.ForeColor = System.Drawing.Color.Black;
			this.btn_folle.Location = new System.Drawing.Point(414, 326);
			this.btn_folle.Name = "btn_folle";
			this.btn_folle.Size = new System.Drawing.Size(64, 26);
			this.btn_folle.TabIndex = 21;
			this.btn_folle.Text = "Folle";
			this.btn_folle.UseVisualStyleBackColor = false;
			this.btn_folle.Click += new System.EventHandler(this.Folle_Click);
			// 
			// btn_frena
			// 
			this.btn_frena.BackColor = System.Drawing.Color.White;
			this.btn_frena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_frena.ForeColor = System.Drawing.Color.Black;
			this.btn_frena.Location = new System.Drawing.Point(301, 381);
			this.btn_frena.Name = "btn_frena";
			this.btn_frena.Size = new System.Drawing.Size(82, 85);
			this.btn_frena.TabIndex = 2;
			this.btn_frena.Text = "Frena";
			this.btn_frena.UseVisualStyleBackColor = false;
			this.btn_frena.Click += new System.EventHandler(this.Frena_Click);
			// 
			// btn_gear1
			// 
			this.btn_gear1.BackColor = System.Drawing.Color.White;
			this.btn_gear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_gear1.ForeColor = System.Drawing.Color.Black;
			this.btn_gear1.Location = new System.Drawing.Point(484, 296);
			this.btn_gear1.Name = "btn_gear1";
			this.btn_gear1.Size = new System.Drawing.Size(32, 26);
			this.btn_gear1.TabIndex = 22;
			this.btn_gear1.Text = "1";
			this.btn_gear1.UseVisualStyleBackColor = false;
			this.btn_gear1.Click += new System.EventHandler(this.Gear1_Click);
			// 
			// btn_gear2
			// 
			this.btn_gear2.BackColor = System.Drawing.Color.White;
			this.btn_gear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_gear2.ForeColor = System.Drawing.Color.Black;
			this.btn_gear2.Location = new System.Drawing.Point(484, 326);
			this.btn_gear2.Name = "btn_gear2";
			this.btn_gear2.Size = new System.Drawing.Size(32, 26);
			this.btn_gear2.TabIndex = 23;
			this.btn_gear2.Text = "2";
			this.btn_gear2.UseVisualStyleBackColor = false;
			this.btn_gear2.Click += new System.EventHandler(this.Gear2_Click);
			// 
			// btn_gear3
			// 
			this.btn_gear3.BackColor = System.Drawing.Color.White;
			this.btn_gear3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_gear3.ForeColor = System.Drawing.Color.Black;
			this.btn_gear3.Location = new System.Drawing.Point(522, 296);
			this.btn_gear3.Name = "btn_gear3";
			this.btn_gear3.Size = new System.Drawing.Size(32, 26);
			this.btn_gear3.TabIndex = 24;
			this.btn_gear3.Text = "3";
			this.btn_gear3.UseVisualStyleBackColor = false;
			this.btn_gear3.Click += new System.EventHandler(this.Gear3_Click);
			// 
			// btn_gear4
			// 
			this.btn_gear4.BackColor = System.Drawing.Color.White;
			this.btn_gear4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_gear4.ForeColor = System.Drawing.Color.Black;
			this.btn_gear4.Location = new System.Drawing.Point(522, 326);
			this.btn_gear4.Name = "btn_gear4";
			this.btn_gear4.Size = new System.Drawing.Size(32, 26);
			this.btn_gear4.TabIndex = 25;
			this.btn_gear4.Text = "4";
			this.btn_gear4.UseVisualStyleBackColor = false;
			this.btn_gear4.Click += new System.EventHandler(this.Gear4_Click);
			// 
			// btn_gear5
			// 
			this.btn_gear5.BackColor = System.Drawing.Color.White;
			this.btn_gear5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_gear5.ForeColor = System.Drawing.Color.Black;
			this.btn_gear5.Location = new System.Drawing.Point(560, 296);
			this.btn_gear5.Name = "btn_gear5";
			this.btn_gear5.Size = new System.Drawing.Size(32, 26);
			this.btn_gear5.TabIndex = 26;
			this.btn_gear5.Text = "5";
			this.btn_gear5.UseVisualStyleBackColor = false;
			this.btn_gear5.Click += new System.EventHandler(this.Gear5_Click);
			// 
			// btn_gear6
			// 
			this.btn_gear6.BackColor = System.Drawing.Color.White;
			this.btn_gear6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_gear6.ForeColor = System.Drawing.Color.Black;
			this.btn_gear6.Location = new System.Drawing.Point(560, 326);
			this.btn_gear6.Name = "btn_gear6";
			this.btn_gear6.Size = new System.Drawing.Size(32, 26);
			this.btn_gear6.TabIndex = 27;
			this.btn_gear6.Text = "6";
			this.btn_gear6.UseVisualStyleBackColor = false;
			this.btn_gear6.Click += new System.EventHandler(this.Gear6_Click);
			// 
			// btn_giu
			// 
			this.btn_giu.BackColor = System.Drawing.Color.White;
			this.btn_giu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_giu.ForeColor = System.Drawing.Color.Black;
			this.btn_giu.Location = new System.Drawing.Point(535, 105);
			this.btn_giu.Name = "btn_giu";
			this.btn_giu.Size = new System.Drawing.Size(32, 28);
			this.btn_giu.TabIndex = 35;
			this.btn_giu.Text = "🔽";
			this.btn_giu.UseVisualStyleBackColor = false;
			this.btn_giu.Click += new System.EventHandler(this.MenoSecondi_Click);
			// 
			// btn_retro
			// 
			this.btn_retro.BackColor = System.Drawing.Color.White;
			this.btn_retro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_retro.ForeColor = System.Drawing.Color.Black;
			this.btn_retro.Location = new System.Drawing.Point(414, 296);
			this.btn_retro.Name = "btn_retro";
			this.btn_retro.Size = new System.Drawing.Size(64, 26);
			this.btn_retro.TabIndex = 20;
			this.btn_retro.Text = "Retro";
			this.btn_retro.UseVisualStyleBackColor = false;
			this.btn_retro.Click += new System.EventHandler(this.Retro_Click);
			// 
			// btn_off
			// 
			this.btn_off.BackColor = System.Drawing.Color.White;
			this.btn_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_off.ForeColor = System.Drawing.Color.Black;
			this.btn_off.Location = new System.Drawing.Point(39, 254);
			this.btn_off.Name = "btn_off";
			this.btn_off.Size = new System.Drawing.Size(91, 47);
			this.btn_off.TabIndex = 15;
			this.btn_off.Text = "Spegni";
			this.btn_off.UseVisualStyleBackColor = false;
			this.btn_off.Click += new System.EventHandler(this.Spegni_Click);
			// 
			// btn_su
			// 
			this.btn_su.BackColor = System.Drawing.Color.White;
			this.btn_su.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_su.ForeColor = System.Drawing.Color.Black;
			this.btn_su.Location = new System.Drawing.Point(535, 76);
			this.btn_su.Name = "btn_su";
			this.btn_su.Size = new System.Drawing.Size(32, 26);
			this.btn_su.TabIndex = 34;
			this.btn_su.Text = "🔼";
			this.btn_su.UseVisualStyleBackColor = false;
			this.btn_su.Click += new System.EventHandler(this.PiùSecondi_Click);
			// 
			// lbl_gear
			// 
			this.lbl_gear.AutoSize = true;
			this.lbl_gear.Location = new System.Drawing.Point(468, 227);
			this.lbl_gear.Name = "lbl_gear";
			this.lbl_gear.Size = new System.Drawing.Size(48, 13);
			this.lbl_gear.TabIndex = 6;
			this.lbl_gear.Text = "MARCIA";
			// 
			// lbl_log
			// 
			this.lbl_log.AutoSize = true;
			this.lbl_log.Location = new System.Drawing.Point(654, 84);
			this.lbl_log.Name = "lbl_log";
			this.lbl_log.Size = new System.Drawing.Size(37, 13);
			this.lbl_log.TabIndex = 29;
			this.lbl_log.Text = "Eventi";
			// 
			// lbl_speed
			// 
			this.lbl_speed.AutoSize = true;
			this.lbl_speed.Location = new System.Drawing.Point(119, 42);
			this.lbl_speed.Name = "lbl_speed";
			this.lbl_speed.Size = new System.Drawing.Size(45, 13);
			this.lbl_speed.TabIndex = 12;
			this.lbl_speed.Text = "Velocità";
			// 
			// led_accelera
			// 
			this.led_accelera.BackColor = System.Drawing.Color.Red;
			this.led_accelera.FlatAppearance.BorderSize = 0;
			this.led_accelera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.led_accelera.Location = new System.Drawing.Point(230, 472);
			this.led_accelera.Margin = new System.Windows.Forms.Padding(0);
			this.led_accelera.Name = "led_accelera";
			this.led_accelera.Size = new System.Drawing.Size(30, 30);
			this.led_accelera.TabIndex = 15;
			this.led_accelera.UseVisualStyleBackColor = false;
			// 
			// led_frena
			// 
			this.led_frena.BackColor = System.Drawing.Color.Red;
			this.led_frena.FlatAppearance.BorderSize = 0;
			this.led_frena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.led_frena.Location = new System.Drawing.Point(326, 472);
			this.led_frena.Margin = new System.Windows.Forms.Padding(0);
			this.led_frena.Name = "led_frena";
			this.led_frena.Size = new System.Drawing.Size(30, 30);
			this.led_frena.TabIndex = 15;
			this.led_frena.UseVisualStyleBackColor = false;
			// 
			// led_onOff
			// 
			this.led_onOff.BackColor = System.Drawing.Color.Red;
			this.led_onOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.led_onOff.FlatAppearance.BorderSize = 0;
			this.led_onOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.led_onOff.Location = new System.Drawing.Point(39, 203);
			this.led_onOff.Margin = new System.Windows.Forms.Padding(0);
			this.led_onOff.Name = "led_onOff";
			this.led_onOff.Size = new System.Drawing.Size(91, 45);
			this.led_onOff.TabIndex = 15;
			this.led_onOff.UseVisualStyleBackColor = false;
			this.led_onOff.Click += new System.EventHandler(this.LedOnOff_Click);
			// 
			// LogList
			// 
			this.LogList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.header_time,
            this.header_azione,
            header_risultato,
            this.header_spiegazione});
			this.LogList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogList.ForeColor = System.Drawing.Color.Black;
			this.LogList.HideSelection = false;
			this.LogList.Location = new System.Drawing.Point(642, 105);
			this.LogList.Name = "LogList";
			this.LogList.Size = new System.Drawing.Size(830, 600);
			this.LogList.TabIndex = 28;
			this.LogList.UseCompatibleStateImageBehavior = false;
			this.LogList.View = System.Windows.Forms.View.Details;
			// 
			// header_time
			// 
			this.header_time.Text = "Tempo";
			this.header_time.Width = 100;
			// 
			// header_azione
			// 
			this.header_azione.Text = "Azioni";
			this.header_azione.Width = 150;
			// 
			// header_spiegazione
			// 
			this.header_spiegazione.Text = "Spiegazioni";
			this.header_spiegazione.Width = 376;
			// 
			// txt_secondi
			// 
			this.txt_secondi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txt_secondi.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_secondi.DetectUrls = false;
			this.txt_secondi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_secondi.ForeColor = System.Drawing.Color.Black;
			this.txt_secondi.Location = new System.Drawing.Point(484, 89);
			this.txt_secondi.MaxLength = 3;
			this.txt_secondi.Multiline = false;
			this.txt_secondi.Name = "txt_secondi";
			this.txt_secondi.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.txt_secondi.Size = new System.Drawing.Size(45, 30);
			this.txt_secondi.TabIndex = 33;
			this.txt_secondi.Text = "1";
			this.txt_secondi.WordWrap = false;
			// 
			// view_gear
			// 
			this.view_gear.BackColor = System.Drawing.Color.Black;
			this.view_gear.DetectUrls = false;
			this.view_gear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.view_gear.ForeColor = System.Drawing.Color.White;
			this.view_gear.Location = new System.Drawing.Point(471, 246);
			this.view_gear.MaxLength = 0;
			this.view_gear.Multiline = false;
			this.view_gear.Name = "view_gear";
			this.view_gear.ReadOnly = true;
			this.view_gear.Size = new System.Drawing.Size(30, 42);
			this.view_gear.TabIndex = 17;
			this.view_gear.Text = "N";
			// 
			// view_speed
			// 
			this.view_speed.BackColor = System.Drawing.Color.Black;
			this.view_speed.DetectUrls = false;
			this.view_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.view_speed.ForeColor = System.Drawing.Color.White;
			this.view_speed.Location = new System.Drawing.Point(122, 58);
			this.view_speed.MaxLength = 0;
			this.view_speed.Multiline = false;
			this.view_speed.Name = "view_speed";
			this.view_speed.ReadOnly = true;
			this.view_speed.Size = new System.Drawing.Size(108, 40);
			this.view_speed.TabIndex = 30;
			this.view_speed.Text = "000.00";
			// 
			// view_unit
			// 
			this.view_unit.BackColor = System.Drawing.Color.Black;
			this.view_unit.DetectUrls = false;
			this.view_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.view_unit.ForeColor = System.Drawing.Color.White;
			this.view_unit.Location = new System.Drawing.Point(236, 58);
			this.view_unit.MaxLength = 0;
			this.view_unit.Multiline = false;
			this.view_unit.Name = "view_unit";
			this.view_unit.ReadOnly = true;
			this.view_unit.Size = new System.Drawing.Size(76, 40);
			this.view_unit.TabIndex = 31;
			this.view_unit.Text = "km/h";
			// 
			// btn_save
			// 
			this.btn_save.BackColor = System.Drawing.Color.White;
			this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_save.ForeColor = System.Drawing.Color.Black;
			this.btn_save.Location = new System.Drawing.Point(573, 12);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(102, 47);
			this.btn_save.TabIndex = 36;
			this.btn_save.Text = "Mantieni Azioni";
			this.btn_save.UseVisualStyleBackColor = false;
			this.btn_save.Click += new System.EventHandler(this.SavePreviousActions_Click);
			// 
			// led_save
			// 
			this.led_save.BackColor = System.Drawing.Color.Red;
			this.led_save.FlatAppearance.BorderSize = 0;
			this.led_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.led_save.Location = new System.Drawing.Point(678, 20);
			this.led_save.Margin = new System.Windows.Forms.Padding(0);
			this.led_save.Name = "led_save";
			this.led_save.Size = new System.Drawing.Size(30, 30);
			this.led_save.TabIndex = 37;
			this.led_save.UseVisualStyleBackColor = false;
			// 
			// btn_speedConst
			// 
			this.btn_speedConst.BackColor = System.Drawing.Color.White;
			this.btn_speedConst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_speedConst.ForeColor = System.Drawing.Color.Black;
			this.btn_speedConst.Location = new System.Drawing.Point(83, 381);
			this.btn_speedConst.Name = "btn_speedConst";
			this.btn_speedConst.Size = new System.Drawing.Size(103, 85);
			this.btn_speedConst.TabIndex = 38;
			this.btn_speedConst.Text = "Velocità Costante";
			this.btn_speedConst.UseVisualStyleBackColor = false;
			this.btn_speedConst.Click += new System.EventHandler(this.SpeedConstante_Click);
			// 
			// led_speedConst
			// 
			this.led_speedConst.BackColor = System.Drawing.Color.Red;
			this.led_speedConst.FlatAppearance.BorderSize = 0;
			this.led_speedConst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.led_speedConst.Location = new System.Drawing.Point(121, 472);
			this.led_speedConst.Margin = new System.Windows.Forms.Padding(0);
			this.led_speedConst.Name = "led_speedConst";
			this.led_speedConst.Size = new System.Drawing.Size(30, 30);
			this.led_speedConst.TabIndex = 39;
			this.led_speedConst.UseVisualStyleBackColor = false;
			// 
			// led_on
			// 
			this.led_on.BackColor = System.Drawing.Color.Red;
			this.led_on.FlatAppearance.BorderSize = 0;
			this.led_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.led_on.Location = new System.Drawing.Point(13, 163);
			this.led_on.Margin = new System.Windows.Forms.Padding(0);
			this.led_on.Name = "led_on";
			this.led_on.Size = new System.Drawing.Size(20, 20);
			this.led_on.TabIndex = 40;
			this.led_on.UseVisualStyleBackColor = false;
			// 
			// led_off
			// 
			this.led_off.BackColor = System.Drawing.Color.Red;
			this.led_off.FlatAppearance.BorderSize = 0;
			this.led_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.led_off.Location = new System.Drawing.Point(13, 267);
			this.led_off.Margin = new System.Windows.Forms.Padding(0);
			this.led_off.Name = "led_off";
			this.led_off.Size = new System.Drawing.Size(20, 20);
			this.led_off.TabIndex = 41;
			this.led_off.UseVisualStyleBackColor = false;
			// 
			// btn_clear
			// 
			this.btn_clear.BackColor = System.Drawing.Color.White;
			this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_clear.ForeColor = System.Drawing.Color.Black;
			this.btn_clear.Location = new System.Drawing.Point(972, 25);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(102, 47);
			this.btn_clear.TabIndex = 42;
			this.btn_clear.Text = "Clear";
			this.btn_clear.UseVisualStyleBackColor = false;
			this.btn_clear.Click += new System.EventHandler(this.Clear_Click);
			// 
			// btn_restart
			// 
			this.btn_restart.BackColor = System.Drawing.Color.White;
			this.btn_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_restart.ForeColor = System.Drawing.Color.Black;
			this.btn_restart.Location = new System.Drawing.Point(1361, 25);
			this.btn_restart.Name = "btn_restart";
			this.btn_restart.Size = new System.Drawing.Size(102, 47);
			this.btn_restart.TabIndex = 43;
			this.btn_restart.Text = "Restart";
			this.btn_restart.UseVisualStyleBackColor = false;
			this.btn_restart.Click += new System.EventHandler(this.Restart_Click);
			// 
			// InternoAuto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1484, 709);
			this.Controls.Add(this.btn_restart);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.led_off);
			this.Controls.Add(this.led_on);
			this.Controls.Add(this.btn_speedConst);
			this.Controls.Add(this.led_speedConst);
			this.Controls.Add(this.led_save);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.btn_accelera);
			this.Controls.Add(this.btn_on);
			this.Controls.Add(this.btn_avanza);
			this.Controls.Add(this.btn_avanza1);
			this.Controls.Add(this.btn_folle);
			this.Controls.Add(this.btn_frena);
			this.Controls.Add(this.btn_gear1);
			this.Controls.Add(this.btn_gear2);
			this.Controls.Add(this.btn_gear3);
			this.Controls.Add(this.btn_gear4);
			this.Controls.Add(this.btn_gear5);
			this.Controls.Add(this.btn_gear6);
			this.Controls.Add(this.btn_giu);
			this.Controls.Add(this.btn_retro);
			this.Controls.Add(this.btn_off);
			this.Controls.Add(this.btn_su);
			this.Controls.Add(this.lbl_gear);
			this.Controls.Add(this.lbl_log);
			this.Controls.Add(this.lbl_speed);
			this.Controls.Add(this.led_accelera);
			this.Controls.Add(this.led_frena);
			this.Controls.Add(this.led_onOff);
			this.Controls.Add(this.LogList);
			this.Controls.Add(this.txt_secondi);
			this.Controls.Add(this.view_gear);
			this.Controls.Add(this.view_speed);
			this.Controls.Add(this.view_unit);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "InternoAuto";
			this.Text = "Guida";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_accelera;
		private System.Windows.Forms.Button btn_on;
		private System.Windows.Forms.Button btn_avanza1;
		private System.Windows.Forms.Button btn_avanza;
		private System.Windows.Forms.Button btn_folle;
		private System.Windows.Forms.Button btn_frena;
		private System.Windows.Forms.Button btn_gear1;
		private System.Windows.Forms.Button btn_gear2;
		private System.Windows.Forms.Button btn_gear3;
		private System.Windows.Forms.Button btn_gear4;
		private System.Windows.Forms.Button btn_gear5;
		private System.Windows.Forms.Button btn_gear6;
		private System.Windows.Forms.Button btn_giu;
		private System.Windows.Forms.Button btn_retro;
		private System.Windows.Forms.Button btn_off;
		private System.Windows.Forms.Button btn_su;
		private System.Windows.Forms.Label lbl_gear;
		private System.Windows.Forms.Label lbl_log;
		private System.Windows.Forms.Label lbl_speed;
		private System.Windows.Forms.ListView LogList;
		private System.Windows.Forms.Button led_accelera;
		private System.Windows.Forms.Button led_frena;
		private System.Windows.Forms.Button led_onOff;
		private System.Windows.Forms.RichTextBox txt_secondi;
		private System.Windows.Forms.RichTextBox view_gear;
		private System.Windows.Forms.RichTextBox view_speed;
		private System.Windows.Forms.RichTextBox view_unit;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button led_save;
		private System.Windows.Forms.Button btn_speedConst;
		private System.Windows.Forms.Button led_speedConst;
		private System.Windows.Forms.Button led_on;
		private System.Windows.Forms.Button led_off;
		private System.Windows.Forms.ColumnHeader header_time;
		private System.Windows.Forms.ColumnHeader header_azione;
		private System.Windows.Forms.ColumnHeader header_spiegazione;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.Button btn_restart;
	}
}
