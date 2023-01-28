using System;
using System.Collections.Generic;

namespace GuideCSharp.Patterns.Behavioralpatterns.Observer
{
    // https://dl.dropboxusercontent.com/s/bb1y8zalyt57eo9/19307.png
    public class Observer
	{
		public Observer()
		{
            //Client
            var observer1 = new TextObserver("IObserver #1");
            var observer2 = new TextObserver("IObserver #2");

            TextEdit textEdit = new TextEdit();
            textEdit.Attach(observer1);
            textEdit.Attach(observer2);

            textEdit.SetText("test text");
            //printed:
            //IObserver #1: test text
            //IObserver #2: test text
        }
    }

    interface IObserver
    {
        void Update(string state);
    }

    //ConcreteObserver
    class TextObserver : IObserver
    {

        readonly string _name;

        public TextObserver(string name)
        {
            _name = name;
        }

        public void Update(string state)
        {
            Console.WriteLine(_name + ": " + state);
        }
    }

    //Subject
    abstract class TextSubject
    {
        readonly List<IObserver> _observers = new();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        protected void Notify(string state)
        {
            foreach (var observer in _observers)
            {
                observer.Update(state);
            }
        }
    }

    //ConcreteSubject
    class TextEdit : TextSubject
    {
        string _text = "";

        //SetState(State)
        public void SetText(string text)
        {
            _text = text;
            Notify(text);
        }

        public string GetText()
        {
            return _text;
        }
    }
}

