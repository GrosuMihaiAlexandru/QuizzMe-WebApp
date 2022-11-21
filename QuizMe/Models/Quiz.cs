namespace QuizMe.Models
{
    public class Quiz
    {
        public string Id { get; set; }
        public string JoinCode { get; set; }
        public string Name { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string BackgroundColor { get; set; }
        public string Description { get; set; }
        public List<Question> Questions { get; set; }

        public Quiz(string name, string description, string primaryColor, string secondaryColor, List<Question> questions)
        {
            Name = name;
            Description = description;
            Questions = questions;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
        }

        public override string ToString()
        {
            return Name + " " + Description;
        }
    }
}
