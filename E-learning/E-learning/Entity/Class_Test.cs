using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Entity
{
    public class Class_Test
    {
        [Key]
        public string ID_Class_Test { get; set; }

        public string ID_Class { get; set; }
        [ForeignKey("ID_Class")]
        public Class Class { get; set; }
        public string  ID_Subject { get; set; }

        [ForeignKey("ID_Subject")]
        public Subject Subject { get; set; }
        
        public string  ID_Teacher { get; set; }

        [ForeignKey("ID_Teacher")]
        public Teacher Teacher { get; set; }

        public string TopicTest { get; set; }
        public string Describe { get; set; }
        public string TestContent { get; set; }
        public DateTime TestDate { get; set; }
        public int TimeForMinutes { get; set; }
        public string Status { get; set; }
        public string ID_File_Exam { get; set; }

        [ForeignKey("ID_File_Exam")]
        public File_Exam File_Exam { get; set; }

        public string ID_TestForm { get; set; }

        [ForeignKey("ID_TestForm")]
        public TestForm TestForm { get; set; }
    }
}
