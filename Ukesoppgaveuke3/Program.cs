namespace Ukesoppgaveuke3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pet> pets = new()
            {
                new Pet("Samba", 10, "Cat", "Fish"),
                new Pet("Merida", 3, "Cat", "Salad"),
                new Pet("Miko", 8, "Dog", "Sausage")
            };
            //pets.Add(new Pet("King", 10, "Parrot", "Bird seed"));
            Menu(pets);
        }

        public static void Menu(List<Pet> pets)
        {
            Console.WriteLine("Virtual pet:");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Menu:\n1. Add pet\n2. Display pets\n3. Feed pets\n4. Exit");
                string inputAnswer = Console.ReadLine();
                bool number = int.TryParse(inputAnswer, out int answer);

                if (number)
                {
                    switch (answer)
                    {
                        case 1:
                            AddPet(pets);
                            break;
                        case 2:
                            Console.Clear();
                            ListPets(pets);
                            break;
                        case 3:
                            FeedPet(pets);
                            break;
                        case 4:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Please enter 1, 2, 3 or 4!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number!");
                }
            }
        }

        public static void AddPet(List<Pet> pets)
        {
            Console.WriteLine("Please enter a pet to add:");

            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Breed:");
            string breed = Console.ReadLine();

            Console.WriteLine("Favorite food:");
            string favoriteFood = Console.ReadLine();

            pets.Add(new Pet(name, age, breed, favoriteFood));
            Console.Clear();
            ListPets(pets);
        }

        public static void FeedPet(List<Pet> pets)
        {
            Console.Clear();
            ListPets(pets);
            Console.WriteLine("What pet do you want to feed?");
            string? nameToFeed = Console.ReadLine();

            Pet? pet = pets.Find(x => x.Name == nameToFeed);
            if (pet == null)
            {
                Console.Clear();
                Console.WriteLine("Unknown pet!");
                return;
            }
            



            Console.WriteLine("What do you want to feed it with?");
            string? food = Console.ReadLine();

            // Bruk av ? for å fjerne blå linjer(kan være satt til null)
            //Pet pet = pets.Find(x => x.Name == nameToFeed);

            if (pet != null)
            {
                if (food == pet.FavoriteFood)
                {
                    pet.Feed(nameToFeed, food);
                }
                else
                {
                    pet.Feed();
                }
            }
            else
            {
                Console.WriteLine("You don't own this pet!");
            }
        }

        public static void ListPets(List<Pet> pets)
        {
            foreach (var pet in pets)
            {
                PetDetails(pet);
            }
        }

        public static void PetDetails(Pet pet)
        {
            Console.WriteLine(
                $"Name: {pet.Name}\nAge: {pet.Age}\nBreed: {pet.Breed}\nFavorite food: {pet.FavoriteFood}");
            Console.WriteLine();
        }
    }
}