using E_learning.Entity;

namespace E_learning.DTO
{
    public class Class_TestDTO
    {
        public string ID_Class_Test { get; set; }

        public string ID_Class { get; set; }
     
        public string ID_Subject { get; set; }

        public string ID_Teacher { get; set; }

        public string TopicTest { get; set; }
        public string Describe { get; set; }
        public string TestContent { get; set; }
        public DateTime TestDate { get; set; }
        public int TimeForMinutes { get; set; }
        public string Status { get; set; }
      
        public string ID_File_Exam { get; set; }

        public string ID_TestForm { get; set; }
    }
}
