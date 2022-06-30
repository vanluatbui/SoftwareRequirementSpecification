using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning.Entity
{
    public class Result_Study
    {
        // SET PRIMARY KEY IN ApplicationDbContext.cs
  
        public string ID_Student { get; set; }

        [ForeignKey("ID_Student")]
        public Student Student { get; set; }

        public string ID_Subject { get; set; }

        [ForeignKey("ID_Subject")]
        public Subject Subject { get; set; }

        public string ID_Teacher { get; set; }

        [ForeignKey("ID_Teacher")]
        public Teacher Teacher { get; set; }

        public DateTime UpdateDate { get; set; }
        public double ProficiencyScore { get; set; }
        public double OralScore { get; set; }
        public double Point15Minutes { get; set; }
        public double ScoreCoefficient2 { get; set; }
        public double ScoreCoefficient3 { get; set; }
        public double MediumScore { get; set; }
        public bool  Result { get; set; }
    }
}
