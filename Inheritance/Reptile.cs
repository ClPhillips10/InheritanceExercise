using System;
namespace Inheritance
{
	public class Reptile:Animal
	{
		public Reptile()
		{
		}

        // DONE -- Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class
        public bool HasScales { get; set; }
		public bool IsColdBlooded { get; set; }
		public int NumLegs { get; set; }
		public string Habitat { get; set; }
	}

}

