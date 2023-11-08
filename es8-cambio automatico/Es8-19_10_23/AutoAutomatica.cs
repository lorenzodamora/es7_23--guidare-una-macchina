using System; //Math, Exception, string
/*using System.Linq; //Dictionary .First() e .Last() */

namespace es8_19_10_23
{
	/// <summary>
	/// Macchina con cambio automatico.
	/// </summary>
	/// <remarks>è senza cambio manuale.</remarks>
	internal class AutoAutomatica : Auto
	{

		private bool _mode; //0 avanti, 1 retro

		public AutoAutomatica() : base()
		{
			//GearMax = 7;
			//speedAndAccPerGear.Add(7,())
		}

		public override string CambiaMarcia(Gears gear) => "Now;Cambio Marcia;;in questa auto la marcia non può essere cambiata manualmente";


	}
}
