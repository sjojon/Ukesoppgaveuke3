namespace Ukesoppgaveuke3
{
    internal class Pet
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Breed { get; private set; }
        public string FavoriteFood { get; private set; }

        public Pet(string newName, int newAge, string newBreed, string newFavoriteFood)
        {
            Name = newName;
            Age = newAge;
            Breed = newBreed;
            FavoriteFood = newFavoriteFood;
        }


        public void
            Feed() // Når denne er static, må man hente ut "klassen" mens når den er non-static, kan man bruke instansen?
            // Pet.Feed() Vs pet.Feed()
        {
            Console.Clear();
            Console.WriteLine($"Takk for maten!");
            Console.WriteLine();
        }

        public void Feed(string name, string food) //overload riktig måte?
        {
            if (name == Name && food == FavoriteFood)
            {
                Console.Clear();
                Console.WriteLine($"Dette er det beste jeg vet!!");
                Console.WriteLine();
            }
        }
    }
}

// static
// overload
// spørsmålstegn