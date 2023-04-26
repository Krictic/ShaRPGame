using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaRPGame.Model.Entities.EntityInterfaces
{
    internal interface IEntity
    {
        // Descriptor Variables (fixed and unchangeable, can onyl be set at character creation)

        // The entity´s name
        string Name { set; get; }
        // What this entity is
        string Description { set; get; }


        // Progression Variables
        string JobClass { set; get; }
        int Age { set; get; }
        int Level { set; get; }
        int StatPoints { set; get; }
        int SkillPoints { set; get; }
        int TraitPoints { set; get; }

        // Primary Stat Variables (innate but can be improved)

        // General measure of physical prowess.
        int Might { set; get; }
        //  General measure of health
        int Vitality { set; get; }
        // General measure of how well one can move their own body.
        int Agility { set; get; }
        // General measure of one´s fine motor skills
        int Dexterity { set; get; }
        // General measure of mental acuity
        int Intellect { set; get; }
        // General measure of one´s magical potential, not inherently related to intellect
        int Magic { set; get; }
        // General measure of one´s social skills
        int Charisma { set; get; }
        // General measure of one´s psychological might. Used to resist suggestion, provocation, torture and son.
        int Will { get; set; }
        //  General measure of one´s awareness of their surroundings
        int Perception { set; get; }



        // Secondary Stat Variables

        // (Vitality + Might) * 2;
        int HitPointCapacity { set; get; }

        // Equal to HitPointCapacity at CharacterCreation.
        int HitPoints { get; set; }


        // Might + Vitality) / 2 where every 5 points increase stamina by 1. Spent by every action, as it reaches zero
        // malus statuses will be applied, each worse than the last one.
        // If it reaches zero, then the character will be unable to act for 3 turns.

        int StaminaCapacity { get; set; }

        // The ability to convince someone to agree or do something you wish.
        // (Charisma + Intellect + Will) / 3.
        int Rethorics { set; get; };

        // How fast your chaarcter can move, determined how many steps they can take every turn.
        // (Agility + Vitality) / 2.
        int Speed { set; get; }


        // Tertiary Stat Variables (derived from secondary stats)

        // Ability to hit (or not) specific parts of the target. For example, if you want to shoot specifically the eyes of the target.
        // (Dexterity + Precission)
        double RangedPrecision { set; get; }

        // Ability to hit a target at melee, for example, it is required to hit at armor gaps in the absense non-blunt weapons.
        double MeleePrecision { set; get; }

        // Ability to consistently not miss targets at range.
        double Accuracy { set; get; }

        // A n-sided dice, n = (Might + Dexterity + Precision) / 3. Every 9 points increasses it by 2.
        int MeleeDamage { set; get; }

        // A n-sided dice, n = {Dexterity + Perception + Accuracy} / 3. Every 9 points increases it by 2.
        int RangedDamage { set; get; }

        // Stat Calculation Methods

        void CalculateStats(); // This will call all stat calculation methods and unify them.
        int MaxHitPointCalc();
        int DamageModCalc();
        int BasicDamageCalc();
        int StaminaCapacityCalc();
        int rethorics();
        int SpeedCalc();
        int RangedDamageCalc();
        int MeleeDamageCaclc();
        double RangedPrecisionCalc();
        double MeleePrecisionCalc();
        int PerceptionCalc();
        double AccuracyCalc();

        // Action methods
        string attack();
        string defend();
        string speak();
        string move();
    }
}
