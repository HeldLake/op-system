using System;
using System.Threading;
//https://dotnetfiddle.net/cerNEK


public class Program
{

        static void sudoLogin()
    {
        string password = "levelname0";
			
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
		string cmdhelp ="!help";
		string support ="!support";
		
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
		else
		{
  			Console.WriteLine("unknown command: " + input);
			Terminal();
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
			Terminal();
		}
		else if(input == minus){
		Console.WriteLine(firstnum - secondnum);
			Terminal();
		}
		else if(input == multi){
		Console.WriteLine(firstnum * secondnum);
			Terminal();
		}
		else if(input == divide){
		Console.WriteLine(firstnum / secondnum);
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
		string support ="!support";
		
		Console.WriteLine("	display commands: " + cmdhelp);
		Console.WriteLine("	start calculator: " + calculator);
		Console.WriteLine("	clear the command line: " + clear);
		Console.WriteLine("	display developer: " + credit);
		Console.WriteLine("	get super user: " + sudo);
		Console.WriteLine("	GitHub/support page: " + support);
		Terminal();
	}
	
	static void sudocmdHelp()
	{
		string clear ="clear";
		string animationtest1 ="animationtest1";
		string backtoTerminal ="terminal";
		string cmdhelp ="!help";
		
		Console.WriteLine("	display commands: " + cmdhelp);
		Console.WriteLine("	animationtest: " + animationtest1);
		Console.WriteLine("	clear the command line: " + clear);
		Console.WriteLine("	get back to normal Terminal: " + backtoTerminal);
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
}
