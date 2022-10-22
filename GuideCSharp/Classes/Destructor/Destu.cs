using System;
namespace GuideCSharp.Classes.Destructor
{
	public class Destu
	{
        //It called automatically
        //when class instance is deallocated

        ~Destu()
        {
            //release allocated resources
            //eg close the connection to the database,
            //close files, etc.
        }
    }
}

