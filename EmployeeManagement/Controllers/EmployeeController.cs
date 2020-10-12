using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {

        List<Employee> employee = new List<Employee>();
        var employee1 = new Employee
        {
            FirstName = "Nabin",
            SurName = "Shrestha",
            Address = "NewBaneshwor",
            Salary = 120000
        };
        var employee2 = new Employee
        {
            FirstName = "Nabin1",
            SurName = "Shrestha1",
            Address = "NewBaneshwor1",
            Salary = 1200001
        };
        var employee3 = new Employee
        {
            FirstName = "Nabin2",
            SurName = "Shrestha2",
            Address = "NewBaneshwor2",
            Salary = 1200002
        };
        var employees = new List<Employee> { employee1, employee2, employee3 };
        return View(employees);
    }


}
public class Employee
{
    public string FirstName { get; set; }
    public string SurName { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }
}

public