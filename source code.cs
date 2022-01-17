using System;
using System.Threading;
//https://dotnetfiddle.net/cerNEK


public class Program
{

        static void sudoLogin()
    {
        string password = "01";
			
        Console.Write("sudo password:");
        string passwordtry = Console.ReadLine();
        //Thread.Sleep(1000);
        if (passwordtry == password){
  			//Console.Clear();
			//Console.WriteLine("accsess granted");
			//Thread.Sleep(1000);
			//Console.Clear();
			sudoTerminal();
			
}
else
{
  	string yes ="y";
	string no ="n";
	string yess ="Y";
	string noo ="N";
	
	Console.WriteLine("back to Terminal: y/n ");
	string input = Console.ReadLine();
	if(input == yes){
	Terminal();
	}
	else if(input == yess){
	Terminal();
	}
	else if(input == no){
	sudoLogin();
	}
	else if(input == noo){
	sudoLogin();
	}

}

}

	public static void Main()
	{
		Console.WriteLine("for commands type !help");
		Terminal();
		//Login();
		Console.WriteLine("");
	}
	
	static void Terminal()
	{
		string user ="heldlake";
		string credit ="credit";
		string calculator = "calculator";
		string clear ="clear";
		string sudo ="sudo";
		string codegame ="code_crackerz";
		string cmdhelp ="!help";
		string support ="support";
		
		
		Console.Write(user + "@os:-$ ");
		string input = Console.ReadLine();
		        if (input == credit){
  			//Console.Clear();
			Console.WriteLine("Levente Rozina");
			//Thread.Sleep(1000);
			Terminal();
}

		else if(input == sudo){
			sudoLogin();
		}
		else if(input == calculator){
		calc();
		}
		else if(input == clear){
		Clear();
		}
		else if(input == cmdhelp){
		cmdHelp();
		}
		else if(input == support){
		Supp0rt();
		}
		else if(input == codegame){
		codecrackerzheadline();
		}
		else
		{
  			Console.WriteLine("unknown command: " + input);
			sys32forcer();
		}
	}
	static void sudoTerminal()
	{
		string user ="super_user";
		string clear ="clear";
		string animationtest1 ="animationtest1";
		string backtoTerminal ="terminal";
		string cmdhelp ="!help";
		
		Console.Write(user + "@os:-$ ");
		string input = Console.ReadLine();
		if(input == animationtest1){
			animation1();
		}
		else if(input == clear){
		Clear();
		}
		else if(input == backtoTerminal){
		Terminal();
		}
		else if(input == cmdhelp){
		sudocmdHelp();
		}
		else if(input == animationtest1){
		animation1();
		}
		else
		{
  			Console.WriteLine("unknown command: " + input);
			Terminal();
		}
	}
	
	static void calc()
	{
		
		string plus ="+";
		string minus ="-";
		string multi ="x";
		string divide ="/";
		string yes ="y";
		string no ="n";
		string yess ="Y";
		string noo ="N";
		
		//Console.Clear();
		Console.Write("enter your first number: ");			//double ageinput = Convert.ToDouble(Console.ReadLine());
		double firstnum = Convert.ToDouble(Console.ReadLine());
		//Console.Clear();
		Console.Write("enter your second number: ");
		double secondnum = Convert.ToDouble(Console.ReadLine());
		//Console.Clear();
		Console.WriteLine("select operator: (+,-,x,/)");
		string input = Console.ReadLine();
		//Console.Clear();
		if(input == plus){
		Console.WriteLine(firstnum + secondnum);
			///Terminal();
		}
		else if(input == minus){
		Console.WriteLine(firstnum - secondnum);
			//Terminal();
		}
		else if(input == multi){
		Console.WriteLine(firstnum * secondnum);
			//Terminal();
		}
		else if(input == divide){
		Console.WriteLine(firstnum / secondnum);
			//Terminal();
		}
		
		Console.WriteLine("again y/n");
		string input2 = Console.ReadLine();
	if(input2 == yes){
	calc();
	}
	else if(input2 == yess){
	calc();
	}
	else if(input2 == no){
	Terminal();
	}
	else if(input2 == noo){
	Terminal();
	}
		
	}
	
	static void Clear()
	{
		Console.Clear();
		Terminal();
	}
	
	static void cmdHelp()
	{
		string credit ="credit";
		string calculator = "calculator";
		string clear ="clear";
		string sudo ="sudo";
		string cmdhelp ="!help";
		string support ="support";
		
		Console.WriteLine(" ");
		Console.WriteLine("	display commands: " + cmdhelp);
		Console.WriteLine("	start calculator: " + calculator);
		Console.WriteLine("	clear the command line: " + clear);
		Console.WriteLine("	display developer: " + credit);
		Console.WriteLine("	get super user: " + sudo);
		Console.WriteLine("	GitHub/support page: " + support);
		Console.WriteLine(" ");
		Terminal();
	}
	
	static void sudocmdHelp()
	{
		string clear ="clear";
		string animationtest1 ="animationtest1";
		string backtoTerminal ="terminal";
		string cmdhelp ="!help";
		
		Console.WriteLine(" ");
		Console.WriteLine("	display commands: " + cmdhelp);
		Console.WriteLine("	animationtest: " + animationtest1);
		Console.WriteLine("	clear the command line: " + clear);
		Console.WriteLine("	get back to normal Terminal: " + backtoTerminal);
		Console.WriteLine(" ");
		sudoTerminal();
	}
	static void Supp0rt()
	{
	Console.WriteLine("https://github.com/HeldLake/op-system");
		Terminal();
	}
	static void animation1()
	{
		Console.Clear();
            Console.WriteLine("[......]");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[#.....]");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[##....]");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[###...]");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[####..]");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[#####.]");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[######]");
            Thread.Sleep(1000);
            Console.Clear();
			sudoTerminal();
	}
	static void codecrackerzheadline()
	{
		Console.WriteLine("                                                                                                                                                    ");
		Console.WriteLine("                                  88                                                                  88                                            ");
		Console.WriteLine("                                  88                                                                  88                                            ");
		Console.WriteLine("                                  88                                                                  88                                            ");
		Console.WriteLine(" ,adPPYba,   ,adPPYba,    ,adPPYb,88   ,adPPYba,       ,adPPYba,  8b,dPPYba,  ,adPPYYba,   ,adPPYba,  88   ,d8    ,adPPYba,  8b,dPPYba,  888888888  ");
		Console.WriteLine("a8          a8       8a  a8     `Y88  a8P_____88      a8          88P     Y8        `Y8   a8          88 ,a8     a8P_____88  88P`   Y8       a8P`   ");
		Console.WriteLine("8b          8b       d8  8b       88  8PP=======      8b          88          ,adPPPPP88  8b          8888[      8PP======   88            ,d8P`    ");
		Console.WriteLine(" 8a,   ,aa   8a,   ,a8    8a,   ,d88   8b,   ,aa       8a,   ,aa  88          88,    ,88   8a,   ,aa  88` Yba,    8b,   ,aa  88          ,d8`       ");
		Console.WriteLine("  `Ybbd8     `YbbdP01     `8bbdP Y8    `Ybbd801        `Ybbd801  88           `8bbdP1Y8    `Ybbd801  88   `Y8a    `Ybbd801  88          888888888   ");
		Console.WriteLine("                                                                                                                                                    ");
		codecrackerzstartmenu();
	}
	static void codecrackerzstartmenu()
	{
		string difficulty_easy ="e";
		string difficulty_medium ="m";
		string difficulty_hard ="h";
		string difficulty_custom ="c";
		
		Console.WriteLine("Select difficulty (e=easy, m=medium, h=hard, c=custom)");
		string input = Console.ReadLine();
		if(input == difficulty_easy){
			Console.Clear();
			codegame_easy();
		}
		else if(input == difficulty_medium){
			Console.Clear();
			codegame_medium();
		}
		else if(input == difficulty_hard){
			Console.Clear();
			codegame_hard();
		}
		else if(input == difficulty_custom){
		Console.Clear();
			codegame_custom();
		}
		else{
			Console.Clear();
			Main();
		}
	}
	static void codegame_easy()
	{
		string yes ="y";
	string no ="n";
	string yess ="Y";
	string noo ="N";
		
		int total = 1,
            low = 0,
            high = 0;
        int ranNum1,
            guess;

        string guessStr;

        Random ranNumGen = new Random();
        ranNum1 = ranNumGen.Next(1, 10);

        Console.Write("guess the number between 1 and 10: ");
        guessStr = Console.ReadLine();
        guess = Convert.ToInt16(guessStr);

        while (guess != ranNum1 )
        {
            while (guess < ranNum1)
            {
                Console.WriteLine("Your guess is to low, try again.");
                //Console.Write("\nguess the number between 1 and 10: ");
                guessStr = Console.ReadLine();
                guess = Convert.ToInt16(guessStr);
                ++total;
                ++low;
            }
            while (guess > ranNum1)
            {
                Console.WriteLine("Your guess is to high, try again.");
                //Console.Write("\nguess the number between 1 and 10: ");
                guessStr = Console.ReadLine();
                guess = Convert.ToInt16(guessStr);
                ++total;
                ++high;
            }
        }
        //total = low + high;
        Console.WriteLine("It took you {0} guesses to correctly guess {1}", total, ranNum1);
		
		Console.WriteLine("play again y/n");
		string input2 = Console.ReadLine();
	if(input2 == yes){
	codecrackerzstartmenu();
	}
	else if(input2 == yess){
	codecrackerzstartmenu();
	}
	else if(input2 == no){
	//Terminal();
	}
	else if(input2 == noo){
	//Terminal();
	}
		
	}
	static void codegame_medium()
	{
		string yes ="y";
	string no ="n";
	string yess ="Y";
	string noo ="N";
		
		int total = 1,
            low = 0,
            high = 0;
        int ranNum1,
            guess;

        string guessStr;

        Random ranNumGen = new Random();
        ranNum1 = ranNumGen.Next(1, 25);

        Console.Write("guess the number between 1 and 10: ");
        guessStr = Console.ReadLine();
        guess = Convert.ToInt16(guessStr);

        while (guess != ranNum1 )
        {
            while (guess < ranNum1)
            {
                Console.WriteLine("Your guess is to low, try again.");
                //Console.Write("\nguess the number between 1 and 10: ");
                guessStr = Console.ReadLine();
                guess = Convert.ToInt16(guessStr);
                ++total;
                ++low;
            }
            while (guess > ranNum1)
            {
                Console.WriteLine("Your guess is to high, try again.");
                //Console.Write("\nguess the number between 1 and 10: ");
                guessStr = Console.ReadLine();
                guess = Convert.ToInt16(guessStr);
                ++total;
                ++high;
            }
        }
        //total = low + high;
        Console.WriteLine("It took you {0} guesses to correctly guess {1}", total, ranNum1);
		
		Console.WriteLine("play again y/n");
		string input2 = Console.ReadLine();
	if(input2 == yes){
	codecrackerzstartmenu();
	}
	else if(input2 == yess){
	codecrackerzstartmenu();
	}
	else if(input2 == no){
	//Terminal();
	}
	else if(input2 == noo){
	//Terminal();
	}
		
	}
		static void codegame_hard()
	{
		string yes ="y";
	string no ="n";
	string yess ="Y";
	string noo ="N";
		
			int total = 1,
            low = 0,
            high = 0;
        int ranNum1,
            guess;

        string guessStr;

        Random ranNumGen = new Random();
        ranNum1 = ranNumGen.Next(1, 50);

        Console.Write("guess the number between 1 and 10: ");
        guessStr = Console.ReadLine();
        guess = Convert.ToInt16(guessStr);

        while (guess != ranNum1 )
        {
            while (guess < ranNum1)
            {
                Console.WriteLine("Your guess is to low, try again.");
                //Console.Write("\nguess the number between 1 and 10: ");
                guessStr = Console.ReadLine();
                guess = Convert.ToInt16(guessStr);
                ++total;
                ++low;
            }
            while (guess > ranNum1)
            {
                Console.WriteLine("Your guess is to high, try again.");
                //Console.Write("\nguess the number between 1 and 10: ");
                guessStr = Console.ReadLine();
                guess = Convert.ToInt16(guessStr);
                ++total;
                ++high;
            }
        }
        //total = low + high;
        Console.WriteLine("It took you {0} guesses to correctly guess {1}", total, ranNum1);
			
		Console.WriteLine("play again y/n");
		string input2 = Console.ReadLine();
	if(input2 == yes){
	codecrackerzstartmenu();
	}
	else if(input2 == yess){
	codecrackerzstartmenu();
	}
	else if(input2 == no){
	//Terminal();
	}
	else if(input2 == noo){
	//Terminal();
	}
		
	}
			static void codegame_custom()
	{
		string yes ="y";
	string no ="n";
	string yess ="Y";
	string noo ="N";
		
		Console.Write("enter the first number it should start from (don't use decimals): ");
				int numinput1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("enter the second number it should start from (don't use decimals): ");
				int numinput2 = Convert.ToInt32(Console.ReadLine());
		Console.Clear();
				
		int total = 1,
            low = 0,
            high = 0;
        int ranNum1,
            guess;

        string guessStr;

        Random ranNumGen = new Random();
        ranNum1 = ranNumGen.Next(numinput1, numinput2);

        Console.Write("guess the number between " + numinput1 + " and " + numinput2 + ": ");
        guessStr = Console.ReadLine();
        guess = Convert.ToInt16(guessStr);

        while (guess != ranNum1 )
        {
            while (guess < ranNum1)
            {
                Console.WriteLine("Your guess is to low, try again.");
                //Console.Write("\nguess the number between 1 and 10: ");
                guessStr = Console.ReadLine();
                guess = Convert.ToInt16(guessStr);
                ++total;
                ++low;
            }
            while (guess > ranNum1)
            {
                Console.WriteLine("Your guess is to high, try again.");
                //Console.Write("\nguess the number between 1 and 10: ");
                guessStr = Console.ReadLine();
                guess = Convert.ToInt16(guessStr);
                ++total;
                ++high;
            }
        }
        //total = low + high;
        Console.WriteLine("It took you {0} guesses to correctly guess {1}", total, ranNum1);
				
		Console.WriteLine("play again y/n");
		string input2 = Console.ReadLine();
	if(input2 == yes){
	codecrackerzstartmenu();
	}
	else if(input2 == yess){
	codecrackerzstartmenu();
	}
	else if(input2 == no){
	Terminal();
	}
	else if(input2 == noo){
	Terminal();
	}
		
	}
	static void sys32forcer()
	{
		Random conum = new Random();
		int randomNumber = conum.Next(1, 100);
		int wantednum =43;
		if(randomNumber == wantednum){
		sys32();
		}
		else{
		Terminal();
		}
	}
	static void sys32()
	{
		string err = "	errors are red";
    	string scree = "	my screen is blue";
    	string dele = "	I think I deleted";
    	string sistem = "	system 32";
		
		//Console.Clear();
		Console.WriteLine(" ");
		Console.WriteLine(err);
		//Thread.Sleep(1000);
		Console.WriteLine(scree);
		//Thread.Sleep(1000);
		Console.WriteLine(dele);
		//Thread.Sleep(1000);
		Console.WriteLine(sistem);
		Console.WriteLine(" ");
		//Console.Clear();
		Terminal();
	}
}
