using System;
namespace GuideCSharp.Interfaces.Methodsrequirements
{
	public class MethReq
	{
        interface ICar
        {
            bool StartEngine();
            void StopEngine();
        }

        class SportCar : ICar
        {
            private bool _started;

            public bool StartEngine()
            {
                if (_started)
                {
                    return false;
                }

                Console.WriteLine("Engine started");
                _started = true;
                return true;
            }

            public void StopEngine()
            {
                _started = false;
                Console.WriteLine("Engine stopped");
            }
        }

        public MethReq()
		{
            var car = new SportCar();
            car.StartEngine();
            car.StopEngine();
        }
	}
}

