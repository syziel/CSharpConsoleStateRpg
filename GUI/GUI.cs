

namespace CSharpConsoleStateRpg.GUI
{
	class Gui
	{
		public static void Title(String str)
		{
			str = String.Format("==== {0} ====\n\n", str);

			Console.Write(str);
		}

		public static void MenuTitle(String str)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			str = String.Format(" - ({0})\n", str);

			Console.Write(str);
			Console.ResetColor();
		}

		public static void MenuOption(int option, String str)
		{
			str = String.Format(" - ({0}) : {1}\n", option, str);

			Console.Write(str);
		}

		public static void Announcement(String str)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			str = String.Format(" \t(~) ({0})!\n",  str);
			Console.Write(str);
			Console.ResetColor();
		}


		public static void GetInput(String str)
		{
			str = String.Format(" -{0}: ", str);

			Console.Write(str); 

		}

	}
}