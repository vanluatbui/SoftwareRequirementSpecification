using System.ComponentModel.DataAnnotations;

namespace E_learning.Entity
{
    public class Subject
    {
        [Key]
        public string ID_Subject { get; set; }

        public string SubjectName { get; set; }
    }
}
