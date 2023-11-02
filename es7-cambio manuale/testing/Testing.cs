using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
	internal class Testing
	{
		static void Main()
		{
			//ThrowError();
			//decelera();
			Console.Write(new STest().GetGearMax()); // scrive comunque 6

			Console.ReadKey();
		}
		static void decelera()
		{
			float _speed = -1f; // !! km/h
			float decelerazioneBase = -0.5f; // !! km/h
			if(_speed == 0) return;
			//tende a 0, usare |-20| ?
			if(Math.Abs(_speed) < -decelerazioneBase)
			{
				_speed = 0;
			}
			else
			{
				_speed -= decelerazioneBase;
			}
			Console.Write(_speed);
		}

		static void ThrowError()
		{
			InternalThrowError();
			// con un throw e nessun catch ferma il programma, scrive anche tutto lo stack di chiamate e le righe
			Console.Write("test");
		}
		static void InternalThrowError()
		{
			throw new Exception("testing throw");
		}
	}
	internal class Test
	{
		public const short gearMax = 6; //se una subclass ha invece 7 marcie then con public sovrascrive o da error?
		public short GetGearMax()
		{
			return gearMax;
		}
	}
	internal class STest : Test
	{
		public new const short gearMax = 7;

	}

}
