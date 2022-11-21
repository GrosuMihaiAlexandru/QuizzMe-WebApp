namespace QuizMe.Models
{
    public class QuizForStatistics
    {
        public string JoinCode { get; set; }
        public string Name { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string BackgroundImage { get; set; }
        public string MainImage { get; set; }
        public string Description { get; set; }
        public List<QuestionForStatistics> Questions { get; set; }
        public int NoOfSubmittedAnswers { get; set; }

        public override string ToString()
        {
            return Name + " " + Description;
        }
    }
}
