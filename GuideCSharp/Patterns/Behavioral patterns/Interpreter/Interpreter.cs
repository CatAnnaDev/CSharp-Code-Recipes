using System;
namespace GuideCSharp.Patterns.Behavioralpatterns.Interpreter
{
    // https://dl.dropbox.com/s/nt7rv2cj3w32t6f/19303.png
    public class Interpreter
	{
		public Interpreter()
		{
            //Client 
            var divExp5 = new DivExpression(5);
            var divExp7 = new DivExpression(7);
            var orExp = new OrExpression(divExp5, divExp7);
            var andExp = new AndExpression(divExp5, divExp7);

            //21 is divided by 7 or 5?
            bool result1 = orExp.Interpret(21);
            //result1 is true

            //21 is divided by 7 and 5?
            bool result2 = andExp.Interpret(21);
            //result2 is false

            //35 is divided by 7 and 5?
            bool result3 = andExp.Interpret(35);
            //result3 is true

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

        }
    }

    //AbstractExpression
    interface IExpression
    {
        bool Interpret(int i);
    }

    //TerminalExpression
    class DivExpression : IExpression
    {
        readonly int _divider;

        public DivExpression(int divider)
        {
            _divider = divider;
        }

        public bool Interpret(int i)
        {
            return i % _divider == 0;
        }
    }

    //NonTerminalExpression
    class OrExpression : IExpression
    {
        readonly IExpression _exp1;
        readonly IExpression _exp2;

        public OrExpression(
            IExpression exp1, IExpression exp2)
        {
            _exp1 = exp1;
            _exp2 = exp2;
        }

        public bool Interpret(int i)
        {
            return _exp1.Interpret(i) || _exp2.Interpret(i);
        }
    }

    //NonTerminalExpression
    class AndExpression : IExpression
    {
        readonly IExpression _exp1;
        readonly IExpression _exp2;

        public AndExpression(
            IExpression exp1, IExpression exp2)
        {
            _exp1 = exp1;
            _exp2 = exp2;
        }

        public bool Interpret(int i)
        {
            return _exp1.Interpret(i) && _exp2.Interpret(i);
        }
    }
}

