namespace PW5._2
{
    interface IHello
    {
        void SayHello();
    }

    class RussianHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет!");
        }
    }
    class EnglishHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
    class UkrainHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Прiвiт!");
        }
    }
    class PolishHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Cześć!");
        }
    }
    class ItalianHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Chao!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IHello> hellos = new List<IHello>();
            hellos.Add(new RussianHello());
            hellos.Add(new EnglishHello());
            hellos.Add(new UkrainHello());
            hellos.Add(new PolishHello());
            hellos.Add(new ItalianHello());

            foreach (var hello in hellos)
            {
                SayHello(hello);
            }

            Console.ReadKey();
        }
        static void SayHello(IHello hello)
        {
            hello.SayHello();
        }
    }
}