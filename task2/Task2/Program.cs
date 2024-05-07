namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Phonebook phonebook = new Phonebook();
            KeyValue key_value = new KeyValue { Key = "saeed", Value = 1 };
            KeyValue key_value2 = new KeyValue { Key = "Ahmed", Value = 2 };
            KeyValue key_value3 = new KeyValue { Key = "Mostafa", Value = 3 };

            phonebook.add(key_value);
            phonebook.add(key_value2);
            phonebook.add(key_value3);
            phonebook.display();
            int phone = phonebook["saeed"];
            Console.WriteLine(phone);

            phonebook["saeed"] = 100;
            phonebook[3] = "khaled";
            phonebook.display();


           
            // order change "make it class better?? and there is no order here or in dictionary -- linkedlist "add remove" >> till next == null?? better if u dont need index

        }
    }
}
