using System.ComponentModel.DataAnnotations;

namespace E_learning.Entity
{
    public class File_Exam
    {
        [Key]
        public string ID_File_Exam { get; set; }
        public string File_Exam_Name { get; set; }
        public string FileExamPath { get; set; }
    }
}
