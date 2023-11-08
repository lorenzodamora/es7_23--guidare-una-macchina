using System;
using System.Windows.Forms;
using System.Drawing;

namespace es8_19_10_23
{
	public partial class InternoAuto : Form
	{
		/*
		 * Realizzare un programma in windows form che consenta di simulare la guida di un'automobile.
		 * Le funzionalità richieste sono:
		 * accende e spegnere il motore;
		 * accelerare e decelerare;
		 * aumentare e diminuire la marcia..
		 * Per la realizzazione creare la classe Auto con gli attributi e i metodi opportuni.
		 * Creare un repository GitHub effettuando almeno un commit/push, per ogni funzionalità implementata
		 */

		private readonly AutoAutomatica auto; //statico?
		/* private int time = 0; */

		public InternoAuto(bool fastStart)
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;

			auto = new AutoAutomatica();
			if(fastStart)
			{
				AddLog(AzioneClick(Actions.Accendi));
				Avanza_Click(null, null);
				SavePreviousActions_Click(null, null);
				CambiaMarcia((Gears)1);
				AddLog(AzioneClick(Actions.Accelera));
			}
		}

		private string AzioneClick(Actions action)
		{
			string log = "";
			if(auto.GetAction(action))
				auto.AnnullaAzione(action);
			else
				log = auto.EseguiAzione(action);
			AggiornaLed();
			return log;
		}

		private void Accendi_Click(object sender, EventArgs e) => AddLog(AzioneClick(Actions.Accendi));

		private void Spegni_Click(object sender, EventArgs e) => AddLog(AzioneClick(Actions.Spegni));

		private void LedOnOff_Click(object sender, EventArgs e)
		{
			auto.AccendiSpegni();
			AggiornaLed();
		}

		private void Accelera_Click(object sender, EventArgs e) => AddLog(AzioneClick(Actions.Accelera));

		private void SpeedConstante_Click(object sender, EventArgs e) => AddLog(AzioneClick(Actions.SpeedCostante));

		private void Frena_Click(object sender, EventArgs e) => AddLog(AzioneClick(Actions.Frena));

		private void CambiaMarcia(Gears gear)
		{
			AddLog(auto.CambiaMarcia(gear));
			gear = (Gears)auto.Gear;
			switch(auto.Gear)
			{
				case -1:
				case 0:
					view_gear.Text = gear.ToString();
					break;
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
					view_gear.Text = ((short)gear).ToString();
					break;
				default:
					throw new Exception("gear non trovata");
			}
			AggiornaLed();
		}

		private void Retro_Click(object sender, EventArgs e) => CambiaMarcia(Gears.R);

		private void Folle_Click(object sender, EventArgs e) => CambiaMarcia(Gears.N);

		private void Gear1_Click(object sender, EventArgs e) => CambiaMarcia((Gears)1);

		private void Gear2_Click(object sender, EventArgs e) => CambiaMarcia((Gears)2);

		private void Gear3_Click(object sender, EventArgs e) => CambiaMarcia((Gears)3);

		private void Gear4_Click(object sender, EventArgs e) => CambiaMarcia((Gears)4);

		private void Gear5_Click(object sender, EventArgs e) => CambiaMarcia((Gears)5);

		private void Gear6_Click(object sender, EventArgs e) => CambiaMarcia((Gears)6);

		private void SavePreviousActions_Click(object sender, EventArgs e)
		{
			auto.SavePreviousActions = !auto.SavePreviousActions;
			if(auto.SavePreviousActions) led_save.BackColor = Color.Green;
			else led_save.BackColor = Color.Red;
		}

		private short CheckInputSecondi(string input)
		{
			if(!short.TryParse(input, out short sec))
			{//bad input
				MessageBox.Show("Inserisci un numero intero", "Errore in input", 0);
				return 0;
			}
			if(sec < 1)
			{//bad input
				MessageBox.Show("Il numero deve essere maggiore di 0", "Errore in input", 0);
				return 0;
			}
			if(sec > 998) return 0;
			return sec;
		}

		private void AggiornaLed()
		{
			led_onOff.BackColor = auto.IsOn ? Color.Green : Color.Red;
			led_on.BackColor = auto.GetAction(Actions.Accendi) ? Color.Green : Color.Red;
			led_off.BackColor = auto.GetAction(Actions.Spegni) ? Color.Green : Color.Red;
			led_accelera.BackColor = auto.GetAction(Actions.Accelera) ? Color.Green : Color.Red;
			led_speedConst.BackColor = auto.GetAction(Actions.SpeedCostante) ? Color.Green : Color.Red;
			led_frena.BackColor = auto.GetAction(Actions.Frena) ? Color.Green : Color.Red;
		}

		private void Avanza1_Click(object sender, EventArgs e)
		{
			Log(auto.AvanzaTempo());
			AggiornaLed();
			view_speed.Text = auto.Speed.ToString("0.##");
		}

		private void Avanza_Click(object sender, EventArgs e)
		{
			short sec = CheckInputSecondi(txt_secondi.Text);
			Cursor = Cursors.WaitCursor;
			Log(auto.AvanzaTempo(sec));
			AggiornaLed();
			view_speed.Text = auto.Speed.ToString("0.##");
			Cursor = Cursors.Default;
		}

		private void PiùSecondi_Click(object sender, EventArgs e) => txt_secondi.Text = (CheckInputSecondi(txt_secondi.Text)+1).ToString();

		private void MenoSecondi_Click(object sender, EventArgs e)
		{
			short sec = CheckInputSecondi(txt_secondi.Text);
			txt_secondi.Text = (sec == 1 ? sec : sec-1).ToString();
		}

		private void Log(string logs)
		{
			string[] log = logs.Split('\n');
			//ha dentro di quanti secondi sono andato avanti 
			int sec = int.Parse(log[1])-1;

			for(int i = 0; i <= sec; i++)
				foreach(ListViewItem item in LogList.Items)
					item.Text = item.Text=="Now" ? "1" : (int.Parse(item.Text) + 1).ToString();

			for(int i = 2; i < log.Length-1; i++)
			{
				if(log[i].Length < 4)
				{
					sec--;
					continue;
				}

				string[] logSplit = log[i].Split(';');
				string itemTime;
				if(sec==0) itemTime = "Now";
				else
					itemTime = sec.ToString();
				ListViewItem item = new ListViewItem(itemTime);
				for(int s = 0; s < logSplit.Length; s++)
				{
					item.SubItems.Add(logSplit[s]);
				}
				LogList.Items.Insert(0, item);
			}
		}

		private void AddLog(string log)
		{
			if(string.IsNullOrEmpty(log)) return;
			string[] logSplit = log.Split(';');
			ListViewItem item = new ListViewItem(logSplit[0].ToString());
			for(int s = 1; s < logSplit.Length; s++)
			{
				item.SubItems.Add(logSplit[s]);
			}
			LogList.Items.Insert(0, item);
		}

		private void Clear_Click(object sender, EventArgs e) => LogList.Items.Clear();

		private void Restart_Click(object sender, EventArgs e)
		{
			Close();
			Starter.restart = true;
		}
	}
}
