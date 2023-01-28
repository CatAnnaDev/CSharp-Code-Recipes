using System;
namespace GuideCSharp.Controlflow.Conditionalstatements.switchcasestatement.Casewhencondition
{
	public class CaseWhenCondition
	{
        record Tiger(int Age);
        public CaseWhenCondition()
		{
            string Describe(object obj)
            {
                //C# 8 feature
                switch (obj)
                {
                    case int i when i > 1_000_000:
                        return "Big number";
                    case string { Length: < 256 }:
                        return "Short string";
                    case Tiger { Age: > 12 }:
                        return "Old tiger";
                    default:
                        return "Unknown type";
                }
            }

            var result = Describe(new Tiger(15));
            Console.WriteLine(result);
            //printed: Old tiger
        }
    }
}

