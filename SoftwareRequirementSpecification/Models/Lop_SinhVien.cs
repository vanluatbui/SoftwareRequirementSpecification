using System.ComponentModel.DataAnnotations;

namespace SoftwareRequirementSpecification.Models
{
    public class Lop_SinhVien
    {
        [Key]
        public Guid ID { get; set; }
        public Lop Lop { get; set; }
        public User SinhVien { get; set; }
    }
}
