using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IlluminatiConfirmed;

namespace Data
{
    public class Relate
    {
        public static bool met = false;
        public static string nineteen()
        {
            #region 19
            met = true;
                Program.centerText("so now we have 19",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("19 is the first number with more than one digit",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("that can be written from base 2 to base 19 using only the digits 0 to 9",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("what is the other number, you ask?",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("That's right!...",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("That's right!... 20",7,"20");
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("19 + 20 = 39",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("3 + 9 = 12",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("So now we have 4 numbers... ",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("So now we have 4 numbers... 19,20,39 & 12",7,"19,20,39 and 12");
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("There are 4 sides in a square",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("12 divided by 4 = 3",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("39 - 3 = 36",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("36 square rooted is 6",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("there are 6 sides in a hexagon!",1);
                Program.DramaticPause(4);
                Console.Clear();
                Program.centerText("13 = Hexagon confirmed!",1);
                Program.DramaticPause(5);
                Music.Drama.Stop();
                Console.Clear();
                return "19ALERT";
            #endregion
        }
        public static string Number(int i)
        {
            string ret = "NaN";
            Console.Clear();
            #region 12
            if (i == 12)
            {
                Program.centerText("But wait!");
                Program.DramaticPause(3);
                Console.Clear();
                Program.centerText("What was Carbon's atomic weight again?");
                Program.DramaticPause(4);
                Console.Clear();
                Program.centerText("That's right!...");
                Program.DramaticPause(2);
                Console.Clear();
                Program.centerText(@"That's right!... 12! (to the nearest whole number)");
                Program.DramaticPause(3);
                Console.Clear();
                Program.centerText(@"12 + 1 = 13");
                Program.DramaticPause(3);
                Console.Clear();
                Number(13);
            }
            #endregion
            #region 13
            if (i == 13)
            {
                Program.centerText("13?");
                Program.DramaticPause(3);
                Console.Clear();
                Program.centerText("13 = Hexagon!");
                Program.DramaticPause(3);
                Console.Clear();
                Program.centerText("Do you even know how I came up with that conclusion?");
                Program.DramaticPause(4);
                Console.Clear();
                Program.centerText("Allow me to explain...");
                Program.DramaticPause(3);
                Console.Clear();
                Program.centerText("*takes deep breath*");
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("*takes deep breath*.",1," ");
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("*takes deep breath*..", 1, " ");
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("*takes deep breath*...", 1, " ");
                Program.DramaticPause(1);
                Console.Clear();
                Music.Drama.Play();
                Program.centerText("Friday the 13th is supposed to be an unlucky day",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("Friday is the 5th day of the week",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("13 is also how old you must be to use most social networks",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("13 x 5 = " + 13 * 5,7); //65 btw
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("65 has an aliquot sum of 19",7);
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText("65 is also the first composite number in the 19-aliquot tree",7);
                Program.DramaticPause(1);
                Console.Clear();
                return nineteen();

            }
            #endregion
            #region 15
            if (i == 15)
            {
                Program.centerText("15 is made up of 10 and 5");
                Program.DramaticPause(3);
                Console.Clear();
                Program.centerText("15 x 5 = 50");
                Program.DramaticPause(3);
                Console.Clear();
                Program.centerText("There are 50 states in America");
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText(@"50 * 0 = 0");
                Program.DramaticPause(1);
                Console.Clear();
                Program.centerText(@"0 + 13 = 13");
                Program.DramaticPause(1);
                Console.Clear();
                return Number(13);
            }
            #endregion

            Program.centerText("there are " + i + " letters in the last " + i + " letters of");
            string text="pneumonoultramicroscopicsilicovolcanoconiosis";
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text);
            Program.Say(text, 4);
            Program.DramaticPause(5);
            Console.Clear();
            Program.centerText("there are 45 letters in the word ");
            text = "pneumonoultramicroscopicsilicovolcanoconiosis";
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text);
            Program.Say(text, 4);
            Program.DramaticPause(3);
            Console.Clear();
            Program.centerText("45 divided by 5 = 9");
            Program.DramaticPause(2);
            Console.Clear();
            Program.centerText("what's 9 + 10?");
            Program.DramaticPause(1);
            Console.Clear();
            Program.centerText("9 + 10 = 21");
            Program.DramaticPause(1);
            Console.Clear();
            Program.centerText("21 - 8 = 13");
            Program.DramaticPause(3);
            Console.Clear();
            return Number(13);

            return ret;
        }
    }
}
