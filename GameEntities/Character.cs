namespace CSharpConsoleStateRpg.GameEntities
{
	class PlayerCharacter
	{
		//core Character
		private String Name = "";
		private int ArmorClass = 5;
		private int Level = 1;
		private int MaximumLevel = 20;
		private int Experience = 0;
		private int MaximumExperience = 100;
		private int BaseDamage = 5;
		private int MaximumDamage = 5;
		private int criticalDamage = 15;
		private int criticalHitChance = 1;
		private String Attributes;
		private int MaximumAttributes = 100;

}

	class Stats
	{
		//Character Stats
		private int HitPoints = 20;
		private int MaxHitPoints = 20;
		private int MagicPoints = 5;
		private int MaxMagicPoints = 5;
		private int Defense = 5;
		private int MaxDefense = 5;
		private int StatPoints = 3;
		private int MaxStatPoints = 3;
		private int SkillPoints = 3;
		private int MaxSkillPoints = 3;
	}

	class Attributes
	{
		//Character Attributes
		private int Strength = 1;
		private int MaxStrength = 1;
		private int Fortitude = 1;
		private int MaxFortitude = 1;
		private int Dexterity = 1;
		private int MaxDexterity = 1;
		private int Intelligence = 1;
		private int MaxIntelligence = 1;
		private int Wisdom = 1;
		private int MaxWisdom = 1;
		private int Vitality = 1;
		private int MaxVitality = 1;
		private int Accuracy = 1;
		private int MaxAccuracy = 1;
	}

	class CharacterGeneral
	{
		//Character General
		private int Gold = 100;
		private string? Inventory { get; set; }
		private int InventoryWeight = 10;
	}

	class Character
	{
		private string Name;
		private int HitPoints { get; set; }
		private int BaseDamage { get; set; }
		private int MaximumDamage { get; set; }
		private int MagicPoints { get; set; }
		private int Vitality { get; set; }
		private int Strength { get; set; }
		private int Intelligence { get; set; }
		private int StatPoints { get; set; }
		private int SkillPoints { get; set; }
		private int Accuracy { get; set; }
		private int ArmorClass { get; set; }
		private int CriticalDamage { get; set; }
		private int CriticalHitChance { get; set; }
		private int Wisdom { get; set; }
		private int Fortitude { get; set; }
		private int Dexterity { get; set; }
		private int Defense { get; set; }
		private int Experience { get; set; }
		private int Level { get; set; }
		private int MaxSkillPoints { get; set; }
		private int MaxStatPoints { get; set; }
		private int MaximumExperience { get; set; }

		public Character(String name)
		{
			this.CalculateStats();

			this.Name = name;

		}

		private void CalculateExperience()
		{
			this.MaximumExperience = this.Level * 100;
		}



		private void CalculateStats()
		{
			this.HitPoints = this.Vitality = 5;

			this.BaseDamage = this.Strength = 2;

			this.MaximumDamage = this.Strength = 2;

			this.MagicPoints = this.Intelligence = 2;

			this.StatPoints = this.Wisdom = 2;

			this.SkillPoints = this.Fortitude = 2;

			this.Accuracy = this.Dexterity = 2;

			this.ArmorClass = this.Dexterity = 2;

			this.CriticalDamage = this.Dexterity = 2;

			this.CriticalHitChance = this.Dexterity = 2;

			this.Defense = this.Fortitude = 2;

			this.Experience = this.Level = 2;

			this.MaxSkillPoints = this.Fortitude = 2;

			this.MaxStatPoints = this.Wisdom = 2;

			return;
		}

		override public String ToString()
		{
			return "";
		}

	}
}

