using System.ComponentModel.DataAnnotations;

namespace SoftwareRequirementSpecification.Models
{
    public class HinhThuc_Thi_KiemTra
    {
        [Key]
        public Guid ID { get; set; }
        public string TenHinhThuc { get; set; }
    }
}
