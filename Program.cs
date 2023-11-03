class Program
{

	public static class Globals
	{
		public static int p1Hp = 3;
		public static int p2Hp = 6;
	}

	public static void Main(string[] args)
	{

		int choice;
		int response;
		int whowon;

		string[] Weapons = {"ROCK","PAPER","SCISSORS"};
		string[] Results = {"matches","wins to","loses to"};

		Console.WriteLine("Battle starts!!!");
		Console.WriteLine("Select your weapon!!!");
		Console.WriteLine(":: 0 : rock :: 1 : paper :: 2 : scissors ::");

		
		choice = int.Parse(Console.ReadLine());
		response = rNum();

		Console.WriteLine("\nRock, paper, scissors!!\n");

		whowon = getResult(choice, response);
		
		Console.WriteLine("<< {0} {1} {2}!! >>", Enumerable.Range(0,3).Contains(choice) ? Weapons[choice] : "POOP", Results[whowon], Weapons[response]);

		applyConsequences(whowon);
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

	static void applyConsequences(int num){
		switch{
			case 0:
				break;
			case 1:
				Global.p2Hp;
				Console.WriteLine($"Enemy HP left: {Global.p2Hp}");
			case 2:
				Global.p1Hp;
				Console.WriteLine($"HP left: {Global.p1Hp}");
			Console.WriteLine($"\nyour hp: {Global.p1Hp} :: enemy hp: {Global.p2Hp}\n");
		}
	}
}
