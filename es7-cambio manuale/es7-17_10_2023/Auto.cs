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
		/// <returns>Ritorna una stringa di log </returns>
		private string OnOff(bool isOn, bool retLog = true)
		{
			string log = null;
			if(!retLog)
				goto Ret;

			log = isOn ? "On;" : "Off;";
			if(_isOn == isOn)
			{
				log += ";era già " + (isOn ? "accesa\n" : "spenta\n");
				goto Ret;
			}

			log += isOn ? "Accesa;\n" : "Spenta;\n";

		Ret:
			_isOn = isOn;
			if(!_isOn) DefaultActions();
			return log;
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

		private string SwitchGear(short gear, bool retLog = true)
		{
			string log = null;
			//in questa macchina a motore spento la marcia non cambia
			if(!IsGearSwitchableWhen_isOff && !_isOn) return retLog ? "Now;Cambio Marcia;;in questa auto a motore spento la marcia non può essere cambiata" : "";
			switch(gear)
			{
				case -1:
					//gratta la marcia
					if(Speed > 0) log = "Now;Cambio Marcia;Gratta la marcia;La macchina si sta muovendo in avanti";
					break;
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
					//gratta la marcia
					if(Speed < 0) log = "Now;Cambio Marcia;Gratta la marcia;La macchina si sta muovendo in retro";
					break;
				case 0:
					SwitchActions(Actions.Decelera, false);
					break;
				default:
					throw new Exception("marcia non esistente. Esistenti: -1 -> 6");
			}
			_gear = log==null ? gear : _gear;
			return retLog ? log : "";
		}
		public string CambiaMarcia(Gears gear) => SwitchGear((short)gear);

		public string EseguiAzione(Actions action) => SwitchActions(action);

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
		private string SwitchActions(Actions action, bool retLog = true)
		{
			string log = null;
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
					else
					{
						if(!_isOn) log = "Now;Accelera;;Non si può accelerare a motore spento\n";
						else if(_gear == 0) log = "Now;Accelera;;Non si può accelerare senza una marcia inserita\n";
					}
					break;
				case 3: // speed costante
					if(_isOn && _gear != 0 && Speed != 0)
					{
						_decelera = _accelera = _frena = false;
						_speedCostante = true;
					}
					else
					{
						if(!_isOn) log = "Now;Velocità Costante;;Non si può accelerare a motore spento\n";
						else if(_gear == 0) log = "Now;Velocità Costante;;Non si può accelerare senza una marcia inserita\n";
						else if(Speed == 0) log = "Now;Velocità Costante;;L'auto è ferma\n";
					}
					break;
				case 4: //frena
					if(_isOn && Speed != 0)
					{
						_decelera = _accelera = _speedCostante = false;
						_frena = true;
					}
					else
					{
						if(!_isOn) log = "Now;Frena;;Non si può frenare a motore spento\n";
						else if(Speed == 0) log = "Now;Frena;;L'auto è già ferma\n";
					}
					break;
			}
			return retLog ? log : null;
		}

		public void DefaultActions()
		{
			_decelera = true;
			_accelera = _speedCostante = _frena = _accendi = _spegni = false;
		}

		private string Decelera(bool retLog = true) => Rallenta(DecelerazioneBase, retLog);

		/*
		public short TrovaMarciaCorretta()
		{
			foreach(short gear in speedAndAccPerGear.Keys)
			{
				if(Speed <= speedAndAccPerGear[gear].maxSpeed && Speed >= speedAndAccPerGear[gear].minSpeed) return gear;
			}
			short first = speedAndAccPerGear.Keys.First();
			if(Speed < speedAndAccPerGear[first].minSpeed) return (short)(first - 10);
			short last = speedAndAccPerGear.Keys.Last();
			if(Speed > speedAndAccPerGear[last].maxSpeed) return (short)(last + 1);

			throw new Exception("non è stata trovata la marcia corretta");
		}
		 */

		private float AcceleraInterna(float differenza) => Math.Abs(speedAndAccPerGear[_gear].accelerazione * convert_mtPerSec_kmPerH * (170f- differenza*2.5f)/170f);
			/*
			float accC = speedAndAccPerGear[_gear].accelerazione * convert_mtPerSec_kmPerH;
			float diff2 = differenza*2.5f;
			float diff3 = 170f - diff2;
			float div = diff3/170f;
			float ret = accC * div;
			return Math.Abs(ret);
			*/

		private string Accelera(bool retLog = true)
		{
			//acc * (100-(speed-max)*2.5)/100
			//acc * (100-(min-speed)*2.5)/100

			string log = "Accelera;";
			if(Speed < speedAndAccPerGear[_gear].minSpeed)
			{
				//gear:6; min:60; speed:0; calcolo: acc * (100 - ( 60 - 0 ) * 2.5) / 100 = acc* (100 - 60) / 100 = 40% of acc
				Speed += _gear != -1 ? AcceleraInterna(speedAndAccPerGear[_gear].minSpeed-Speed) : AcceleraInterna(-Speed - speedAndAccPerGear[_gear].minSpeed);
				log += $"Velocità: {Speed:0.##} km/h;Accelerazione ridotta, la marcia è troppo alta\n";
			}
			else if(Speed > speedAndAccPerGear[_gear].maxSpeed)
			{
				//gear:6; max:170; speed:180; calcolo: acc * (100 - ( 180 - 170 ) * 2.5) / 100 = acc* (100 - 25) / 100 = 75% of acc
				Speed -= AcceleraInterna(Speed - speedAndAccPerGear[_gear].maxSpeed);
				log += $"Velocità: {Speed:0.##} km/h;Accelerazione insufficiente, la marcia è troppo bassa\n";
			}
			else
			{
				Speed += speedAndAccPerGear[_gear].accelerazione * convert_mtPerSec_kmPerH;
				//se ora è sopra il max dovrei gestirla diversamente, ma vab
				log += $"Velocità: {Speed:0.##} km/h;\n";
			}
			return retLog ? log : null;
		}

		private string SpeedCostante(bool retLog = true)
		{
			//già passato questo: if(_isOn && _gear != 0 && Speed != 0)

			string log = "Velocità costante;";
			if(Speed > speedAndAccPerGear[_gear].maxSpeed)
			{
				Speed -= AcceleraInterna(Speed - speedAndAccPerGear[_gear].maxSpeed);
				log += $"Velocità: {Speed:0.##} km/h;Accelerazione insufficiente, la marcia è troppo bassa\n";
			}
			else log += $"Velocità: {Speed:0.##} km/h;\n";
			return retLog ? log : null;
		}

		private string Frena(bool retLog = true) => Rallenta(FrenataBase, retLog);

		private string Rallenta(float rallenta, bool retLog = true)
		{
			if(!retLog)
			{
				if(Speed == 0) return null;
				rallenta *= -convert_mtPerSec_kmPerH;
				if(Math.Abs(Speed) < rallenta)
					Speed = 0;
				else
					Speed -= rallenta;
				return null;
			}

			string log = rallenta==FrenataBase ? "Frena;" : "Decelera;";
			if(Speed == 0) return log + ";L'auto è già ferma\n";
			rallenta *= -convert_mtPerSec_kmPerH;
			if(Math.Abs(Speed) < rallenta)
			{
				Speed = 0;
				return log + "Velocità: 0 km/h;\n";
			}
			if(Speed < 0) rallenta *= -1;
			Speed -= rallenta;
			return log + $"Velocità: {Speed:0.##} km/h;\n";
		}

		/// <summary>
		/// avanza di 1 secondo oppure quanti secondi inseriti.
		/// </summary>
		/// <remarks>Guarda la proprietà SavePreviousActions.</remarks>
		/// <returns> Ritorna una stringa degli eventi accaduti</returns>
		public string AvanzaTempo(short seconds = 1)
		{
			string logs = "Azione;Risultato;Spiegazione\n";
			logs += seconds + "\n";
			if(_accendi) logs += OnOff(true);
			else if(_spegni) logs += OnOff(false);
			//else if(_accendiSpegni) OnOff(!_isOn);

			while(seconds > 0)
			{
				--seconds;
				//se viene spenta passa prima per default actions
				if(!(_accelera || _speedCostante || _frena) && _decelera) logs += Decelera();
				else if(_accelera) logs += Accelera();
				else if(_speedCostante) logs += SpeedCostante();
				else if(_frena) logs += Frena();

				if(!SavePreviousActions)
					DefaultActions();
				else
					_accendi = _spegni = false;
				logs += seconds + "\n";
			}
			return logs;
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
