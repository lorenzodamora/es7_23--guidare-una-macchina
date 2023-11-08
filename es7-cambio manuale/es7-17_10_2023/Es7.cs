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

		private void Avanza_click(object sender, EventArgs e)
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
