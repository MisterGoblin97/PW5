namespace PW5
{
    
    interface IAnimal
    {
        void Voice();
    }
    
    class Frog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Ква!");
        }
    }
    
    class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Гав!");
        }
    }
   
    class Cat : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Мяу!");
        }
    }

   
    class Ram : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Мээ!");
        }
    }
    
    class Sparrow : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Чирик!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> myAnimals = new List<IAnimal>();

            myAnimals.Add(new Frog());
            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Ram());
            myAnimals.Add(new Sparrow());

            foreach (IAnimal animal in myAnimals)
            {
                PetAnimal(animal);
            }

            Console.ReadKey(true);
        }

        static void PetAnimal(IAnimal animal)
        {
            Console.WriteLine("Мы гладим зверушку, а она нам говорит:");
            animal.Voice();
        }
    }
}
