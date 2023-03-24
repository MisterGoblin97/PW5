namespace PW5._4
{
    
    interface IShape
    {
        void Draw(int size);
    }
    
    class VerticalLine : IShape
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("I");
            }
        }
    }
   
    class HorizontalLine : IShape
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }
    }
     
    class Square : IShape
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("N ");
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            VerticalLine myVerticalLine = new VerticalLine();
            myVerticalLine.Draw(10);

            HorizontalLine myHorizontalLine = new HorizontalLine();
            myHorizontalLine.Draw(10);

            Square mySquare = new Square();
            mySquare.Draw(10);

            Console.ReadKey(true);
        }
    }
}