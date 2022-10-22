using System;
namespace GuideCSharp.Classes.Inheritance.SealedClass
{
	public class SealedClass
	{
		public SealedClass()
		{
		}
	}

    class Shape { }

    sealed class Square : Shape { }

    //class RedSquare : Square { } //<- error
}

