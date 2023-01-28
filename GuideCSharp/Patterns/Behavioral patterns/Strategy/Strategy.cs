using System;
namespace GuideCSharp.Patterns.Behavioralpatterns.Strategy
{
    // https://dl.dropbox.com/s/g5rlwo06cgnjfiw/19309.png
    public class Strategy
	{
		public Strategy()
		{
            //Client
            var calc = new Calc();
            int result1 = calc.Execute(5, 3);
            //result1 is 0

            calc.SetStrategy(new AddStrategy());
            int result2 = calc.Execute(5, 3);
            //result2 is 8

            calc.SetStrategy(new SubtractStrategy());
            int result3 = calc.Execute(5, 3);
            //result3 is 2

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
	}

    interface IStrategy
    {
        int DoOperation(int a, int b);
    }

    //ConcreteStrategy
    class AddStrategy : IStrategy
    {
        public int DoOperation(int a, int b)
        {
            return a + b;
        }
    }

    //ConcreteStrategy
    class SubtractStrategy : IStrategy
    {
        public int DoOperation(int a, int b)
        {
            return a - b;
        }
    }

    //Context
    class Calc
    {
        IStrategy _strategy;

        public int Execute(int a, int b)
        {
            if (_strategy == null)
            {
                return 0;
            }

            return _strategy.DoOperation(a, b);
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
    }
}

