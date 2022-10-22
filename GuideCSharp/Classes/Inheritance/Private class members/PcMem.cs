using System;
using System.Security.Cryptography;

namespace GuideCSharp.Classes.Inheritance.Privateclassmembers
{
	public class PcMem
	{
		public PcMem()
		{
            var square = new Square();
            var uid = square.GetUid();
            //uid is 1
            uid = square.uid; //<- Error

            Console.WriteLine(uid);
        }
	}

    class Shape
    {
        private static int _maxUid;
        private readonly int _uid;

        public int GetUid()
        {
            return _uid;
        }

        public Shape()
        {
            _uid = ++_maxUid;
        }
    }

    class Square : Shape
    {
        public Square()
        {
            uid++; //<- Error
        }
    }
}

