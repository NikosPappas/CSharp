// See https://aka.ms/new-console-template for more information
List<Question> questions = new List<Question>()
        {
            new Question("What is the capital of France?", "Paris"),
            new Question("What is 2 + 2?", "4"),
            new Question("What is the largest planet in our solar system?", "Jupiter"),
            new Question("Who painted the Mona Lisa?", "Leonardo da Vinci"),
             new Question("What is the chemical symbol for gold?", "Au")
        };

int score = 0;
Console.WriteLine("Welcome to the Simple Quiz!");
foreach(Question question in questions){
    Console.WriteLine("\n "+question.Text);
    string userAnswer=Console.ReadLine();
    if (userAnswer.Trim().Equals(question.CorrectAnswer, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Correct!");
        score++;
    }else
    {
        Console.WriteLine("Incorrect. The correct answer was: " + question.CorrectAnswer);
    }

}
Console.WriteLine("\nQuiz finished!");
Console.WriteLine("Your final score: " + score + " out of " + questions.Count);