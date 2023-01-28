using System;
namespace GuideCSharp.Patterns.Structuralpatterns.Facade
{
	public class Facade
	{
		public Facade()
		{
            var kettle = new Kettle();
            var toaster = new Toaster();
            var refrigerator = new Refrigerator();
            var kitchen = new Kitchen(kettle, toaster, refrigerator);
            kitchen.Off();
        }
	}

    // Complex parts
    class Kettle
    {
        public void turnOff()
        {
            Console.WriteLine("Kettle turn off");
        }
    }

    class Toaster
    {
        public void turnOff()
        {
            Console.WriteLine("Toaster turn off");
        }
    }

    class Refrigerator
    {
        public void turnOff()
        {
            Console.WriteLine("Refrigerator turn off");
        }
    }

    //Facade
    class Kitchen
    {
        readonly Kettle _kettle;
        readonly Toaster _toaster;
        readonly Refrigerator _refrigerator;

        public Kitchen(Kettle kettle, Toaster toaster,
            Refrigerator refrigerator)
        {
            _kettle = kettle;
            _toaster = toaster;
            _refrigerator = refrigerator;
        }

        public void Off()
        {
            _kettle.turnOff();
            _toaster.turnOff();
            _refrigerator.turnOff();
        }
    }

}

