using Microsoft.AspNetCore.Mvc;
using RazorPage.Models;
using RazorPage.Services;

namespace RazorPage.ViewComponenets
{
    public class HeadCountViewComponent : ViewComponent
    {
        private readonly IEmployeeRepository employeeRepository;

        public HeadCountViewComponent(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IViewComponentResult Invoke(Dept? departmentName = null)
        {
            var result = employeeRepository.EmployeeCountByDept(departmentName);
            return View(result);
        }
    }
}
