namespace Canarys
{
    internal class Program
    {
        public static void Main(string[] args){
            Employee emp = new Employee();
            emp.id = 101;
            emp.sal = 10000;
            Console.WriteLine($"Employee name: {emp.name}  Employee identity : {emp.id} employee salary : {emp.sal}");
        }

        public class Employee{
            public int sal;
            public int id;
            public string name;

        }
    }
}
