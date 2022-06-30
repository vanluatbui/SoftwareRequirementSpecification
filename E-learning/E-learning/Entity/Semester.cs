using System.ComponentModel.DataAnnotations;

namespace E_learning.Entity
{
    public class Semester
    {
        [Key]
        public string ID_Semester { get; set; }

        public string SemesterName { get; set; }
    }
}
