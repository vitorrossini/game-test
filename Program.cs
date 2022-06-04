using System;

namespace Game_test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the appearance

            Console.Title = "Game_test";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;


            // creating variables

            double num01;
            double num02;
            double num03;

            // Get a conversation going

            Console.WriteLine(" > Hello there! What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine(" > hey there, " + userName + ".That may or may not be a good name, who am i to say? \nMy name is Krotopolous Mike and i am from the future!"); // using \n to make a new line
            Console.WriteLine(" > What is your favorite color?");
            string userColor = Console.ReadLine();
            string redAnswer = "red";

            if (String.Equals(userColor, redAnswer))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" > NO WAY! Red is my favorite color too! Did you know that red is the color at the end of the visible spectrum of light? And that it “stands” next to the orange and opposite of the violet? And that there are at least 23 shades of red? And that red means “beautiful” in Russian? And that sometimes the sky is red at the sunset? And that some geological features are red, such as Grand Canyon? And that their red is cause by hematite or red ochre? And that red is also the color of blood? And that so it connected to sacrifice, danger and courage? And that the red roses are symbols of love and are normally given as a gift on Valentine’s Day? And that this is no surprise since seeing the color red can make your heart beat faster? And that there are no black roses, but the ones that look like black are actually dark red roses? And that according to surveys which were conducted in Europe and in the U.S.A., red is also the color most commonly associated with heat, activity, passion, sexuality, anger, love and joy? And that the red stripes on the United States Flag stand for courage? And that on the other hand in China, India and many other Asian countries it is the color of symbolizing happiness and good fortune? And that chinese brides traditionally wear red wedding dresses for good luck? And that Mars “nickname” the Red Planet? And that this happened because of the reddish color imparted to its surface by the abundant iron oxide present there? And that there are some stars, that their name is “Red Giants”? And that red is associated with flames and fire, but fire isn’t actually red? And that because if that red is considered the color of passion? And that a red lipstick is considered essential for every woman? And that Louboutin shoes have a distinctive bottom which is… red? And that there is also a band named “Red Hot Chilli Peppers”?");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(userColor + " is lame! Red is so much better");
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine(" > Anyways, i'm here because i got to prevent something very terrible to happen. You see, there is this guy who dropped a cup of coffee from the 10th floor and it killed the person who was creating a time travel machine, but was only halfway done on his theory. I can now travel to past only, and i'm doing it quite a lot. I was only a kid when i started my journey.");
            Console.ReadLine();
            Console.WriteLine(" > So, tell me a number now. Any number");

            num01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" > Alright! Now gimme another one. Don't think much, just hit it");

            num02 = Convert.ToDouble(Console.ReadLine());

            double resultTimes = num01 * num02;
            double resultDivision = num01 / num02;
            double resultSqr1 = Math.Sqrt(num01);
            double resultSqr2 = Math.Sqrt(num02);

            Console.WriteLine(" > Did you know that those numbers multiplied are " + resultTimes + " and the division is " + resultDivision + " and the square root of each are respectively " + resultSqr1 + " and " + resultSqr2 + "?");
            Console.ReadLine();
            Console.WriteLine(" > Oh, i see. In that case, give me a third number.");

            num03 = Convert.ToDouble(Console.ReadLine());

            double median = (num01 + num02 + num03) / 3;

            Console.WriteLine(" > That's weird. The median of the numbers you've chosen are " + median + ". But that's now what the genius kid would've answered. Who the hell are you?");
            Console.WriteLine(" > I think it's better to ask you some questions just to be sure. Is that ok?");
            string isThatOk = Console.ReadLine();
            string itsOk = "yes";


            while (!String.Equals(itsOk, isThatOk))
            {

                Console.WriteLine(" > Are you sure? Cause i REALLY need to sort this out");
                isThatOk = Console.ReadLine();


            }

            Console.WriteLine(" > Alright! Let's get to it");

            Console.WriteLine(" > Question 1 - In what decade has the Covid 19 pandemic ended?");
            Console.ReadLine();
            Console.WriteLine(" > Wrong. C'mon, that was supposed to be the easiest! Next one");
            Console.WriteLine(" > Question 2 - What is the new name of  USA after it's fall to North Korea?");
            Console.ReadLine();
            Console.WriteLine(" > WTF? How can you not know this? Oh wait, what year are we? Isn't this 2121?");
            Console.ReadLine();
            Console.WriteLine(" > Ok, let's do this: If you beat me on a dice game, i can get you anywhere you want in the past. Here is your dice, i will throw first.");



            Console.ReadLine();
            Console.WriteLine(" > Ok, gotta go. Bye!");







            Console.ReadKey();



        }
    }
}
