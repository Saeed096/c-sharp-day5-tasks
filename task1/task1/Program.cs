namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Zoo zoo = new Zoo();
            zoo.Add(new Lion(7));
            zoo.Add(new Lion(11));
            zoo.Add(new Sparrow(52));
            zoo.Add(new Pigeon(5));
            zoo.Add(new Pigeon(1));
            Elephant elephant = new Elephant(2);
            Sparrow sparrow = new Sparrow(20);
            zoo.Add(elephant);
            elephant.die();
            sparrow.die();

            Console.WriteLine("Birds ages");
            foreach (Birds item in zoo.Birds) 
            {
                Console.WriteLine(item.Age);
            }

            Console.WriteLine("Mammals ages");
            foreach (Mammals item in zoo.Mammals)
            {
                Console.WriteLine(item.Age);
            }


            Console.WriteLine("Animals ages");
            foreach (Animal item in zoo.Animals)
            {
                Console.WriteLine(item.Age);
            }

        }
    }
}
