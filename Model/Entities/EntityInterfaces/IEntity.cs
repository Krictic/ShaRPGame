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

        string GetName();
        void SetName(string value);

        string GetDescription();
        void SetDescription(string value);

        string GetJobClass();
        void SetJobClass(string value);

        int GetAge();
        void SetAge(int value);

        // Progression Variables
        int GetLevel();
        void SetLevel(int value);

        int GetExpBase();
        void SetExpBase(int value);

        int GetExpRequirement();
        void SetExpRequirement(int value);

        int GetStatPoints();
        void SetStatPoints(int value);

        int GetSkillPoints();
        void SetSkillPoints(int value);
        int GetTraitPoints();
        void SetTraitPoints(int value);

        // Primary Stat Variables (innate but can be improved)

        // General measure of physical prowess.
        int GetMight();
        void SetMight(int value);

        //  General measure of health
        int GetVitality();
        void SetVitality(int value);

        // General measure of how well one can move their own body.
        int GetAgility();
        void SetAgility(int value);

        // General measure of one´s fine motor skills
        int GetDexterity();
        void SetDexterity(int value);

        // General measure of mental acuity
        int GetIntellect();
        void SetIntellect(int value);

        // General measure of one´s magical potential, not inherently related to intellect
        int GetMagic();
        void SetMagic(int value);

        // General measure of one´s social skills
        int GetCharisma();
        void SetCharisma(int value);

        // General measure of one´s psychological might. Used to resist suggestion, provocation, torture and son.
        int GetWill();
        void SetWill(int value);

        //  General measure of one´s awareness of their surroundings
        int GetPerception();
        void SetPerception(int value);

        // Secondary Stat Variables

        // (Vitality + Might) * 2;
        int GetHitPointCapacity();
        void SetHitPointCapacity(int value);

        // Equal to HitPointCapacity at CharacterCreation.
        int GetHitPoints();
        void SetHitPoints(int value);

        // (Might + Vitality) / 2 where every 5 points increase stamina by 1. Spent by every action, as it reaches zero
        // malus statuses will be applied, each worse than the last one.
        // If it reaches zero, then the character will be unable to act for 3 turns.
        int GetStaminaCapacity();
        void SetStaminaCapacity(int value);

        // How fast your chaarcter can move, determined how many steps they can take every turn.
        // (Agility + Vitality) / 2.
        int GetSpeed();
        void SetSpeed(int value);

        // Tertiary Stat Variables (derived from secondary stats)
        // Ability to hit (or not) specific parts of the target. For example, if you want to shoot specifically the eyes of the target.
        // (Dexterity + Perception)
        double GetRangedPrecision();
        void SetRangedPrecision(double value);

        // Ability to hit a target at melee, for example, it is required to hit at armor gaps in the absense non-blunt weapons.
        double GetMeleePrecision();
        void SetMeleePrecision(double value);

        // Ability to consistently not miss targets at range.
        double GetAccuracy();
        void SetAccuracy(double value);

        // A n-sided dice, n = (Might + Dexterity + MeleePrecision) / 3. Every 9 points increasses it by 2.
        int GetMeleeDamage();
        void SetMeleeDamage(int value);

        // A n-sided dice, n = {Dexterity + Perception + Accuracy} / 3. Every 9 points increases it by 2.
        int GetRangedDamage();
        void SetRangedDamage(int value);

        // The ability to convince someone to agree or do something you wish.
        // (Charisma + Intellect + Will) / 3.
        int GetRethorics();
        void SetRethorics(int value);

        // Stat Calculation Methods

        void CalculateStats(int Level); // This will call all stat calculation methods and unify them.
        void StatPointsCalc(int Level);
        void SkillPointsCalc(int Level, int Intellect);
        void TraitPointsCalc(int Level);
        void HitPointCapacityCalc(int Vitality, int Might);
        void HitPointsCalc(int HitPointCapacity);
        void StaminaCapacityCalc(int Might, int Vitality);
        void rethoricsCalc(int Charisma, int Intellect, int Will);
        void SpeedCalc(int Agility, int Vitality);
        void RangedDamageCalc(int Dexterity, int Perception, int Accuracy);
        void MeleeDamageCaclc(int Might, int Dexterity, int MeleePrecision);
        void RangedPrecisionCalc(int Dexterity, int Perception);
        void MeleePrecisionCalc(int Dexterity, int Perception, int Might);
        void AccuracyCalc(int Perception);

        // Action methods
    }
}
