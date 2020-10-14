using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        var employees = Employee.GetEmployees();        
        return View(employees);
    }

    public ActionResult Detail(string firstName)
    {
        var employees = Employee.GetEmployees();
        var employee = employees.FirstOrDefault(x => x.FirstName == firstName);
        
        return View(employee);
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