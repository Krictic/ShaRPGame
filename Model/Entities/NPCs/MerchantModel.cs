using ShaRPG.View.GUI;
using ShaRPGame.Model.Entities.EntityInterfaces;

namespace ShaRPGame.Model.Entities.NPCs
{
    internal class MerchantModel : IEntity, INPCs
    {
        public MerchantModel(
            string name = "Playc Holdr",
            string description = "He is but a modest Placeholder",
            string jobClass = "Placeholder",
            int age = 20
        )
        {
            Name = name;
            Description = description;
            JobClass = jobClass;
            Age = age;
        }

        // Description Variables
        private string Name { set; get; }
        private string Description { set; get; }
        private string JobClass { set; get; }
        private int Age { set; get; }
        private int Reputation { set; get; }

        // Progression Variables
        private int Level { set; get; } = 1;
        private int ExpBase { set; get; } = 0;
        private int ExpRequirement { set; get; } = 100;
        private int StatPoints { get; set; }
        private int SkillPoints { get; set; }
        private int TraitPoints { get; set; }

        // Core Stat Variables
        private int Might { get; set; } = 1;
        private int Vitality { get; set; } = 1;
        private int Agility { get; set; } = 1;
        private int Dexterity { get; set; } = 1;
        private int Intellect { get; set; } = 1;
        private int Magic { get; set; } = 1;
        private int Charisma { set; get; } = 1;
        private int Will { get; set; } = 1;
        private int Perception { set; get; } = 1;

        // Secondary Stat Variables
        private int HitPointCapacity { set; get; }
        private int HitPoints { get; set; }
        private int StaminaCapacity { get; set; }
        private int Rethorics { set; get; }
        private int Speed { set; get; }

        // Tertiary Stat variables
        private double Accuracy { set; get; }
        private int MeleeDamage { set; get; }
        private int RangedDamage { set; get; }
        private double RangedPrecision { set; get; }
        private double MeleePrecision { set; get; }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string value)
        {
            Name = value;
        }

        public string GetDescription()
        {
            return Description;
        }

        public void SetDescription(string value)
        {
            Description = value;
        }

        public string GetJobClass()
        {
            return JobClass;
        }

        public void SetJobClass(string value)
        {
            JobClass = value;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int value)
        {
            Age = value;
        }

        public int GetReputation()
        {
            return this.Reputation;
        }

        public void SetReputation(int value)
        {
            this.Reputation = value;
        }

        public int GetLevel()
        {
            return Level;
        }

        public void SetLevel(int value)
        {
            Level = value;
        }

        public int GetExpBase()
        {
            return ExpBase;
        }

        public void SetExpBase(int value)
        {
            ExpBase = value;
        }

        public int GetExpRequirement()
        {
            return ExpRequirement;
        }

        public void SetExpRequirement(int value)
        {
            ExpRequirement = value;
        }

        public int GetStatPoints()
        {
            return StatPoints;
        }

        public void SetStatPoints(int value)
        {
            StatPoints = value;
        }

        public int GetSkillPoints()
        {
            return SkillPoints;
        }

        public void SetSkillPoints(int value)
        {
            SkillPoints = value;
        }

        public int GetTraitPoints()
        {
            return TraitPoints;
        }

        public void SetTraitPoints(int value)
        {
            TraitPoints = value;
        }

        public int GetMight()
        {
            return Might;
        }

        public void SetMight(int value)
        {
            Might = value;
        }

        public int GetVitality()
        {
            return Vitality;
        }

        public void SetVitality(int value)
        {
            Vitality = value;
        }

        public int GetAgility()
        {
            return Agility;
        }

        public void SetAgility(int value)
        {
            Agility = value;
        }

        public int GetDexterity()
        {
            return Dexterity;
        }

        public void SetDexterity(int value)
        {
            Dexterity = value;
        }

        public int GetIntellect()
        {
            return Intellect;
        }

        public void SetIntellect(int value)
        {
            Intellect = value;
        }

        public int GetMagic()
        {
            return Magic;
        }

        public void SetMagic(int value)
        {
            Magic = value;
        }

        public int GetCharisma()
        {
            return Charisma;
        }

        public void SetCharisma(int value)
        {
            Charisma = value;
        }

        public int GetWill()
        {
            return Will;
        }

        public void SetWill(int value)
        {
            Will = value;
        }

        public int GetPerception()
        {
            return Perception;
        }

        public void SetPerception(int value)
        {
            Perception = value;
        }

        public int GetHitPointCapacity()
        {
            return HitPointCapacity;
        }

        public void SetHitPointCapacity(int value)
        {
            HitPointCapacity = value;
        }

        public int GetHitPoints()
        {
            return HitPoints;
        }

        public void SetHitPoints(int value)
        {
            HitPoints = value;
        }

        public int GetStaminaCapacity()
        {
            return StaminaCapacity;
        }

        public void SetStaminaCapacity(int value)
        {
            StaminaCapacity = value;
        }

        public int GetRethorics()
        {
            return Rethorics;
        }

        public void SetRethorics(int value)
        {
            Rethorics = value;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public void SetSpeed(int value)
        {
            Speed = value;
        }

        public double GetRangedPrecision()
        {
            return RangedPrecision;
        }

        public void SetRangedPrecision(double value)
        {
            RangedPrecision = value;
        }

        public double GetMeleePrecision()
        {
            return MeleePrecision;
        }

        public void SetMeleePrecision(double value)
        {
            MeleePrecision = value;
        }

        public double GetAccuracy()
        {
            return Accuracy;
        }

        public void SetAccuracy(double value)
        {
            Accuracy = value;
        }

        public int GetMeleeDamage()
        {
            return MeleeDamage;
        }

        public void SetMeleeDamage(int value)
        {
            MeleeDamage = value;
        }

        public int GetRangedDamage()
        {
            return RangedDamage;
        }

        public void SetRangedDamage(int value)
        {
            RangedDamage = value;
        }

        // Calculation Methods
        public void CalculateStats(int Level)
        {
            SetLevel(Level);
            StatPointsCalc(Level);
            SkillPointsCalc(Level, Intellect);
            TraitPointsCalc(Level);
            HitPointCapacityCalc(Vitality, Might);
            HitPointsCalc(HitPointCapacity);
            StaminaCapacityCalc(Might, Vitality);
            RethoricsCalc(Charisma, Intellect, Will);
            SpeedCalc(Agility, Vitality);
            MeleePrecisionCalc(Dexterity, Perception, Might);
            int AccMod = AccuracyModCalc(Accuracy);
            int MeleePrecisionMod = MeleePrecisionModCalc(MeleePrecision);
            RangedDamageCalc(Dexterity, Perception, AccMod);
            MeleeDamageCalc(Might, Dexterity, MeleePrecisionMod);

            RangedPrecisionCalc(Dexterity, Perception);
            AccuracyCalc(Perception);
        }

        public void StatPointsCalc(int Level)
        {
            SetStatPoints(Level * 5);
        }

        public void SkillPointsCalc(int Level, int Intellect)
        {
            if (Level % 5 != 0 && Intellect % 2 == 0)
            {
                SetSkillPoints(Level + Intellect / 2);
            }
            else if (Level % 5 != 0 && Intellect % 3 == 0)
            {
                SetSkillPoints(Level + Intellect / 3);
            }
            SetSkillPoints(Level);
        }

        public void TraitPointsCalc(int Level)
        {
            if (Level % 6 == 0)
            {
                SetTraitPoints(Level);
            }
        }

        public void HitPointCapacityCalc(int Vitality, int Might)
        {
            SetHitPointCapacity((Vitality + Might) * 2);
        }

        public void HitPointsCalc(int HitPointCapacity)
        {
            SetHitPoints(HitPointCapacity);
        }

        public void StaminaCapacityCalc(int Might, int Vitality)
        {
            SetStaminaCapacity((Might + Vitality) / 2);
        }

        public void RethoricsCalc(int Charisma, int Intellect, int Will)
        {
            SetRethorics((Charisma + Intellect + Will) / 3);
        }

        public void SpeedCalc(int Agility, int Vitality)
        {
            SetSpeed((Agility + Vitality) / 2);
        }

        public void RangedDamageCalc(int Dexterity, int Perception, int AccuracyMod)
        {
            SetRangedDamage((Dexterity + Perception + AccuracyMod) / 3);
        }

        private static int AccuracyModCalc(double Accuracy)
        {
            int AccuracyMod = 0;
            for (int i = 0; i <= Accuracy; i++)
            {
                if (i % 5 == 0)
                {
                    AccuracyMod++;
                }
            }

            return AccuracyMod;
        }

        public void MeleeDamageCalc(int Might, int Dexterity, int MeleePrecisionMod)
        {
            SetMeleeDamage((Might + Dexterity + MeleePrecisionMod) / 3);
        }

        private int MeleePrecisionModCalc(double MeleePrecision)
        {
            int MeleePrecisionMod = 0;

            for (int i = 0; i <= Accuracy; i++)
            {
                if (i % 5 == 0)
                {
                    MeleePrecision++;
                }
            }
            return MeleePrecisionMod;
        }

        public void RangedPrecisionCalc(int Dexterity, int Perception)
        {
            SetRangedPrecision(Dexterity + Perception);
        }

        public void MeleePrecisionCalc(int Dexterity, int Perception, int Might)
        {
            SetMeleePrecision(Dexterity + Perception + Might);
        }

        public void AccuracyCalc(int Perception)
        {
            SetAccuracy(Perception);
        }

        // Stats Display Methods

        public void ToStringComplete()
        {
            Gui.PrintLine(
                $"Name: {Name}\n"
                    + $"Description {Description}\n"
                    + $"JobClass {JobClass}\n"
                    + $"Age: {Age}\n"
                    + $"Level {Level}\n"
                    + $"Exp: {ExpBase} / {ExpRequirement}\n"
                    + $"Stat Points {StatPoints}\n"
                    + $"Trait Points: {StatPoints}\n"
                    + $"Skill Points {SkillPoints}\n"
                    + $"Might: {Might}\n"
                    + $"Vitality: {Vitality}\n"
                    + $"Agility: {Agility}\n"
                    + $"Dexterity: {Dexterity}\n"
                    + $"Intellect: {Intellect}\n"
                    + $"Magic: {Magic}\n"
                    + $"Charisma: {Charisma}\n"
                    + $"Will: {Will}\n"
                    + $"Perception: {Perception}\n"
                    + $"HitPoints {HitPoints} / {HitPointCapacity}\n"
                    + $"Stamina Capacity: {StaminaCapacity}\n"
                    + $"Speed: {Speed}\n"
                    + $"Accuracy: {Accuracy}\n"
                    + $"Melee Damage: {MeleeDamage}\n"
                    + $"Ranged Damage: {RangedDamage}\n"
                    + $"Melee Precision: {MeleePrecision}\n"
                    + $"Ranged Precision: {RangedPrecision}"
            );
        }
    }
}
