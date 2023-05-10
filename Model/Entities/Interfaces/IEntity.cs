namespace ShaRPGame.Model.Entities.EntityInterfaces
{
    internal interface IEntity
    {
        // Descriptor Variables (fixed and unchangeable, can only be set at character creation)

        string GetName();
        void SetName(string value);

        string GetDescription();
        void SetDescription(string value);

        string GetJobClass();
        void SetJobClass(string value);

        int GetAge();
        void SetAge(int value);

        int GetReputation();
        void SetReputation(int value);

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

        int GetHitPointCapacity();
        void SetHitPointCapacity(int value);

        int GetHitPoints();
        void SetHitPoints(int value);
        
        int GetStaminaCapacity();
        void SetStaminaCapacity(int value);

        int GetSpeed();
        void SetSpeed(int value);

        // Tertiary Stat Variables (derived from secondary stats)
        double GetRangedPrecision();
        void SetRangedPrecision(double value);

        double GetMeleePrecision();
        void SetMeleePrecision(double value);

        double GetAccuracy();
        void SetAccuracy(double value);

        int GetMeleeDamage();
        void SetMeleeDamage(int value);

        int GetRangedDamage();
        void SetRangedDamage(int value);

        int GetRethorics();
        void SetRethorics(int value);

        void CalculateStats(int Level);
        void StatPointsCalc(int Level);
        void SkillPointsCalc(int Level, int Intellect);
        void TraitPointsCalc(int Level);
        void HitPointCapacityCalc(int Vitality, int Might);
        void HitPointsCalc(int HitPointCapacity);
        void StaminaCapacityCalc(int Might, int Vitality);
        void RethoricsCalc(int Charisma, int Intellect, int Will);
        void SpeedCalc(int Agility, int Vitality);
        void RangedDamageCalc(int Dexterity, int Perception, int Accuracy);
        void MeleeDamageCalc(int Might, int Dexterity, int MeleePrecision);
        void RangedPrecisionCalc(int Dexterity, int Perception);
        void MeleePrecisionCalc(int Dexterity, int Perception, int Might);
        void AccuracyCalc(int Perception);
    }
}
