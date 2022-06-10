using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo3
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}
