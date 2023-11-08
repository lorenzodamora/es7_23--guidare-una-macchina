using System;
using System.Windows.Forms;
using System.Drawing;

namespace es7_17_10_23
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

		private readonly Auto auto; //statico?
		//private int time = 0;

		public InternoAuto(bool fastStart)
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;

			auto = new Auto();
			if(fastStart)
			{
			}
		}

		private string AzioneClick(Actions action)
		{
			string log = "";
			if(auto.GetAction(action))
				auto.AnnullaAzione(action);
			else
				log = auto.EseguiAzione(action);
			//AggiornaLed();
			return log;
		}

		private void Accendi_Click(object sender, EventArgs e) => AzioneClick(Actions.Accendi);

		private void Spegni_Click(object sender, EventArgs e) => AzioneClick(Actions.Spegni);

		private void LedOnOff_Click(object sender, EventArgs e)
		{
			auto.AccendiSpegni();
			//AggiornaLed();
		}

		private void Accelera_Click(object sender, EventArgs e) => AzioneClick(Actions.Accelera);

		private void SpeedConstante_Click(object sender, EventArgs e) => AzioneClick(Actions.SpeedCostante);

		private void Frena_Click(object sender, EventArgs e) => AzioneClick(Actions.Frena);


		private void Retro_Click(object sender, EventArgs e)
		{

		}

		private void Folle_Click(object sender, EventArgs e)
		{

		}

		private void Gear1_Click(object sender, EventArgs e)
		{

		}

		private void Gear2_Click(object sender, EventArgs e)
		{

		}

		private void Gear3_Click(object sender, EventArgs e)
		{

		}

		private void Gear4_Click(object sender, EventArgs e)
		{

		}

		private void Gear5_Click(object sender, EventArgs e)
		{

		}

		private void Gear6_Click(object sender, EventArgs e)
		{

		}

		private void SavePreviousActions_Click(object sender, EventArgs e)
		{
		}

		private void Avanza1_Click(object sender, EventArgs e)
		{
		}

		private void Avanza_Click(object sender, EventArgs e)
		{
		}

		private void PiùSecondi_Click(object sender, EventArgs e)
		{

		}

		private void MenoSecondi_Click(object sender, EventArgs e)
		{
		}

		private void Clear_Click(object sender, EventArgs e) => LogList.Items.Clear();

		private void Restart_Click(object sender, EventArgs e)
		{
			Close();
			Starter.restart = true;
		}
	}
}
