namespace QuizMe.Models
{
    public class Question
    {
        public string Body { get; set; }
        public string Image { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(string body, string image, List<string> answers, int correctAnswerIndex)
        {
            Body = body;
            Image = image;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
