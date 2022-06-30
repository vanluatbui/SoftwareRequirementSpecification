using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Entity
{
    public class Class
    {
        [Key]
        public string ID_Class { get; set; }
        public string ClassName { get; set; }
        public string ID_Semester { get; set; }

        [ForeignKey("ID_Semester")]
        public Semester Semester { get; set; }
    }
}
