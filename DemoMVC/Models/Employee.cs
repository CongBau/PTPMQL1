using System.ComponentModel.DataAnnotations;
namespace First_web_Mvc.Models
{
    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public int Age { get; set; }
    }
}