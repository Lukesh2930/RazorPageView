using RazorPage.Models;
using System;
using System.Collections.Generic;

namespace RazorPage.Services
{

        public interface IEmployeeRepository
        {
        IEnumerable<Employee> Search(string searchTerm);
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        Employee Update(Employee updatedEmployee);
        Employee Add(Employee newEmployee);
        Employee Delete(int id);

        IEnumerable<DeptHeadCount> EmployeeCountByDept(Dept? dept);
    }
}
