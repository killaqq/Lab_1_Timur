using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab_1_Timur.Models;

namespace Lab_1_Timur.Controllers;

public class EmployeeController : Controller
{
    private static List<Employee> _employees = new List<Employee>
    {
        new Employee(1, "Іванов І.І.", 30, "Чоловік", "Київ, вул. Шевченка, 1", "0501234567", "AA123456", 101),
        new Employee(2, "Петрова О.В.", 25, "Жінка", "Київ, вул. Хрещатик, 5", "0677654321", "BB765432", 102),
        new Employee(3, "Сидоров В.А.", 40, "Чоловік", "Київ, вул. Банкова, 10", "0939876543", "CC987654", 101)
    };

    // GET: /Employee/Index
    public IActionResult Index()
    {
        return View(_employees);
    }

    // GET: /Employee/Details/1
    public IActionResult Details(int id)
    {
        var employee = _employees.FirstOrDefault(e => e.EmployeeCode == id);
        if (employee == null)
        {
            return NotFound();
        }
        return View(employee);
    }
}