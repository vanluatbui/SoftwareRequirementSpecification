using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Entity
{
    public class Student
    {
        [Key]
        public string ID_Student { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
         public string Phone { get; set; }
    }
}
