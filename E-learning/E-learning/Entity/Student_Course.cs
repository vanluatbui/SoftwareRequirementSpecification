using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Entity
{
    public class Student_Course
    {
        // SET PRIMARY KEY IN ApplicationDbContext.cs

        public string ID_Student { get; set; }

        [ForeignKey("ID_Student")]
        public Student Student { get; set; }
        
        public string ID_Course { get; set; }

        [ForeignKey("ID_Course")]
        public Course Course { get; set; }

        public string Status { get; set; }
    }
}
