using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON4Beginners
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our JSON tutorial! Today we will store some animal's information as a JSON Object \n");
             
            Console.WriteLine("How many animals would you like to store? Please type a number, otherwise this program will crash :( \n");

            int animalQty;
    
            try
            {
                animalQty = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("I told you it was going to crash, here it comes");
                Console.ReadKey();
                throw;
            }
            

            Console.WriteLine("Alright, let's add {0} animals! \n ", animalQty);

            List<Animal> listOfanimals = new List<Animal>();

            for (int i = 1; i <= animalQty; i++)
            {
                Animal animal = new Animal();

                Console.WriteLine("\n {0}) Name:",i);
                animal.Name = Console.ReadLine();
                Console.WriteLine("\n {0}) Where does the {1} live?:",i,animal.Name);
                animal.Habitat = Console.ReadLine();
                Console.WriteLine("\n {0}) What does {1} like to eat?:",i, animal.Name);
                animal.Food = Console.ReadLine();

                Console.WriteLine("Great! \n \n");

                listOfanimals.Add(animal);

            }
            Console.WriteLine("Let's take a look at our *serialized* JSON list of Animals: \n");

            //Transforming a List<Animal> into a JSON string.
            var jsonAnimals = JsonConvert.SerializeObject(listOfanimals);

            Console.WriteLine(jsonAnimals + "\n");
            Console.WriteLine("As you can see, our List of Animals object was serialized into a JSON string! \n");
            Console.ReadKey();
 
            Console.WriteLine("OK! Let's now take that JSON string and then transform it into a .NET object, using the DeserializeObject method. \n");


            //Taking that JSON string and transforming back to a .NET Object
            List<Animal> animalsDeserialized = JsonConvert.DeserializeObject<List<Animal>>(jsonAnimals);

            foreach (Animal singleAnimal in animalsDeserialized)
            {
                Console.Write(singleAnimal);
            }

            Console.ReadKey();
        }
    }

    class Animal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string Food { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}  ||  Lives in: {1}   ||  Like to eat: {2} \n",Name,Habitat,Food);
        }
    }
}
