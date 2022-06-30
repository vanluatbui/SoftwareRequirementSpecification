using System.ComponentModel.DataAnnotations;

namespace E_learning.Entity
{
    public class TestForm
    {
        [Key]
        public string ID_TestForm { get; set; }
        public string TestFormName { get; set; }
    }
}
