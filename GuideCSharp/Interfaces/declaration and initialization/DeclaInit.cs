using System;
namespace GuideCSharp.Interfaces.declarationandinitialization
{
	public class DeclaInit
	{
        interface IPrintable
        {
            void Print();
        }

        public DeclaInit()
		{
            // var printable = new IPrintable(); //<- Error
        }
    }
}

