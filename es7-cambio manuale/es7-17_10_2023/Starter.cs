using System;
using System.Windows.Forms;

namespace es7_17_10_23
{
	internal static class Starter
	{
		public static bool restart = true;

		/// <summary>
		/// Punto di ingresso principale dell'applicazione.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Console.Write("Skippare i passaggi iniziali? (y)es/(n)o");
			char input;
			bool fastStart = false;
			do
			{
				input = Console.ReadKey(true).KeyChar.ToString().ToLower()[0];
				if(input == 's' || input == '\r') input = 'y';
				if(input == 'y') fastStart = true;

			} while(input != 'y' && input != 'n');
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			while(restart)
			{
				restart = false;
				Application.Run(new InternoAuto(fastStart));
			}
		}
	}
}
