using System.ComponentModel.DataAnnotations;

namespace HRM.Models
{
    public class User
    {
        [Key]
        public string user_id { get; set; } = string.Empty;
        public string user_name { get; set; } = string.Empty;
        public string department_id { get; set; } = string.Empty; 
    }
}
