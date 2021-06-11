using System;

namespace MethodExercise
{
    class Program
    {   
        public static double AddThemUp(string request)
        {
            Console.WriteLine($"{request}");
           return double.Parse( Console.ReadLine());
            
        }
        public static void  FinalSum(double addA, double addB, double addC)
        {
            double sum = addA + addB + addC;
            Console.WriteLine($"{addA} + {addB} + {addC} = {sum}");
        }
        public static void FinalDifference(double subA, double subB, double subC)
        {
            double difference = subA + subB + subC;
            Console.WriteLine($"{subA} - {subB} - {subC} = {difference}");
        }
        public static void FinalProduct(double mulA, double mulC)
        {
            double product = mulA * mulC;
            Console.WriteLine($"{mulA} * {mulC} = {product}");
        }
        public static void FinalQuotient(double divA, double divC)
        {
            double quotient = divA / divC;
            Console.WriteLine($"{divA} / {divC} = {quotient}");
        }
        public static void FinalRemainder(double remA, double remC)
        {
            double remainder = remA % remC;
            Console.WriteLine($"{remA} / {remC} has a remainder {remainder}");
        }
        public static void PersonalStory(string favAnimal, string favBand, string favColor, string name)
        {
            Console.WriteLine($"There once was a {favAnimal} named {favBand}.");
            Console.WriteLine($"{favBand} lived in the vast wilds of space where they spent their life drifting through the endless void in a {favColor} vaccuum suit.");
            Console.WriteLine($"Thankfully, the {favColor} atrocity had advanced life support processes that kept {favBand} alive; even with their unique requirements.");
            Console.WriteLine($"Because, contrary to what you may think, space is mostly empty. In fact, {favBand} has never come into contact with another solid object. Ever.");
            Console.WriteLine($"One day, though, that changed. {favBand} drifted close enough to see a planet!");
            Console.WriteLine($"I will name it {name}! It will be full of other {favAnimal}s just like me!");
            Console.WriteLine($"Alass, it was not to be. {favBand} kept drifting on by the planet never getting close enough to enter its gravitational well.");
            Console.WriteLine("THE END");
        }
        public static string StoryInput(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string name = StoryInput("Let's write a story together! What is your name?");
            string favColor = StoryInput("What is your favorite color?");
            string favAnimal = StoryInput("What is your favorite animal?");
            string favBand = StoryInput("What or who is your favorite band?");

            PersonalStory(favAnimal, favBand, favColor, name);

            Console.WriteLine("TIME FOR MATHS!!! First: addition.");

          
            double addA = AddThemUp("Please enter a number.");
         
            double addB = AddThemUp("Enter a second number.");
       
            double addC = AddThemUp("Ok, one more number.");
            FinalSum(addA, addB, addC);

            Console.WriteLine("Second: subtraction");
            double subA = AddThemUp("Please enter a number.");

            double subB = AddThemUp("Enter a second number.");

            double subC = AddThemUp("Ok, one more number.");
            FinalDifference(subA, subB, subC);

            Console.WriteLine("Third: multiplication");
            double mulA = AddThemUp("Please enter a number.");       

            double mulC = AddThemUp("Ok, one more number.");
            FinalProduct(mulA, mulC);

            Console.WriteLine("Fourth: division");
            double divA = AddThemUp("Please enter a number.");

            double divC = AddThemUp("Ok, one more number.");
            FinalQuotient(divA, divC);

            Console.WriteLine("Lastly: remainders");
            double remA = AddThemUp("Please enter a number.");

            double remC = AddThemUp("Ok, one more number.");
            FinalRemainder(remA, remC);
            /*Declare 5 methods:
1 Add method 
1 Subtract method
1 Multiply method
1 Divide method
1 Modulus method
Call each of the methods in your Main() method
*/


        }
    }
}
