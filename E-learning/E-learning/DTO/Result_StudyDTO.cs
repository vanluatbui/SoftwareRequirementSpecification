using E_learning.Entity;

namespace E_learning.DTO
{
    public class Result_StudyDTO
    {
        public string ID_Student { get; set; }

        public string ID_Subject { get; set; }

        public string ID_Teacher { get; set; }

        public DateTime UpdateDate { get; set; }
        public double ProficiencyScore { get; set; }
        public double OralScore { get; set; }
        public double Point15Minutes { get; set; }
        public double ScoreCoefficient2 { get; set; }
        public double ScoreCoefficient3 { get; set; }
        public double MediumScore { get; set; }
        public bool Result { get; set; }
    }
}
