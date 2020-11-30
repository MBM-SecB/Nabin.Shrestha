using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    public int Id { get; set;}
    
    [Required(ErrorMessage = "We need First Name")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string Surname { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }

    public static List<Employee> GetEmployees()
    {
        // Object initializer
        var employee1 = new Employee { FirstName = "Nabin", Surname = "Shrestha", Address = "NewBaneshwor", Salary = 10011.2 };
        var employee2 = new Employee { FirstName = "Sabin", Surname = "Shrestha", Address = "NewBaneshwor", Salary = 10320.0 };
        var employee3 = new Employee { FirstName = "Sangeer", Surname = "Oli", Address = "Koteshwor", Salary = 1081.0 };
        var employee4 = new Employee { FirstName = "Dipa", Surname = "Singh", Address = "Bakhtapur", Gender = 'F', Salary = 12131.0 };
        var employee5 = new Employee { FirstName = "Raj", Surname = "poudel", Address = "Chitwan", Salary = 23100.0 };
        var employee6 = new Employee { FirstName = "Rockey", Surname = "Gurung", Address = "Old Baneshwor", Salary = 676100.0 };

        var employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6 };
        return employees;
    }
}