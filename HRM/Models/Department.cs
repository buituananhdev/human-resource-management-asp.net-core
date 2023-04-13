using System.ComponentModel.DataAnnotations;
namespace HRM.Models
{
    public class Department
    {
        [Key]
        public string department_id { get; set; } = string.Empty;
        public string department_name { get; set; } = string.Empty;
    }
}
