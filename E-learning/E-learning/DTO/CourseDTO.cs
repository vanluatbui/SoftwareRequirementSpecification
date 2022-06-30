using E_learning.Entity;

namespace E_learning.DTO
{
    public class CourseDTO
    {
        public string ID_Course { get; set; }
        public string Topic { get; set; }
        public string Describe { get; set; }
       
        public string ID_Teacher { get; set; }

        public string ID_Class { get; set; }

        public string ID_Subject { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }

        public int TimeForMinutes { get; set; }
        public string Security { get; set; }
        public string Link { get; set; }
    }
}
