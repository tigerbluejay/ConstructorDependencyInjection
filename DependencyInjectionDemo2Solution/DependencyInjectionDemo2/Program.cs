using DependencyInjectionDemo2;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            // injecting the dependency through EmployeeBL property
            employeeBL.employeeDataObject = new EmployeeDAL();

            List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}",
                    emp.ID, emp.Name, emp.Department);
            }
            Console.ReadKey();
        }
    }
}