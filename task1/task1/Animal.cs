using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
      internal abstract class Animal
    {
        public Action<Animal>AnimalDied;
        public int Age { get; set; }

       public void die()
        {
            if(AnimalDied != null) 
            { 
               AnimalDied(this);
            }
        }
    }
}
