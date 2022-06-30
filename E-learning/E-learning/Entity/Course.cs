using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Entity
{
    public class Course
    {
             [Key]
            public string ID_Course { get; set; }
            public string Topic { get; set; }
            public string Describe { get; set; }
            public string ID_Teacher { get; set; }
          
            [ForeignKey("ID_Teacher")]
            public Teacher Teacher { get; set; }

           public string ID_Class { get; set; }

           [ForeignKey("ID_Class")]
           public Class Class { get; set; }

            public string ID_Subject { get; set; }

             [ForeignKey("ID_Subject")]
            public Subject Subject { get; set; }
            public DateTime StartDay { get; set; }
            public DateTime EndDay { get; set; }
  
            public int TimeForMinutes { get; set; }
            public string Security { get; set; }
            public string Link { get; set; }
    }
}
