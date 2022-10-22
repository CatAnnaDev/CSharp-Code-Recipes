using System;
namespace GuideCSharp.Functions.Arrayofparameters
{
	public class ArrayParam
	{
		public ArrayParam()
		{
            double GetAvg(params double[] values)
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

            var avg = GetAvg(1, 2, 3, 4);
            //avg is 2.5

            Console.WriteLine("{0}", avg);
        }
	}
}

