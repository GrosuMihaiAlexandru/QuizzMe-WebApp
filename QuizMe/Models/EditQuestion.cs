namespace QuizMe.Models
{
    public class EditQuestion
    {
        public Question Question { get; set; }
        public int Index { get; set; }
        public bool IsDragOver { get; set; }

        public EditQuestion(int index)
        {
            Question = new Question("Question body" + index + " jasd jasdjsa djsa", "", new List<string>() { "Add answer 1", "Add answer 2", "Add answer 3", "Add answer 4" }, -1);
            Index = index;
        }
    }
}
