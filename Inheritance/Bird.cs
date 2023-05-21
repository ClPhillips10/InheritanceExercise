using System;
namespace Inheritance
{
	public class Bird:Animal
		
	{
		public Bird()
		{
			NumberOfLegs = 2;
			IsHairy = true;
			CanFly = true;
		}
        // DONE -- Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
        public string WingColor { get; set; }
		public bool IsLarge { get; set; }
		public bool Migrate { get; set; }
		public string LandSeaAir { get; set; }

	}
}

