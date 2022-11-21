namespace QuizMe.Models
{
    public enum VerifyStatus { OK, MissingCorrectAnswer, MissingBody, MissingAnswers}

    public class EditQuestion
    {
        public Question Question { get; set; }
        public int Index { get; set; }
        public bool IsDragOver { get; set; }

        public EditQuestion(int index)
        {
            Question = new Question("", "", new List<string>() { "", "", "", "" }, -1);
            Index = index;
        }

        public VerifyStatus VerifyQuestion()
        {
            if (Question.CorrectAnswerIndex == -1)
            {
                return VerifyStatus.MissingCorrectAnswer;
            }

            if (string.IsNullOrEmpty(Question.Body))
            {
                return VerifyStatus.MissingBody;
            }

            for (int i = 0; i < 4; i++)
            {
                if (string.IsNullOrEmpty(Question.Answers[i]))
                {
                    return VerifyStatus.MissingAnswers;
                }
            }

            return VerifyStatus.OK;
        }
    }
}
