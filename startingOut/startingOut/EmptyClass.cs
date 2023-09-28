using System;


namespace startingOut
{
	public class EmptyClass
	{
		static void PaintCar(CarColor cc)
		{
			Console.WriteLine("Ther car was painted {0} with the code {1}",
				cc, (int)cc);
		}

		enum CarColor : byte
		{
			Orange = 1,
			Blue,
			Green,
			Red
		}



		public EmptyClass()
		{
			CarColor car1 = CarColor.Blue;
			PaintCar(car1);
		}
	}
}

