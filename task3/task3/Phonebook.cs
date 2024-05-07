using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Phonebook
    {
        //List<KeyValue> list = new List<KeyValue>();
        Dictionary<string , int> Enteries = new Dictionary<string , int>();
       
        public Phonebook()
        {

        }

        public void add(string key , int value)
        {
            Enteries.Add(key , value);
            //list.Add(keyValue);
        }


        public void display()
        {
            foreach (KeyValuePair<string , int> item in Enteries)
            {
                Console.WriteLine($"key is {item.Key} and value is {item.Value}");
            }
        }

        public int this[string name]
        {
            get
            {
                foreach (KeyValuePair<string , int> item in Enteries)
                {
                    if (item.Key == name)
                    {
                        return item.Value;
                    }
                }
                return -1;
            }

            set
            {
                foreach (KeyValuePair<string, int> item in Enteries)
                {
                    if (item.Key == name)
                    {
                        Enteries[item.Key] = value;
                    }
                }
            }
        }


        public string this[int number]
        {
            get
            {
                foreach (KeyValuePair<string, int> item in Enteries)
                {
                    if (item.Value == number)
                    {
                        return item.Key;
                    }
                }
                return "not found";
            }

            set
            {
                KeyValuePair<string, int> temp = new KeyValuePair<string, int>();
                foreach (KeyValuePair<string, int> item in Enteries)
                {
                    if (item.Value == number)
                    {
                        temp = item;
                        //list[i].Value = value;
                        //Console.WriteLine(x);
                    }
                }
                if (temp.Key != null)
                {
                    Enteries.Remove(temp.Key);
                    Enteries.Add(value, temp.Value);
                }
                
            }

        }

        //public void this[string name]
        //{
        //    set
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i].Value == name)
        //            {
        //                list[i].Key = value;
        //            }
        //        }
        //    }
        //}

    }
}
