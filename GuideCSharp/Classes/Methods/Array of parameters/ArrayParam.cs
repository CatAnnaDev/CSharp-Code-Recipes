using System;
namespace GuideCSharp.Classes.Methods.Arrayofparameters
{
	public class ArrayParam
	{
		public ArrayParam()
		{
            var calc = new Calc();
            var avg = calc.GetAvg(1, 2, 3, 4);
            //avg is 2.5

            Console.WriteLine("avg = {0}", avg);
        }
	}

    class Calc
    {
        public double GetAvg(params double[] values)
        {
            if (values.Length == 0)
            {
                return 0;
            }

            double sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum / values.Length;
        }
    }
}

