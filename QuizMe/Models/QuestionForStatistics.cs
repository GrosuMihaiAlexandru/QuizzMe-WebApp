namespace QuizMe.Models
{
    public class QuestionForStatistics
    {
        public string Id { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public List<int> NoOfTimesAnswerWasChosen { get; set; }
    }
}
