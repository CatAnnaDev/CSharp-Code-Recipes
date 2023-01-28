using System;
namespace GuideCSharp.Patterns.Behavioralpatterns.ChainOfResponsibility
{
    // https://dl.dropbox.com/s/xa8t89d30o9af62/19301.png
    public class ChainOfResponsibility
	{
		public ChainOfResponsibility()
		{
            Ambulance ambulance = new Ambulance(null);
            Police police = new Police(ambulance);
            Firefighter firefighter = new Firefighter(police);
            firefighter.Help(1);
            //printed: call firefighters
            firefighter.Help(2);
            //printed: call the police
            firefighter.Help(3);
            //printed: call an ambulance
        }
    }

    //Handler
    abstract class Rescuer
    {
        protected Rescuer Next { private get; init; }
        protected int Code { private get; init; }

        //HandleRequest()
        public void Help(int code)
        {
            if (Code == code)
            {
                ToHelp();
            }
            else
            {
                Next?.Help(code);
            }
        }

        public abstract void ToHelp();
    }

    //ConcreteHandler
    class Firefighter : Rescuer
    {
        public Firefighter(Rescuer next)
        {
            Next = next;
            Code = 1;
        }

        public override void ToHelp()
        {
            Console.WriteLine("call firefighters");
        }
    }

    //ConcreteHandler
    class Police : Rescuer
    {
        public Police(Rescuer next)
        {
            Next = next;
            Code = 2;
        }

        public override void ToHelp()
        {
            Console.WriteLine("call the police");
        }
    }

    //ConcreteHandler
    class Ambulance : Rescuer
    {
        public Ambulance(Rescuer next)
        {
            Next = next;
            Code = 3;
        }

        public override void ToHelp()
        {
            Console.WriteLine("call an ambulance");
        }
    }
}

