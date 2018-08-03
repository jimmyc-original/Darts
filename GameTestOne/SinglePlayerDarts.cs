using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SinglePlayerDarts
{
  
    public class Game 
    {
        private static int counter = 501;
       
        static void Main(string[] args)
        {
                  
            int totalScore = 501;
            while (counter > 0)
            {

                //problem if enter pushed multiple times it just bombs out

                Console.WriteLine("**************************************************************************************************************");
                Console.WriteLine("**   88888888ba,        db        88888888ba 888888888888 ad88888ba                                         **");
                Console.WriteLine("**   88      `*8b      d88b       88      *8b     88     d8*     *8b                                        **");
                Console.WriteLine("**   88        `8b    d8'`8b      88      ,8P     88     Y8,                                                **");
                Console.WriteLine("**   88         88   d8'  `8b     88aaaaaa8P'     88     `Y8aaaaa,                                          **");
                Console.WriteLine("**   88         88  d8YaaaaY8b    88****88'       88       `*****8b,                                        **");
                Console.WriteLine("**   88         8P d8********8b   88    `8b       88             `8b                                        **");
                Console.WriteLine("**   88       .a8P d8'       `8b  88     `8b      88     Y8a     a8P                                        **");
                Console.WriteLine("**   88888888Y*' d8'          `8b 88      `8b     88      *Y88888P*                                         **");
                Console.WriteLine("**************************************************************************************************************");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("**************************************************************************************************************");
                Console.WriteLine("**                           Welcome to the single player Darts game 501!                                   **");
                Console.WriteLine("**                           New graphics coming soon!                                                      **");
                Console.WriteLine("**************************************************************************************************************");
                Console.WriteLine("");
                Console.WriteLine("");

                // top jobs that need doing 
                //
                // make a text file of every game so all entries. score log?
                // double to finish needs to happen. 
                // make sure any unwanted numbers aren't added to the totals DONE
                // tests add tests
                // 



                textQuery(ref totalScore); //ref keyword indicates a value that is passed by reference
                scoreKeeper(totalScore);
            }
                
        }

        public static void textQuery(ref int totalScore)
        {
                Console.WriteLine(" your curruntly have " + counter + " remaining on the board");

                Console.WriteLine("                                           Throw One");
                totalScore = totalAttemptScore(0);

                Console.WriteLine("                                           Throw Two");
                totalScore = totalAttemptScore(totalScore);

                Console.WriteLine("                                           Throw Three");
                totalScore = totalAttemptScore(totalScore);
           
            //return totalScore;

        }
        

        public static int scoreKeeper(int totalScore)
        {
            int Goal = counter;  
            int Tally = Goal - totalScore;
            //counter = Tally;
            if (Tally >= 1)
                // if (totalScore >= 1)
                
            {
                Console.WriteLine("");
                Console.WriteLine("Your total score for this round is " + totalScore);
                Console.WriteLine("");
                Console.WriteLine("Your current Tally is " + Tally + " Want to knock it down some more? press enter! ");
                Console.ReadLine();
                counter = Tally;
            }
            else if (Tally < 0)
            {
                Console.WriteLine(" Sorry you must finish on a double! The score " + totalScore + " has taken you past zero. Try again");
                Console.WriteLine("You need to score" + counter + " to win");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("CONGRATULATIONS! - YOU HAVE FINALLY REACHED " +Tally);
                Console.WriteLine("");
                counter = Tally;


Console.WriteLine("8b        d8                                           88              ");  
Console.WriteLine(" Y8,    , 8P                                           @@              ");
Console.WriteLine("  Y8,  , 8P                                                            ");
Console.WriteLine("   *8aa8*, adPPYba,  88       88    8b      db      d8 88 8b, dPPYba,  ");
Console.WriteLine("    `88' a8*     *8a 88       88    `8b    d88b    d8' 88 88P'   `*8a  ");
Console.WriteLine("     88  8b       d8 88       88     `8b  d8'`8b  d8'  88 88       88  ");
Console.WriteLine("     88  *8a,   ,a8* *8a,   ,a88      `8bd8'  `8bd8'   88 88       88  ");
Console.WriteLine("     88   `*YbbdP*'   `*YbbdP'Y8        YP      YP     88 88       88  ");
Console.WriteLine("");
                //http://www.network-science.de/ascii/
                //univers







                Console.ReadLine();
            }


            return totalScore; 
                
        }

        public static int getScore() //a private method returning ints
        {
            Console.WriteLine("Please enter your score..");
            int throwScore = Convert.ToInt32(Console.ReadLine());
            if (throwScore > 60)
            {
                Console.WriteLine(" This score isn't on the dart board! Enter what you actually scored! ");
                Console.WriteLine("");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                throwScore = Convert.ToInt32(Console.ReadLine());
            }
            if (throwScore == 0)
            {
                Console.WriteLine("That sucks. Lets hope the next throw is better!");

            }
            else
            {
                return throwScore;
            }

            return throwScore;
      }

        public static int totalAttemptScore(int throwinstanceScore)
        {
            int roundScore = getScore(); //this referes totalAttemptScore to getScore & is why you dont need to call it in Main
            
            throwinstanceScore = throwinstanceScore + roundScore;
            if (roundScore <= 20) //establishes that 1-20 is not included in the prime number problem
            {
                return throwinstanceScore;
            }
            else

            if (impossibleThrow(roundScore) == true)
            {
                Console.WriteLine("This number isn't on the dartboard at all!");
                Console.WriteLine("");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");

            }
        
            return throwinstanceScore;

        }
        //public static bool IsPrime(int roundScore)
        //{
            
        //    if (roundScore == 1) return false;
        //    if (roundScore == 2) return true;
        //    if (roundScore % 2 == 0) return false; //divides said no by two and if there is a remainder e.g. 1 then returns true.

        //    var boundary = (int)Math.Floor(Math.Sqrt(roundScore));

        //    for (int i = 3; i <= boundary; i += 2)
        //    {
        //        if (roundScore % i == 0) return false;
        //    }
            
        //    return true;
       // }

        public static bool impossibleThrow(int roundScore) //identifies all possible doubles and tripples if number not there returns true
            //this makes the IsPrime method redundant
        { //missing numbers are anything below 60 that cannot be a multiple of 2 or 3 up to 20
            int throwTest = roundScore;
            //if (throwTest > 22)
                int i = 1;
                while (i <= 21)
                {
                    int throwTestDouble = i * 2;
                    int throwTestTriple = i * 3;
                    if (throwTestDouble == roundScore || throwTestTriple == roundScore) //if x = roundscore or y = roundscore
                    
                    {
                    return false;
                    }

                    i++;
                }
            while (roundScore > 20)
            {
                if (roundScore == 25 || roundScore == 50)
                {
                    return false;
                }
                return true;
            }
            return true;
            }        
   }
}


