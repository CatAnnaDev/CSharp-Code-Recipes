using System;
namespace GuideCSharp.Universialdynamictypes.Calltypemembers
{
	public class CallTypeMembers
	{
		public CallTypeMembers()
		{
            dynamic d = "some string";
            d = d.ToUpper();
            //d is "SOME STRING"
            Console.WriteLine(d);

            d = 3.14;
            var s = d.ToString();
            Console.WriteLine(s);

            s = d.Tostring(); //<- RunTime error
            Console.WriteLine(s);
        }
	}
}

