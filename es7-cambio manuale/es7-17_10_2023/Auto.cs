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
			if(!_isOn) DefaultActions();
		}

		public void AccendiSpegni()
		{
			if(_isOn) SwitchActions(Actions.Spegni);
			else SwitchActions(Actions.Accendi);
		}
		public void Accendi() => SwitchActions(Actions.Accendi);
		public void Spegni() => SwitchActions(Actions.Spegni);

		/*
		private void AumentaMarcia() => SwitchGear(_gear == -1 ? (short)1 : (short)(_gear+1));

		private void DiminuisciMarcia() => SwitchGear(_gear == 1 ? (short)-1 : (short)(_gear-1));
		 */

		private void SwitchGear(short gear)
		{
			//in questa macchina a motore spento la marcia non cambia
			if(!IsGearSwitchableWhen_isOff && !_isOn) return;
			switch(gear)
			{
				case -1:
					//gratta la marcia
					if(Speed <= 0) _gear = gear;
					break;
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
					//gratta la marcia
					if(Speed >= 0) _gear = gear;
					break;
				case 0:
					SwitchActions(Actions.Decelera, false);
					_gear = gear;
					break;
				default:
					throw new Exception("marcia non esistente. Esistenti: -1 -> 6");
			}
		}
		public void CambiaMarcia(Gears gear) => SwitchGear((short)gear);

		public void EseguiAzione(Actions action) => SwitchActions(action);

		public void AnnullaAzione(Actions action)
		{
			switch((short)action)
			{
				case -1: //decelera
					_decelera = false;
					break;
				case 0: //spegni
					_spegni = false;
					break;
				case 1: //accendi
					_accendi = false;
					break;
				case 2: //accelera
					_accelera = false;
					break;
				case 3: // speed costante
					_speedCostante = false;
					break;
				case 4: //frena
					_frena = false;
					break;
			}
			_decelera = !(_accelera || _speedCostante || _frena);
		}

		public bool GetAction(Actions action)
		{
			switch((short)action)
			{
				case -1: //decelera
					return _decelera;
				case 0: //spegni
					return _spegni;
				case 1: //accendi
					return _accendi;
				case 2: //accelera
					return _accelera;
				case 3: // speed costante
					return _speedCostante;
				case 4: //frena
					return _frena;
				default:
					throw new Exception("azione non trovata");
			}
		}

		private void SwitchActions(Actions action, bool retLog = true)
		{
			switch((short)action)
			{
				case -1: //decelera == non fare niente
					_accelera = _speedCostante = _frena = false;
					_decelera = true;
					break;
				case 0: //spegni
					_accendi = false;
					_spegni = true;
					break;
				case 1: //accendi
					_spegni = false;
					_accendi = true;
					break;
				case 2: //accelera
					if(_isOn && _gear != 0)
					{
						_decelera = _speedCostante = _frena = false;
						_accelera = true;
					}
					break;
				case 3: // speed costante
					if(_isOn && _gear != 0 && Speed != 0)
					{
						_decelera = _accelera = _frena = false;
						_speedCostante = true;
					}
					break;
				case 4: //frena
					if(_isOn && Speed != 0)
					{
						_decelera = _accelera = _speedCostante = false;
						_frena = true;
					}
					break;
			}
		}

		public void DefaultActions()
		{
			_decelera = true;
			_accelera = _speedCostante = _frena = _accendi = _spegni = false;
		}

		/// <summary>
		/// avanza di 1 secondo oppure quanti secondi inseriti.
		/// </summary>
		/// <remarks>Guarda la proprietà SavePreviousActions.</remarks>
		/// <returns> Ritorna una stringa degli eventi accaduti</returns>
		public void AvanzaTempo(short seconds = 1)
		{
			if(_accendi) OnOff(true);
			else if(_spegni) OnOff(false);
			//else if(_accendiSpegni) OnOff(!_isOn);

			while(seconds > 0)
			{
				--seconds;
				//se viene spenta passa prima per default actions
				if(!(_accelera || _speedCostante || _frena) && _decelera) ; //Decelera();
				else if(_accelera) ; // Accelera();
				else if(_speedCostante) ;// SpeedCostante();
				else if(_frena) ; // Frena();

				if(!SavePreviousActions)
					DefaultActions();
				else
					_accendi = _spegni = false;
			}
		}
		public string AvanzaTempo(bool SavePreviousActions)
		{
			this.SavePreviousActions = SavePreviousActions;
			return AvanzaTempo(1);
		}
		public string AvanzaTempo(short seconds, bool SavePreviousActions)
		{
			this.SavePreviousActions = SavePreviousActions;
			return AvanzaTempo(seconds);
		}
	}

	enum Actions
	{
		Decelera = -1,
		Accelera = 2,
		SpeedCostante = 3,
		Frena = 4,
		Accendi = 1,
		Spegni = 0,
	}

	enum Gears
	{
		R = -1, Retro = -1,
		N = 0, Folle = 0,
		Prima = 1,
		Seconda = 2,
		Terza = 3,
		Quarta = 4,
		Quinta = 5,
		Sesta = 6
	}
}