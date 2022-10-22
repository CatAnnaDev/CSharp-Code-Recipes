using System;
namespace GuideCSharp.Controlflow.Conditionalstatements.switchcasestatement.Differenttypesofvalues
{
	public class DiffTypeVal
	{
		public DiffTypeVal()
		{
            string Describe(object obj)
            {
                //C# 8 feature
                switch (obj)
                {
                    case 2:
                        return "two";
                    case Tiger:
                        return "Tiger!!!";
                    case "Error":
                        return "Error string";
                    case int:
                        return "Int type";
                    case string s:
                        return $"string value {s}";
                    default:
                        return "Unknown type";
                }
            }

            var result = Describe(new Tiger());
            Console.WriteLine(result);
            //printed: Tiget!!!
        }
    }

    class Tiger { }
}

