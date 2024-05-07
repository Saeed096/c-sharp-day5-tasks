namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Phonebook phonebook = new Phonebook();

            phonebook.add("saeed" , 1);
            phonebook.add("Ahmed" , 2);
            phonebook.add("Mostafa" , 3);
            phonebook.display();
            int phone = phonebook["saeed"];
            Console.WriteLine(phone);

            phonebook["saeed"] = 100;
            phonebook[2] = "younes";
            phonebook.display();



            //no order change "benefit of dictionary" >> no order in dic -- return what if unfound >> throw exception-- linkedlist "add remove" >> better if no index

        }
    }
}
