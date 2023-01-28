using System;
using System.Collections.Generic;

namespace GuideCSharp.Patterns.Behavioralpatterns.Mediator
{
    // https://dl.dropbox.com/s/69588z84zs48vhx/19305.png
    public class Mediators
	{
		public Mediators()
		{
            //Client
            var mediator = new SyncMediator();
            var switcher1 = new Switcher(mediator);
            var switcher2 = new Switcher(mediator);
            var switcher3 = new Switcher(mediator);

            switcher1.SetState(true);
            var state2 = switcher2.GetState();
            //state2 is false
            var state3 = switcher3.GetState();
            //state3 is false

            Console.WriteLine(state2);
            Console.WriteLine(state3);

            switcher1.Sync();
            state2 = switcher2.GetState();
            //state2 is true
            state3 = switcher3.GetState();
            //state3 is true

            Console.WriteLine(state2);
            Console.WriteLine(state3);
        }
	}

    abstract class Mediator
    {
        protected readonly List<Switcher> Switchers = new();

        public abstract void Sync(Switcher switcher);

        public void Add(Switcher switcher)
        {
            Switchers.Add(switcher);
        }
    }

    //Colleague
    class Switcher
    {
        bool _state;
        readonly Mediator _mediator;

        public Switcher(Mediator mediator)
        {
            _mediator = mediator;
            mediator.Add(this);
        }

        public void Sync()
        {
            _mediator.Sync(this);
        }

        public bool GetState()
        {
            return _state;
        }

        public void SetState(bool value)
        {
            _state = value;
        }
    }

    //ConcreteMediator
    class SyncMediator : Mediator
    {

        public override void Sync(Switcher switcher)
        {
            var state = switcher.GetState();
            foreach (var curSwitcher in Switchers)
            {
                curSwitcher.SetState(state);
            }
        }
    }
}

