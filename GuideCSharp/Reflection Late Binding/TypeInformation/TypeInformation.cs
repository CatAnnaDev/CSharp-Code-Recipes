using System;
namespace GuideCSharp.ReflectionLateBinding.TypeInformation
{
	public class TypeInformation
	{
		public TypeInformation()
		{
            var carType = Type.GetType("Vehicless.Carss") ?? throw new Exception("not found");

            var isClass = carType.IsClass;
            //isClass is True
            var isArray = carType.IsArray;
            //isArray is False
            var isPublic = carType.IsPublic;
            //isPublic is True
            var isSealed = carType.IsSealed;
            //isSealed is False
            var baseType = carType.BaseType?.Name;
            //baseType is "Object"

            Console.WriteLine($"isClass = {isClass}");
            Console.WriteLine($"isArray = {isArray}");
            Console.WriteLine($"isPublic = {isPublic}");
            Console.WriteLine($"isSealed = {isSealed}");
            Console.WriteLine($"baseType = {baseType}");
        }
	}
}

namespace Vehicless
{
    public class Carss { }
}
