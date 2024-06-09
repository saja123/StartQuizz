namespace StartQuizz
{
    public class Program
    {
        static void StartQuizz()
        {
            var questions = new List<string>() { "What's the city of Franch?", "What is the name of our solar system?", "What is the name of the sword in the sword in the stone?", "How many planets are there in the solar system?", "Who discovered the law of gravity?" };
            var answers = new List<string>() { "paris", "Solar System", "Excalibur", "8", "Newton" };
            int Score = 0;
            for (int i = 0; i < questions.Count; i++) {
                Console.WriteLine(questions[i]);
                bool answer = false;
                while (!answer) {
                    Console.WriteLine("Dear user, your answer is:");
                    string userInput = Console.ReadLine();
                    if (!string.IsNullOrEmpty(userInput))
                    {
                        if (userInput.Equals(answers[i]))
                        {
                            Score++;
                            answer = true;


                        }
                        else {
                            Console.WriteLine("Please Try Again");
                        }
                    }
                    else {
                        Console.WriteLine("Your Answer is Invalid!");
                    }
                }
            
            }
            Console.WriteLine($"Your Score is : {Score}");
        }
        static void Main(string[] args)
        {
            try
            {
                StartQuizz();

            }
            catch (Exception ex) {
                Console.WriteLine($"The Error Is: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank You For Testing");
            }
        }
    }
}
