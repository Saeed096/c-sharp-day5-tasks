using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Zoo
    {
        List<Animal> AnimalsList = new List<Animal>();

        public IEnumerable<Animal> Animals                                   
        {
            get
            {
                return AnimalsList;
            }

        }

        public IEnumerable<Birds> Birds                                   
        {
            get 
            {
               List <Birds> Birds = new List<Birds>();
               for(int i = 0; i < AnimalsList.Count; i++)
                {
                    if (AnimalsList[i] is  Birds)
                    {
                        Birds.Add((Birds)AnimalsList[i]);
                    }
                }
               return Birds;
            }
            
        }



        public IEnumerable<Mammals> Mammals       //mammals itself should implement IEnumerable not its return???  from main >> zoo.mammals >> i care that i have IEnumerable obj even mammals itself is list or itis a property "func" its return implement IEnumerable
        {
            get
            {                                                                     
                List<Mammals> Mammals = new List<Mammals>();
                for (int i = 0; i < AnimalsList.Count; i++)
                {
                    if (AnimalsList[i] is Mammals)
                    {
                        Mammals.Add((Mammals)AnimalsList[i]);
                    }
                }
                return Mammals;
            }

        }

        public Zoo()
        {
          
        }

        public void Add(Animal animal) 
        {
            if (animal.Age <= 10)
            {
                AnimalsList.Add(animal);
                animal.AnimalDied = removeDeadAnimal;
                    
            }
        }

        
        public void removeDeadAnimal(Animal animal)
        {
            AnimalsList.Remove(animal);       
        }

        public void display ()
        {
            for (int i = 0; i < AnimalsList.Count; i++)
            {
                Console.WriteLine(AnimalsList[i].Age);
            }
        }
    }
}
