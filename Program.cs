class Program
{

	public static class Globals
	{
		public static int p1Hp;
		public static int p2Hp;
	}

	public static void Main(string[] args)
	{
		int choice;
		int response;
		int whowon;

		string[] Weapons = {"ROCK","PAPER","SCISSORS"};
		string[] Results = {"matches","wins to","loses to"};

		while (true)
		{
			Globals.p1Hp = 4;
			Globals.p2Hp = 6;

			Console.WriteLine("\n\nBattle starts!!!\n");

			while (Globals.p1Hp > 0 && Globals.p2Hp > 0)
			{
				Console.WriteLine("Select your weapon!!!");
				Console.WriteLine(":: 0 : rock :: 1 : paper :: 2 : scissors ::");

				
				choice = int.Parse(Console.ReadLine());
				response = rNum();

				Console.WriteLine("\nRock, paper, scissors!!\n");

				whowon = getResult(choice, response);
				
				Console.WriteLine("<< {0} {1} {2}!! >>\n", Enumerable.Range(0,3).Contains(choice) ? Weapons[choice] : "POOP", Results[whowon], Weapons[response]);

				applyConsequences(whowon);
				
				if (Globals.p1Hp == 0 || Globals.p2Hp == 0)
				{
					Console.WriteLine("\nCongrats!! You {0}!!!\n", whowon==1  ? "win" : "lose");
				}
			}

			Console.WriteLine("Do you want to play again? (Y/N)");
			if (Console.ReadLine().ToLower() == "n")
			{
				break;
			}
		}
	}

	static int rNum()
	{
		Random random = new Random();
		return random.Next(0,3);
	}


	static int getResult(int p1, int p2)
	{
		if (!Enumerable.Range(0,3).Contains(p1)){
			return 2;
		}
		if (p1 == p2){
			return 0;
		}
		if (p1 == p2+1 || p1==p2-2){
			return 1;
		}
		return 2;
	}

	static void applyConsequences(int num)
	{
		switch(num)
		{
			case 1:
				Globals.p2Hp -= 1;
				Console.WriteLine($"Enemy HP left: {Globals.p2Hp}");
				break;
			case 2:
				Globals.p1Hp -= 1;
				Console.WriteLine($"HP left: {Globals.p1Hp}");
				break;
		}
		Console.WriteLine($"\nyour hp: {Globals.p1Hp} :: enemy hp: {Globals.p2Hp}\n");
	}
}
