using System;
namespace GuideCSharp.Controlflow.Conditionalstatements.switchcasestatement.Examplewithtuple
{
	public class ExampleWithTuple
	{
		public ExampleWithTuple()
		{
            (int, int) GetPoint()
            {
                return (5, 5);
            }

            string str;
            var point = GetPoint();

            switch (point)
            {
                case (0, 0):
                    str = "(0, 0) point";
                    break;
                case (_, 1):
                    str = $"({point.Item1}, 1) point";
                    break;
                case (1, { } y):
                    str = $"(1, {y}) point";
                    break;
                case ({ } x, { } y) when x == y:
                    str = $"({x}, {y}) point";
                    break;
                default:
                    str = "other point";
                    break;
            }

            Console.WriteLine(str);
            //printed: Short string
        }
    }
}

