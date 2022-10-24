using System;
namespace GuideCSharp.Interfaces.Conformancecheckingisas
{
	public class ConfCheck
	{
        interface IUid
        {
            int Id { get; }
        }

        interface INamed
        {
            string Name { get; }
        }

        struct Flower : INamed
        {
            public string Name { get; set; }
        }

        public ConfCheck()
		{
            var rose = new Flower { Name = "Rose" };
            var isPId = rose is IUid;
            //isPId is False

            var isNamed = rose is INamed;
            //isNamed is True

            var pName = rose as INamed;
            var name = pName.Name;
            //name is "Rose"

            Console.WriteLine("{0}, {1}, {2}", isPId, isNamed, name);
        }
	}
}

