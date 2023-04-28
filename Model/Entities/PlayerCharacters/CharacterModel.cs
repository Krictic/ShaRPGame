using System.Collections;
using System.Dynamic;
using ShaRPGame.Model.Entities.EntityInterfaces;

namespace ShaRPGame.Model.Entities.PlayerCharacters
{
    internal class CharacterModel : IEntity, IPlayer, IJobs, ISkills, ITraits, IStatuses
    {
        public CharacterModel(string name = "Playc Holdr", string description = "He is but a modest Placeholder", string jobClass = "Placeholder", int age = 20)
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

        // Progression Variables
        private int Level { set; get; } = 1;
        private int ExpBase { set; get; } = 50;
        private int ExpRequirement { set; get; } = 100;
        private int StatPoints { get; set; }
        private int SkillPoints { get; set; }
        private int TraitPoints { get; set; }

        // Core Stat Variables
        private int Might { get; set; }
        private int Vitality { get; set; }
        private int Agility { get; set; }
        private int Dexterity { get; set; }
        private int Intellect { get; set; }
        private int Magic { get; set; }
        private int Charisma { set; get; }
        private int Will { get; set; }
        private int Perception { set; get; }

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
            return this.Name;
        }

        public void SetName(string value)
        {
            this.Name = value;
        }

        public string GetDescription()
        {
            return this.Description;
        }

        public void SetDescription(string value)
        {
            this.Description = value;
        }

        public string GetJobClass()
        {
            return this.JobClass;
        }

        public void SetJobClass(string value)
        {
            this.JobClass = value;
        }

        public int GetAge()
        {
            return this.Age;
        }

        public void SetAge(int value)
        {
            this.Age = value;
        }

        public int GetLevel()
        {
            return this.Level;
        }

        public void SetLevel(int value)
        {
            this.Level = value;
        }

        public int GetExpBase()
        {
            return this.ExpBase;
        }

        public void SetExpBase(int value)
        {
            this.ExpBase = value;
        }

        public int GetExpRequirement()
        {
            return this.ExpRequirement;
        }

        public void SetExpRequirement(int value)
        {
            this.ExpRequirement = value;
        }

        public int GetStatPoints()
        {
            return this.StatPoints;
        }

        public void SetStatPoints(int value)
        {
            this.StatPoints = value;
        }

        public int GetSkillPoints()
        {
            return this.SkillPoints;
        }

        public void SetSkillPoints(int value)
        {
            this.SkillPoints = value;
        }

        public int GetTraitPoints()
        {
            return this.TraitPoints;
        }

        public void SetTraitPoints(int value)
        {
            this.TraitPoints = value;
        }

        public int GetMight()
        {
            return this.Might;
        }

        public void SetMight(int value)
        {
            this.Might = value;
        }

        public int GetVitality()
        {
            return this.Vitality;
        }

        public void SetVitality(int value)
        {
            this.Vitality = value;
        }

        public int GetAgility()
        {
            return this.Agility;
        }

        public void SetAgility(int value)
        {
            this.Agility = value;
        }

        public int GetDexterity()
        {
            return this.Dexterity;
        }

        public void SetDexterity(int value)
        {
            this.Dexterity = value;
        }

        public int GetIntellect()
        {
            return this.Intellect;
        }

        public void SetIntellect(int value)
        {
            this.Intellect = value;
        }

        public int GetMagic()
        {
            return this.Magic;
        }

        public void SetMagic(int value)
        {
            this.Magic = value;
        }

        public int GetCharisma()
        {
            return this.Charisma;
        }

        public void SetCharisma(int value)
        {
            this.Charisma = value;
        }

        public int GetWill()
        {
            return this.Will;
        }

        public void SetWill(int value)
        {
            this.Will = value;
        }

        public int GetPerception()
        {
            return this.Perception;
        }

        public void SetPerception(int value)
        {
            this.Perception = value;
        }

        public int GetHitPointCapacity()
        {
            return this.HitPointCapacity;
        }

        public void SetHitPointCapacity(int value)
        {
            this.HitPointCapacity = value;
        }

        public int GetHitPoints()
        {
            return this.HitPoints;
        }

        public void SetHitPoints(int value)
        {
            this.HitPoints = value;
        }

        public int GetStaminaCapacity()
        {
            return this.StaminaCapacity;
        }

        public void SetStaminaCapacity(int value)
        {
            this.StaminaCapacity = value;
        }

        public int GetRethorics()
        {
            return this.Rethorics;
        }

        public void SetRethorics(int value)
        {
            this.Rethorics = value;
        }

        public int GetSpeed()
        {
            return this.Speed;
        }

        public void SetSpeed(int value)
        {
            this.Speed = value;
        }

        public double GetRangedPrecision()
        {
            return this.RangedPrecision;
        }

        public void SetRangedPrecision(double value)
        {
            this.RangedPrecision = value;
        }

        public double GetMeleePrecision()
        {
            return this.MeleePrecision;
        }

        public void SetMeleePrecision(double value)
        {
            this.MeleePrecision = value;
        }

        public double GetAccuracy()
        {
            return this.Accuracy;
        }

        public void SetAccuracy(double value)
        {
            this.Accuracy = value;
        }

        public int GetMeleeDamage()
        {
            return this.MeleeDamage;
        }

        public void SetMeleeDamage(int value)
        {
            this.MeleeDamage = value;
        }

        public int GetRangedDamage()
        {
            return this.RangedDamage;
        }

        public void SetRangedDamage(int value)
        {
            this.RangedDamage = value;
        }

        // Calculation Methods
        public void CalculateStats(int Level)
        {
            SetLevel(Level);
        }

        public void StatPointsCalc(int Level)
        {
            throw new NotImplementedException();
        }
        public void SkillPointsCalc(int Level, int Intellect)
        {
            throw new NotImplementedException();
        }
        public void TraitPointsCalc(int Level)
        {
            throw new NotImplementedException();
        }

        public void HitPointCapacityCalc(int Vitality, int Might)
        {
            throw new NotImplementedException();
        }

        public void HitPointsCalc(int HitPointCapacity)
        {
            throw new NotImplementedException();
        }

        public void StaminaCapacityCalc(int Might, int Vitality)
        {
            throw new NotImplementedException();
        }

        public void rethoricsCalc(int Charisma, int Intellect, int Will)
        {
            throw new NotImplementedException();
        }

        public void SpeedCalc(int Agility, int Vitality)
        {
            throw new NotImplementedException();
        }

        public void RangedDamageCalc(int Dexterity, int Perception, int Accuracy)
        {
            throw new NotImplementedException();
        }

        public void MeleeDamageCaclc(int Might, int Dexterity, int MeleePrecision)
        {
            throw new NotImplementedException();
        }

        public void RangedPrecisionCalc(int Dexterity, int Perception)
        {
            throw new NotImplementedException();
        }

        public void MeleePrecisionCalc(int Dexterity, int Perception, int Might)
        {
            throw new NotImplementedException();
        }

        public void AccuracyCalc(int Perception)
        {
            throw new NotImplementedException();
        }

        // Action Methods

    }
}
