using System; //Math, Exception
using System.Collections.Generic; //Dictionary<,>
/*using System.Linq; //Dictionary .First() e .Last() */

namespace es7_17_10_23
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

	/// <summary>
	/// Macchina con cambio manuale
	/// </summary>
	internal class Auto
	{
		private bool _isOn;
		private short _gear; //-1 retro, 0 (N) folle, 1->6

		public float Speed { get; protected set; } // km/h

		public bool IsOn
		{
			get => _isOn;
			set => OnOff(value);
		}

		public short Gear
		{
			get => _gear;
			set => SwitchGear(value);
		}

		//le const non sono riscrivibili in subclass
		public short GearMin { get; protected set; } = -1;
		public short GearMax { get; protected set; } = 6;

		public float FrenataBase { get; protected set; } = -5f; // mt per sec quadrato
		public float DecelerazioneBase { get; protected set; } = -0.5f; // mt per sec quadrato

		protected readonly Dictionary<short, (float minSpeed, float maxSpeed, float accelerazione)> speedAndAccPerGear = new Dictionary<short, (float minSpeed, float maxSpeed, float accelerazione)>
		{
			{-1, (-20f, 0f, -6f) }, // in retro la velocità è al max -20 km/h
			{0, (0f, 0f, 0f) }, //in folle la velocità tende a 0
			{1, (0f, 40f, 7f) },
			{2, (20f, 70f, 5f) },
			{3, (30f, 90f, 3f) },
			{4, (40f, 110f, 2f) },
			{5, (50f, 130f, 1.5f) },
			{6, (60f, 170f, 1f) }
		};

		/// <summary>
		/// per ottenere km/h moltiplicalo, per ottenere m/s dividilo
		/// </summary>
		public const float convert_mtPerSec_kmPerH = 3.6f;

		public bool IsGearSwitchableWhen_isOff { get; protected set; } = false;
		
		private bool _decelera = true; //mode -1 // = non fare niente
		private bool _accelera, _speedCostante, _frena, _accendi, _spegni = false; // modes: 2, 3, 4, 1, 0

		/// <summary>
		/// Se True salva le precedenti azioni.
		/// </summary>
		/// <remarks>
		///		Azioni escluse: accendi e spegni. <br/>
		///		Se False le imposta a default dopo AvanzaTempo().
		/// </remarks>
		public bool SavePreviousActions { get; set; } = false;

		public Auto()
		{
			_isOn = false;
			_gear = 0;
			Speed = 0;
		}

		/// <summary>
		/// Switch motore acceso e motore spento.
		/// </summary>
		/// <param name="isOn">Set del motore</param>
		private void OnOff(bool isOn)
		{
			_isOn = isOn;
			//chiamare se la macchina è in movimento???
		}

		private void AumentaMarcia() => SwitchGear(_gear == -1 ? (short)1 : (short)(_gear+1));

		private void DiminuisciMarcia() => SwitchGear(_gear == 1 ? (short)-1 : (short)(_gear-1));

		private void SwitchGear(short gear)
		{
			//in questa macchina a motore spento la marcia non cambia
			if(!IsGearSwitchableWhen_isOff && !_isOn) return;
			switch(gear)
			{
				case -1:
					//gratta la marcia
					if(Speed != 0) return;
					break;
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
					//gratta la marcia
					if(Speed < 0) return;
					break;
				case 0:
					//impostabile in ogni momento
					break;
				default:
					//marcia non esistente
					return;
			}
			_gear = gear;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="isOn"></param>
		/// <returns>Se ora è accesa ritorna true, se ora è spenta ritorna false</returns>
		public bool AccendiSpegni(bool isOn)
		{
			OnOff(isOn);
			return _isOn;
		}

		public bool AccendiSpegni()
		{
			OnOff(!IsOn);
			return _isOn;
		}

	}
}
