using System.Collections;
using System.Dynamic;
using ShaRPGame.Model.Entities.EntityInterfaces;

namespace ShaRPGame.Model.Entities.PlayerCharacters
{
    internal class CharacterModel : IJobs, ISkills, ITraits, IStatuses
    {
        // Description Variables
        public string Name { set; get; } = "Playc Holdr";
        public string Description { set; get; } = "that I am but a modest Placeholder";
        public string JobClass { set; get; } = "Placeholder";
        public int Age { set; get; } = 20;
        public int Level { set; get; } = 1;
        // Progression Variables
        public int StatPoints { get; set; }
        public int SkillPoints { get; set; }
        // Core Stat Variables
        public int Might { get; set; }
        public int Vitality { get; set; }
        public int Agility { get; set; }
        public int Dexterity { get; set; }
        public int Intellect { get; set; }
        public int Magic { get; set; }
        public int Charisma { set; get; }
        public int Will { get; set; }

        // Secondary Stat Variables
        public int HitPoints { get; set; }
        public int HitPointCapacity { set; get; }
        public int MeleeDamage { set; get; }
        public int StaminaCapacity { get; set; }
        public int Perception { set; get; }

        // Tertiary Stat variables
        public double CriticalChance { set; get; }
        public double CriticalDamage { set; get; }
        public int Precision { set; get; }
        public int Accuracy { set; get; }

        public string GetName()
        {
            return this.Name;
        }

        public void Setname(string value)
        {
            this.Name = value;
        }

        public string GetBiography()
        {
            return this.Description;
        }

        public void SetBiography(string value)
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


        // Action Methods
        public string attack()
        {
            return $"{this.Name} dttacks!";
        }

        public string defend()
        {
            return $"{this.Name} defends!";
        }

        public string speak()
        {
            string name = this.Name;
            string biography = this.Description;
            string jobClass = this.JobClass;
            int age = this.Age;
            int level = this.Level;

            return $"My name is {name} and I am {age}, my bio is {biography} and im currently a level {level} {jobClass}.";
        }

        // Display Methods

        public ArrayList ToArrayList()
        {
            ArrayList array = new ArrayList();
            array.Add(this);
            return array;
        }
    }
}
