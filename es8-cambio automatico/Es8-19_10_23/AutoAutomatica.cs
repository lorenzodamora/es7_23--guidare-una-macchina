using System; //Math, Exception, string
using System.Linq; //Dictionary .First() e .Last()

namespace es8_19_10_23
{
	/// <summary>
	/// Macchina con cambio automatico.
	/// </summary>
	/// <remarks>è senza cambio manuale.</remarks>
	internal class AutoAutomatica : Auto
	{
		public bool Mode //0 retro, 1 avanti
		{
			get; set;
		} = true;

		private bool _mode; //0 avanti, 1 retro

		public AutoAutomatica() : base()
		{
			//GearMax = 7;
			//speedAndAccPerGear.Add(7,())
		}

		public override string CambiaMarcia(Gears gear) => "Now;Cambio Marcia;;in questa auto la marcia non può essere cambiata manualmente";

		private short CalcoloMarcia()
		{
			if(!Mode) return -1;
			for(short gear = 1; gear < speedAndAccPerGear.Keys.Count-1; gear++)
				if(Speed <= speedAndAccPerGear[gear].maxSpeed && Speed >= speedAndAccPerGear[gear].minSpeed) return gear;
			if(Speed < 0) return 1;
			short first = speedAndAccPerGear.Keys.First();
			if(Speed < speedAndAccPerGear[first].minSpeed) return first;
			short last = speedAndAccPerGear.Keys.Last();
			if(Speed > speedAndAccPerGear[last].maxSpeed) return last;

			throw new Exception("non è stata trovata la marcia corretta");
		}


	}
}
