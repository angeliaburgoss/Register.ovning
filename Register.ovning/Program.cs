using System.Collections;

namespace Register.ovning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList register = new ArrayList();
            //Run run = new Run();
            Console.WriteLine("Choose one of following options");
            Console.WriteLine("1. Add employees");
            Console.WriteLine("2. Show employees salary");
            Console.WriteLine("3. Quit");

            string command = Console.ReadLine();    

            switch (command)
            {
                case "1":
                    Console.WriteLine("Enter a name");
                        string name = Console.ReadLine();
                    Console.WriteLine("Enter salary for" + name);
                        string salary = Console.ReadLine();
                    Employee e = new Employee(name, salary);
                    register.Add(e);    
                    break;

                case "2":
                    for(int i =0; i < register.Capacity; i++)
                    {
                        register.
                    }
                    


            }
        }
    }

    class Employee{

        public string name;
        public string salary;

        public Employee(string name, string salary)
        {
            this.name = name;
            this.salary = salary;
        }


    }

  /*  class Run
    {
       public Employee register;


        public Run()
        {
            register = new ArrayList();
        }
         void program()
        {
            Console.WriteLine("Choose one of following options");
            Console.WriteLine("1. Add employees");
 //           Console.WriteLine("2. Show employees salary");
  //          Console.WriteLine("3. Quit");
//



        }
    }*/
    
}
