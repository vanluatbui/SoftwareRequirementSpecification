using System.ComponentModel.DataAnnotations;

namespace SoftwareRequirementSpecification.Models
{
    public class Permission
    {
        [Key]
        public Guid ID { get; set; }
        public string Permission_Name { get; set; }
    }
}
