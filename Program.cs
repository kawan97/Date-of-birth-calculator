using System;

namespace Data_of_brth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = Console.ReadLine();
            try { 
                int age =int.Parse(input);
                 if(age>0 && age <= DateTime.Now.Year)  { 
                      age = DateTime.Now.Year - age;
                         if(age !=0)
                             Console.WriteLine("you are "+age + " years old");
                           else
                              Console.WriteLine("you are born in " + DateTime.Now.Year);
                  }
                      else{
                           Console.WriteLine("Sorry you intered wrong number!");
                       }
             Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("you inter a wrong charcarter");
                Console.ReadKey();


            }


        }
    }
}
