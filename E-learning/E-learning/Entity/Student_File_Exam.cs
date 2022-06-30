using System.ComponentModel.DataAnnotations;

namespace E_learning.Entity
{
    public class Student_File_Exam
    {
        [Key]
        public string ID_Student_File_Exam { get; set; }
        public string StudentFileExamName { get; set; }
        public string StudentFileExamPath { get; set; }
    }
}
