using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Entity
{
    public class Student_Test
    {
        // SET PRIMARY KEY IN ApplicationDbContext.cs

        public string ID_Student { get; set; }

        [ForeignKey("ID_Student")]
        public Student Student { get; set; }
        public string ID_Class_Test { get; set; }

        [ForeignKey("ID_Class_Test")]
        public Class_Test Class_Test { get; set; }

        public string Status { get; set; }
        public string ID_Student_File_Exam { get; set; }
        [ForeignKey("ID_Student_File_Exam")]
        public Student_File_Exam Student_File_Exam { get; set; }
    }
}
