using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Phonebook
    {
        List<KeyValue> list = new List<KeyValue>();
        public Phonebook() 
        {
           
        }

        public void add(KeyValue keyValue)
        {
            list.Add(keyValue);
        }

        public void display()
        {
            for (int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine($"key is {list[i].Key} and value is {list[i].Value}");
            }
        }
        public int this [string name] 
        {
            get
            {
               for(int i = 0; i < list.Count; i++) 
                {
                  if (list[i].Key == name)
                    {
                        return list[i].Value;
                    }
                }
                return -1;               // right to return -1?????   throw exception better
            }

            set
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Key == name)
                    {
                        list.RemoveAt(i);
                        KeyValue updatedVariable = new KeyValue();
                        updatedVariable.Key = name;
                        updatedVariable.Value = value;
                        list.Add(updatedVariable);

                        //list[i].Value = value;       // why cannot modify in struct ?? struct is value type >> u have copy >> cannot modify
                    }
                }
            }
        }


        public string this[int number]
        {
            get
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Value == number)
                    {
                        return list[i].Key;
                    }
                }
                return "not found";
            }

            set
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Value == number)
                    {
                        list.RemoveAt(i);
                        KeyValue updatedVariable = new KeyValue();
                        updatedVariable.Key = value;
                        updatedVariable.Value = number;
                        list.Add(updatedVariable);

                    }
                }
            }
        }

    }
}
