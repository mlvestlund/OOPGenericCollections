using System.Net.NetworkInformation;

namespace OOPGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Namn: Maria Vestlund, Klass: NET23 */


            /***** DEL 1 *****/

            //Creates 5 employee objects
            Employee employee1 = new Employee("101", "Anas", "Male", 20000);
            Employee employee2 = new Employee("102", "Hanna", "Female", 30000);
            Employee employee3 = new Employee("103", "Tobias", "Male", 40000);
            Employee employee4 = new Employee("104", "Sara", "Female", 40000);
            Employee employee5 = new Employee("105", "Anna", "Female", 50000);

            //A stack with the 5 employees
            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            //loop to print out all objects in the stack
            foreach (Employee employee in employeeStack)
            {
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                Console.WriteLine($"Items left in the Stack = {employeeStack.Count}");
            }

            Console.WriteLine("------------------------------");

            Console.WriteLine("Retrive Using Pop Method");

            //loop that retrieves all objects from the stack (LIFO - Last In, First Out)
            while (employeeStack.Count > 0)
            {
                Employee employee = employeeStack.Pop();
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                Console.WriteLine($"Items left in the Stack = {employeeStack.Count}");
            }

            //pushes back objects into the stack again
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine("------------------------------");

            Console.WriteLine("Retrive Using Peek Method");

            //peeks twice on the top object, the last pushed object, in the stack
            for (int i = 0; i < 2; i++)
            {
                Employee employee = employeeStack.Peek();
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                Console.WriteLine($"Items left in the Stack = {employeeStack.Count}");
            }

            Console.WriteLine("------------------------------");

            //Checks if employee3 is in the stack
            bool employee3ContainsInStack = employeeStack.Contains(employee3);
            
            if (employee3ContainsInStack)
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }

            Console.WriteLine("\n");


            /***** DEL 2 *****/

            //Creates a list and adds the employees to it
            List<Employee> employeeList = new List<Employee>() { employee1, employee2, employee3, employee4, employee5 };

            //Checks if employee2 is in the list
            bool employee2ContainsInList = employeeList.Contains(employee2);

            if (employee2ContainsInList)
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }

            Console.WriteLine();

            //Finds first object with gender "Male" and prints it out
            Employee firstMaleEmployee = employeeList.Find(employee => employee.Gender == "Male");
            Console.WriteLine($"ID = {firstMaleEmployee.Id}, Name = {firstMaleEmployee.Name}, Gender = {firstMaleEmployee.Gender}, Salary = {firstMaleEmployee.Salary}");
            
            Console.WriteLine();

            //Finds all objects with gender "Male" and prints them out
            List<Employee> allMaleEmployees = employeeList.FindAll(employee => employee.Gender == "Male");

            foreach (Employee maleEmployee in allMaleEmployees)
            {
                Console.WriteLine($"ID = {maleEmployee.Id}, Name = {maleEmployee.Name}, Gender = {maleEmployee.Gender}, Salary = {maleEmployee.Salary}");
            }
        }
    }
}