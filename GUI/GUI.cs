using System;

namespace CSharpConsoleStateRpg.GUI
{
	class Gui
	{
		public static String Title(String str)
		{
			str = String.Format("==== {0} ====\n\n", str);

			return str;
		}

		public static String MenuTitle(String str)
		{
			str = String.Format(" - ({0})\n", str);

			return str;
		}
			public static String MenuOption(int option, String str)
		{
			str = String.Format(" - ({0}) : {1}\n", option, str);

			return str;
		}

		public static String GetInput(String str)
		{
			str = String.Format("- {0}: ", str);

			return str;
		}
	}
}
