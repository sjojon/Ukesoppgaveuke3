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


        public void Feed()
        {
            Console.Clear();
            Console.WriteLine($"Takk for maten!");
            Console.WriteLine();
        }

        public void Feed(string name, string food)
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