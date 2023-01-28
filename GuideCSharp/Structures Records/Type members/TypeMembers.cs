using System;
namespace GuideCSharp.StructuresRecords.Typemembers
{
    struct Setting
    {
        //type field
        public static string Path;

        //type property
        public static int Mode { get; set; }

        //type method
        public static void SetNextMode()
        {
            Mode = (Mode + 1) % 3;
        }
    }

    public class TypeMembers
	{
		public TypeMembers()
		{
            Setting.Path = @"C:\tmp\";
            Setting.Mode = 3;
            Setting.SetNextMode();
            //Setting.Mode is 1

            Console.WriteLine("{0}, {1}", Setting.Mode, Setting.Path);
        }
	}
}

