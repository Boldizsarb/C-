using System;
namespace startingOut
{
	class Animal
	{
		public string name;
		public string sound;
        static int numOfAnimals = 0;// belongs to each object

        public Animal() // constructor
		{
			name = "No name";
			sound = "no sound";
			numOfAnimals++;
		}
		// method overloading again here:
		public Animal(string name = "No name")
		{
			this.name = name;
			this.sound = "No sound";
			numOfAnimals++;
		}
		public Animal(string name ="no name", string sound="no sound") 
		{
			this.name = name; 
			this.sound = sound;
			numOfAnimals++;
		}

		public void MakeSound()
		{
			Console.WriteLine("{0} says {1}", name, sound);
		}

		public static int GetNumAnimals()
		{
			return numOfAnimals;
		}
	}
}

