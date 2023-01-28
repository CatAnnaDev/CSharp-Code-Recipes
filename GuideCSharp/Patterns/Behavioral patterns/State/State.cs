using System;
namespace GuideCSharp.Patterns.Behavioralpatterns.State
{
    // https://dl.dropbox.com/s/1ly53x7nog9m7k7/19308.png
    public class State
	{
		public State()
		{
            //Client
            var con = new Connection();
            con.Open();
            //printed: open the connection
            con.Open();
            //printed: connection is already open
            con.Close();
            //printed: close the connection
            con.Close();
            //printed: connection is already closed
        }
    }

    interface IState
    {
        void Open(Connection c);
        void Close(Connection c);
    }

    //ConcreteState
    class CloseState : IState
    {
        public void Open(Connection c)
        {
            Console.WriteLine("open the connection");
            c.SetState(new OpenState());
        }

        public void Close(Connection c)
        {
            Console.WriteLine("connection is already closed");
        }
    }

    //ConcreteState
    class OpenState : IState
    {
        public void Open(Connection c)
        {
            Console.WriteLine("connection is already open");
        }

        public void Close(Connection c)
        {
            Console.WriteLine("close the connection");
            c.SetState(new CloseState());
        }
    }

    //Context
    class Connection
    {
        IState _state = new CloseState();

        public void Open()
        {
            _state.Open(this);
        }

        public void Close()
        {
            _state.Close(this);
        }

        public void SetState(IState state)
        {
            _state = state;
        }
    }
}

