using System;
using System.Collections.Generic;

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
		private short _marcia; //-1 retro, 0 folle, 1->6
		private float _speed;

		//costanti:
		//	min e max marcia
		//	dictionary min[] e max[] velocità in base alla marcia
		//	

		public bool IsOn
		{
			get { return _isOn; }
			set { OnOff(value); }
		}

		public short Marcia
		{
			get { return _marcia; }
			set { SwitchMarcia(value); }
		}

		public float Speed
		{
			get { return _speed; }
			set { SwitchSpeed(value); }
		}

		public Auto()
		{
			_isOn = false;
			_marcia = 0;
			_speed = 0;
		}

		/// <summary>
		/// Switch motore acceso e motore spento.
		/// </summary>
		/// <param name="isOn">Set del motore</param>
		private void OnOff(bool isOn)
		{
			_isOn = isOn;
			//chiamare ??
		}

		private void SwitchMarcia(short marcia)
		{

		}

		private void SwitchSpeed(float speed)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="isOn"></param>
		/// <returns>Se ora è accesa ritorna true, se ora è spenta ritorna false</returns>
		public bool AccendiSpegni(bool isOn)
		{
			IsOn = isOn;
			return _isOn;
		}

	}
}
