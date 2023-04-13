using System.ComponentModel.DataAnnotations;

namespace HRM.Models
{
    public class Employee
    {
        [Key]
        public string employee_id { get; set; } = string.Empty;
        public string employee_name { get;set; } = string.Empty;
        public string phone_number { get;set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public double coefficients_salary { get;set; }
        public double base_salary { get; set; }
        public string position { get; set; } = string.Empty;
        public string department_id { get; set; } = string.Empty;
    }
}
