using System;
namespace GuideCSharp.Patterns.Behavioralpatterns.Command
{
    // https://dl.dropbox.com/s/fltifhz7wvpolw1/19302.png
    public class Command
	{
		public Command()
		{
            //Client
            var bank = new Bank();
            var cPut = new PutCommand(bank);
            var cGet = new GetCommand(bank);
            var client = new BankClient(cPut, cGet);
            client.GetMoney();
            //printed: money to the client
            client.PutMoney();
            //printed: money from the client
        }
    }

    //Invoker
    class BankClient
    {
        readonly ICommand _putCommand;
        readonly ICommand _getCommand;

        public BankClient(ICommand cPut, ICommand cGet)
        {
            _putCommand = cPut;
            _getCommand = cGet;
        }

        public void PutMoney()
        {
            _putCommand.Execute();
        }

        public void GetMoney()
        {
            _getCommand.Execute();
        }
    }

    //Receiver
    class Bank
    {
        public void GiveMoney()
        {
            Console.WriteLine("money to the client");
        }

        public void ReceiveMoney()
        {
            Console.WriteLine("money from the client");
        }
    }

    interface ICommand
    {
        void Execute();
    }

    //ConcreteCommand
    class PutCommand : ICommand
    {
        readonly Bank _bank;

        public PutCommand(Bank bank)
        {
            _bank = bank;
        }

        public void Execute()
        {
            _bank.ReceiveMoney();
        }
    }

    //ConcreteCommand
    class GetCommand : ICommand
    {
        readonly Bank _bank;

        public GetCommand(Bank bank)
        {
            _bank = bank;
        }

        public void Execute()
        {
            _bank.GiveMoney();
        }
    }
}

