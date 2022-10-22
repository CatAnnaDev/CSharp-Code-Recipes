using System;
using System.Runtime.Serialization;

namespace GuideCSharp.Exceptionshandling.Defineanexceptiontype
{
	public class DefineExcType
	{
		public DefineExcType()
		{
            throw new SimpleException();

            throw new RecommendExc("exeption");
        }
	}

    class SimpleException : Exception { }

    class RecommendExc : Exception
    {
        //recommended constructors
        public RecommendExc() { }
        public RecommendExc(string message) : base(message) { }
        public RecommendExc(string message, Exception inner) : base(message, inner) { }
        protected RecommendExc(SerializationInfo info, StreamingContext context) : base(info, context) { }

        //... any other members
    }
}

