namespace Lab_1_Timur.Models;

public class Employee
{
    public int EmployeeCode { get; set; } // Код співробітника
    public string FullName { get; set; }  // ПІБ
    public int Age { get; set; }          // Вік
    public string Gender { get; set; }    // Пол
    public string Address { get; set; }   // Адреса
    public string PhoneNumber { get; set; } // Телефон
    public string PassportData { get; set; } // Паспортні дані
    public int PositionCode { get; set; } // Код посади
    
    public Employee(int employeeCode, string fullName, int age, string gender,
        string address, string phoneNumber, string passportData, int positionCode)
    {
        EmployeeCode = employeeCode;
        FullName = fullName;
        Age = age;
        Gender = gender;
        Address = address;
        PhoneNumber = phoneNumber;
        PassportData = passportData;
        PositionCode = positionCode;
    }
}