using System;
namespace startingOut
{
	class ShapeMath
	{
		public static double GetArea(string shape = "",
			double lenght1 = 0,
			double length2 = 0)
		{
			if(String.Equals("rectangle",shape,
				StringComparison.OrdinalIgnoreCase))
			{
				return lenght1 * length2;
			}else if (String.Equals("triangle", shape,
                StringComparison.OrdinalIgnoreCase))
            {
                return lenght1 * (length2 / 2);
            }else if (String.Equals("circle", shape,
                StringComparison.OrdinalIgnoreCase))
            {
                return 3.14159 * Math.Pow(lenght1,2);
			}
			else
			{
				return -1;
			}
        }
	}
}

