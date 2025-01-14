namespace Quiz_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] Questions = new string[]
            {
                "1. what is the captial of Italy ?",
                "2. what is the red planet ?",
                "3. what is the largest animal ?"
            };

            string[] answers = new string[]
            {
                "rome",
                "mars",
                "whale"
            };

            int userScore = 0;

            Console.WriteLine("Welcome to the game");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Please answer the following questions:");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(Questions[i]);

                string userAnswer = Console.ReadLine();

                try
                {
                    bool result = isCorrectAnswer(userAnswer, answers[i]);

                    if (result == true) { Console.WriteLine("Correct answer!");  userScore++; }

                    else Console.WriteLine($"sorry, Incorrect answer, the correct answer is {answers[i]}");
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            Console.WriteLine($"\nYour score is {userScore} of 3");
            Console.WriteLine("Game completed , thank you for playing.");
        }

        private static bool isCorrectAnswer(string userInput, string correctAnswer)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                throw new Exception("Answer cannot be empty.");
            }
            if (userInput == correctAnswer) return true;
            
            else return false;
            
        }
    }
}
