using System;
using System.Speech.Synthesis;

namespace IlluminatiConfirmed
{
    class Program
    {
        public static ConsoleColor DefaultColor = ConsoleColor.White;
        public static ConsoleColor InputColor = ConsoleColor.Gray;
        public static System.Collections.Generic.List<string>[] listarray = { Data.Colors.Blue, Data.Colors.Green, Data.Colors.Red };
        public static int nooeo = 0;
        public static string itemi;
        public static bool foreverloop = false;
        public static void Start()
        {
            foreach (var item in listarray[1].ToArray())
            {
             //   PictureSet(item);
            }
            //PictureSet("seaweed");
            //Data.Relate.Number(13);
            Console.Clear();
            #region illuminati triangle
            Console.Write(@"                                    ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/\" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(@"                                   ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/  \" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(@"                                  ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/,--.\" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(@"                                 ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/< () >\" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(@"                                ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/  `--'  \" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(@"                               ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/          \" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(@"                              ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/            \" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(@"                             ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/______________\" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            #endregion
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Enter something to be proven as part of the illuminati:"));
            itemi = Read();
            if (itemi.Length > 10) { Console.WriteLine("Error max word length is 10 chars"); System.Threading.Thread.Sleep(2000); Start(); }
            Console.Clear();
            Starti(itemi);
        }
        public static void Starti(string item)
        {
            centerText(item, -7);
            //Say(item, -7);
            //DramaticPause(3);
            Console.Clear();
            centerText("The word " + @""""+item + @""" has " + item.Length + " letters", 1);
            DramaticPause(3);
            Console.Clear();
            centerText("You know what else also has " + item.Length + " letters?", 1);
            DramaticPause(4);
            Console.Clear();
            string a = SameLength(item.Length);
            if (a.ToLower() == "i have no idea")
            {
                centerText("I have no idea");
                DramaticPause(4);
                Console.Clear();
                centerText(@"the word ""idea"" has 4 letters....");
                DramaticPause(3);
                Console.Clear();
                centerText("You know what else also has 4 letters?");
                DramaticPause(4);
                Console.Clear();
                a = SameLength(4);
            }
            centerText("That's right!...");
            DramaticPause(2);
            Console.Clear();
            Console.WriteLine("processing...");
            PictureSet(a);
            centerText(@"That's right!... the word """ + a + @"""",1,"the word" + a);
           // Console.WriteLine("same color as that is " + flong(SameColor(a,listarray)));
            DramaticPause(4);
            Console.Clear();
            centerText(@"a """ + a + @""" is " + WhichColor(a));
            DramaticPause(4);
            Console.Clear();
            centerText("You know what else is also " + WhichColor(a) + "?");
            DramaticPause(4);
            Console.Clear();
            centerText("That's right!...");
            DramaticPause(2);
            Console.Clear();
            string oaoaoa = flong(SameColor(a, listarray));
            PictureSet(oaoaoa);
            centerText("That's right!... " + oaoaoa,1,oaoaoa);
            DramaticPause(5);
            Console.Clear();
            centerText("Coincidence?");
            DramaticPause(2);
            Console.Clear();
            centerText("I didn't think so!");
            DramaticPause(3);
            Console.Clear();
            if (foreverloop)
            {
                Starti(oaoaoa);
            }
            centerText(@"""" + oaoaoa + @""" has " + oaoaoa.Length + " letters");
            DramaticPause(3);
            Console.Clear();
            centerText(oaoaoa.Length + " + " + item.Length + " = ");
            DramaticPause(2);
            Console.Clear();
            int looo = oaoaoa.Length + item.Length;
            centerText(oaoaoa.Length + " + " + item.Length + " = " + looo,1,looo.ToString());
            DramaticPause(2);
            Console.Clear();
            centerText("But wait! " + looo + "?! ");
            DramaticPause(2);
            Console.Clear();
            centerText("It's so obvious!");
            DramaticPause(2);
            Console.Clear();
            string laohg = Data.Relate.Number(looo);
            if (true == false)
            {
                Starti(laohg);
            }
            else
            {
                Console.Clear();
                centerText("But what do hexagons have to do with " + itemi);
                DramaticPause(3);
                Console.Clear();
                centerText("being in the illuminati?");
                DramaticPause(2);
                Console.Clear();
                centerText("Lots!");
                DramaticPause(3);
                Console.Clear();
                centerText("Listen closely...");
                DramaticPause(3);
                Console.Clear();
                Music.Drama.Play();
                Console.WriteLine("Hexagons have 6 triangles within them");
                Say("Hexagons have 6 triangles within them", 5);
                Console.WriteLine(@"
         OOOOOOOOOOOOOOOOOOOO           
        O O                O O          
       O   O              O   O         
      O     O            O     O        
     O       O    1     O       O       
    O         O        O         O      
   O           O      O           O     
  O             O    O             O    
 O               O  O               O   
O                 OO                 O  
OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO 
O                 O O                O  
 O               O  O.              O   
  O              O    O.           O    
   O           O      O.          O     
    O         O        O         O      
     O       O          O       O       
      O     O            O     O        
       O   O              O   O         
        O O                O O          
         OOOOOOOOOOOOOOOOOOOO           ");
                DramaticPause(2);
                Say("1", 1);
                Console.Clear();
                Console.WriteLine("Hexagons have 6 triangles within them",1," ");
                Console.WriteLine(@"
         OOOOOOOOOOOOOOOOOOOO           
        O O                O O          
       O   O              O   O         
      O     O            O     O        
     O       O    1     O       O       
    O         O        O         O      
   O           O      O           O     
  O             O    O     2       O    
 O               O  O               O   
O                 OO                 O  
OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO 
O                 O O                O  
 O               O  O.              O   
  O              O    O.           O    
   O           O      O.          O     
    O         O        O         O      
     O       O          O       O       
      O     O            O     O        
       O   O              O   O         
        O O                O O          
         OOOOOOOOOOOOOOOOOOOO           ");
                DramaticPause(2);
                Say("2", 1);
                Console.Clear();
                Console.WriteLine("Hexagons have 6 triangles within them", 1, " ");
                Console.WriteLine(@"
         OOOOOOOOOOOOOOOOOOOO           
        O O                O O          
       O   O              O   O         
      O     O            O     O        
     O       O    1     O       O       
    O         O        O         O      
   O           O      O           O     
  O             O    O     2       O    
 O               O  O               O   
O                 OO                 O  
OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO 
O                 O O                O  
 O               O  O.              O   
  O              O    O.    3      O    
   O           O      O.          O     
    O         O        O         O      
     O       O          O       O       
      O     O            O     O        
       O   O              O   O         
        O O                O O          
         OOOOOOOOOOOOOOOOOOOO           ");
                Say("3", 1);
                DramaticPause(2);
                Console.Clear();
                Console.WriteLine("Hexagons have 6 triangles within them", 1, " ");
                Console.WriteLine(@"
         OOOOOOOOOOOOOOOOOOOO           
        O O                O O          
       O   O              O   O         
      O     O            O     O        
     O       O    1     O       O       
    O         O        O         O      
   O           O      O           O     
  O             O    O     2       O    
 O               O  O               O   
O                 OO                 O  
OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO 
O                 O O                O  
 O               O  O.              O   
  O              O    O.    3      O    
   O           O      O.          O     
    O         O        O         O      
     O       O          O       O       
      O     O      4     O     O        
       O   O              O   O         
        O O                O O          
         OOOOOOOOOOOOOOOOOOOO           ");
                DramaticPause(2);
                Say("4", 1);
                Console.Clear();
                Console.WriteLine("Hexagons have 6 triangles within them", 1, " ");
                Console.WriteLine(@"
         OOOOOOOOOOOOOOOOOOOO           
        O O                O O          
       O   O              O   O         
      O     O            O     O        
     O       O    1     O       O       
    O         O        O         O      
   O           O      O           O     
  O      6      O    O     2       O    
 O               O  O               O   
O                 OO                 O  
OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO 
O                 O O                O  
 O               O  O.              O   
  O      5       O    O.    3      O    
   O           O      O.          O     
    O         O        O         O      
     O       O          O       O       
      O     O      4     O     O        
       O   O              O   O         
        O O                O O          
         OOOOOOOOOOOOOOOOOOOO           ");
                Say("5", 1);
                Say("6", 1);
                DramaticPause(3);
                Console.Clear();
                centerText("The hexagon has 3 diagonals",5);
                DramaticPause(2);
                Console.Clear();
                centerText("6 divided by 3 = 2",7);
                DramaticPause(2);
                Console.Clear();
                centerText("If we split the hexagon into 2, we would get 4 sides",7);
                DramaticPause(2);
                Console.Clear();
                centerText("A square is 4 sides",7);
                DramaticPause(2);
                Console.Clear();
                centerText("On the hexagon, we now only have 3 triangles",7);
                DramaticPause(2);
                Console.Clear();
                centerText("4 - 3 = 1",7);
                DramaticPause(2);
                Music.Drama.Stop();
                Console.Clear();
                centerText("The illuminati has one eye, so",1);
                DramaticPause(1);
                Console.Clear();
                centerText("The illuminati has one eye, so.",1," ");
                DramaticPause(1);
                Console.Clear();
                centerText("The illuminati has one eye, so..",1," ");
                DramaticPause(1);
                Console.Clear();
                centerText("The illuminati has one eye, so...",1," ");
                DramaticPause(1);
                Console.Clear();
                Confirm(itemi);
            }

            
        }
        public static void Confirm(string str)
        {
            int tmp = 0;
            while (tmp != Console.WindowHeight / 4 + 2)
            {
                tmp++;
                Console.WriteLine();
            }
            #region illuminati triangle
            WriteSpaces(@"                                    ".Length + 0);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/\" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            WriteSpaces(@"                                   ".Length +0);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/  \" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            WriteSpaces(@"                                  ".Length+0);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/,--.\" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            WriteSpaces(@"                                 ".Length+0);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/< () >\" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            WriteSpaces(@"                                ".Length+0);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/  `--'  \" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("                  " + str + " = ");
            int a = str.Length + 3;
            WriteSpaces(@"                               ".Length - 18 - a);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/          \");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("     Confirmed!" + Environment.NewLine);
            WriteSpaces(@"                              ".Length+0);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/            \" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            WriteSpaces(@"                             ".Length+0);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"/______________\" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Black;
            WriteSpaces(@"                             ".Length + 0);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("   ILLUMINATI");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Say(itemi + " equals illuminati confirmed", 1);
            Music.Illuminati.Play();
            Console.ReadKey();
        }
        public static void WriteSpaces(int i)
        {
            int tmp = i;
            while (tmp != 0)
            {
                Console.Write(" ");
                tmp--;
            }
        }
        public static string WhichColor(string str)
        {
            string ret = "NaN";
            foreach (var item in Data.Colors.Blue)
            {
                if (item.Contains(str)) { ret = "blue"; }
            }
            foreach (var item in Data.Colors.Green)
            {
                if (item.Contains(str)) { ret = "green"; }
            }
            foreach (var item in Data.Colors.Red)
            {
                if (item.Contains(str)) { ret = "red"; }
            }
            return ret;
        }
        public static string SameLength(int i)
        {
            string ret = "I have no idea";
            System.Collections.Generic.List<string> posib = new System.Collections.Generic.List<string>();
            #region foreach
            foreach (var RedThing in Data.Colors.Red.ToArray())
            {
                if (f(RedThing).Length == i && f(RedThing) != itemi)
                {
                    posib.Add(f(RedThing));
                }
            }
            foreach (var RedThing in Data.Colors.Blue.ToArray())
            {
                if (f(RedThing).Length == i && f(RedThing) != itemi)
                {
                    posib.Add(f(RedThing));
                }
            }
            foreach (var RedThing in Data.Colors.Green.ToArray())
            {
                if (f(RedThing).Length == i && f(RedThing) != itemi)
                {
                    posib.Add(f(RedThing));
                }
            }
            #endregion
            Random rand = new Random();
            try
            {
                ret = posib[rand.Next(posib.Count)];
            }
            catch
            {
                ret = "I have no idea";
            }
            return ret;
        }
        public static string SameColor(string thing, System.Collections.Generic.List<string>[] lists)
        {
            string ret = "I have no idea";
            foreach (var list in lists)
            {
                foreach (var item in list.ToArray())
                {
                    if (item.Contains(thing))
                    {
                        //pick a random value from this list
                        ret = RandFromList(list);
                    }
                }
            }
            return ret;
        }
        public static string Read()
        {
            Console.ForegroundColor = InputColor;
            string ret = Console.ReadLine();
            Console.ForegroundColor = DefaultColor;
            return ret;
        }
        public static void DramaticPause(int i)
        {
            i = -1;
            if(i>0){
                if (i < 5)
                {
                    if (i == 0)
                    {
                        System.Threading.Thread.Sleep(200);
                    }
                    if (i == 1)
                    {
                        System.Threading.Thread.Sleep(750);
                    }
                    if (i == 2)
                    {
                        System.Threading.Thread.Sleep(1500);
                    }
                    if (i == 3)
                    {
                        System.Threading.Thread.Sleep(3000);
                    }
                    if (i == 4)
                    {
                        System.Threading.Thread.Sleep(4000);
                    }
                }
                else
                {
                    int ii = i*1000;
                    System.Threading.Thread.Sleep(ii);
                }
            }
        }
        public static void centerText(String text, int rate = 1, string say = "69zoolaneloololgihosdag")
        {
            if (say == "69zoolaneloololgihosdag")
            {
                say = text;
            }
            int tmp = 0;
            while (tmp != Console.WindowHeight / 2)
            {
                tmp++;
                Console.WriteLine();
            }
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text);
            Say(say, rate);

        }
        public static string f(string txt)
        {
            try
            {
                string[] a = txt.Split('`');
                return a[1];
            }
            catch
            {
                return txt;
            }
        }
        public static string flong(string txt)
        {
            try
            {
                string[] a = txt.Split('`');
                string b = a[0].Replace("`", "");
                return b;
            }
            catch
            {
                return txt;
            }
        }

        public static string RandFromList(System.Collections.Generic.List<string> list)
        {
            Random rand = new Random();
            string ret = "I have no idea";
            try
            {
                ret = list[rand.Next(list.Count)];
            }
            catch { }
            return ret;
        }
        public static void Say(string str, int rate)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;
            synthesizer.Rate = rate;     // -10...10
            synthesizer.Speak(str);
            if (synthesizer.State != SynthesizerState.Speaking)
            {
                synthesizer.Dispose();
            }
        }
        public static string Relative(string relpath)
        {
            string absolutepath = AppDomain.CurrentDomain.BaseDirectory + relpath;
            return absolutepath;
        }
        public static void PictureSet(string name)
        {
            Picture moo = new Picture();
           // moo.ShowDialog();
            foreach (var list in listarray)
            {
                foreach (var item in list.ToArray())
                {
                    if (item.Contains(name))
                    {
                        /*
                         * [0] blue
                         * [1] green
                         * [2] red
                         */
                        bool found = false;
                        string oloooaoa; //= "https://lh6.googleusercontent.com/-_ASksv5DrxQ/TyQ6X4zG_7I/AAAAAAAAECg/WmVfMzj9l3Y/s1600/transparent.png";
                        Console.WriteLine("processing...");
                        //Console.Clear();
                        #region blue
                        oloooaoa = "http://www.promo-wholesale.com/Upfiles/Prod_q/3-x1-1-4-x3-4--Blue-Nascar-Style-Die-Cast-Car_20090684969.jpg";
                        if (listarray[0][0].Contains(name)) { Picture.pathpath = oloooaoa; Picture picture = new Picture(); found = true; }
                        oloooaoa = "http://workingperson.com/media/catalog/product/cache/1/image/400x/9df78eab33525d08d6e5fb8d27136e95/i/m/image_90828.jpg";
                        if (listarray[0][5].Contains(name)) { Picture.pathpath = oloooaoa; Picture picture = new Picture(); found = true; }
                        #endregion
                        #region green
                        oloooaoa = @"http://www.freshfruitportal.com/wp-content/uploads/2013/05/limes_74531311.jpg";
                        if (listarray[1][0].Contains(name)) { Picture.pathpath = oloooaoa; Picture picture = new Picture(); /*picture.ShowDialog();*/ found = true; }
                        oloooaoa = @"http://www.infogoons.com/wp-content/uploads/2015/05/wpid-cucumber.jpg";
                        if (listarray[1][1].Contains(name)) { Picture.pathpath = oloooaoa; Picture picture = new Picture(); /*picture.ShowDialog();*/ found = true; }
oloooaoa = @"http://www.united4iran.net/wp-content/uploads/2010/03/GreenEgg1.jpg";
if (listarray[1][2].Contains(name)) { Picture.pathpath = oloooaoa; Picture picture = new Picture();/*picture.ShowDialog();*/ found = true; }
                        oloooaoa = @"http://images.clipartpanda.com/seaweed-clipart-51064-liquid-seaweed.jpg";
                        if (listarray[1][3].Contains(name)) { Picture.pathpath = oloooaoa; Picture picture = new Picture(); /*picture.ShowDialog();*/ found = true; }
oloooaoa = @"http://static.guim.co.uk/sys-images/Observer/Columnist/Columnists/2011/10/21/1319219972164/Oak-tree-in-field-007.jpg";
if (listarray[1][4].Contains(name)) { Picture.pathpath = oloooaoa; Picture picture = new Picture(); /*picture.ShowDialog();*/ found = true; }
                        oloooaoa = @"http://leaf.hu/leaf.png";
                        if (listarray[1][5].Contains(name)) { Picture.pathpath = oloooaoa; Picture picture = new Picture(); /*picture.ShowDialog();*/ found = true; }
oloooaoa = @"http://16acresgardencenter.com/wp-content/uploads/2014/06/Lettuce.jpg";
if (listarray[1][6].Contains(name)) { Picture.pathpath = oloooaoa; Picture picture = new Picture(); /*picture.ShowDialog();*/ found = true; }
                        oloooaoa = @"http://blog.fairwaymarket.com/content/uploads/2012/02/Cabbage.jpg";
                        if (listarray[1][7].Contains(name)) { Picture.pathpath = oloooaoa; Picture picture = new Picture(); /*picture.ShowDialog();*/found = true; }
                        oloooaoa = "http://producemadesimple.ca/wp-content/uploads/2013/07/spinach.jpg";
                        if (listarray[1][15].Contains(name)) { Picture.pathpath = oloooaoa; Picture picture = new Picture(); found = true; }
                        #endregion
                        try
                        {
                            if(found == true)
                            moo.ShowDialog();
                        }
                        catch { if (found == true) { Picture show = new Picture(); show.ShowDialog(); System.Threading.Thread.Sleep(2000); } }
                        Console.Clear();
                    }
                }
            }
        }
    }
}
