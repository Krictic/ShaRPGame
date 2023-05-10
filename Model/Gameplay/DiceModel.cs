namespace ShaRPGame.Model.GameplayModels
{
    internal class DiceModel
    {
        // Will "roll" a n-sided dice
        public static int RollDice(int size)
        {
            Random rng = new Random();
            return rng.Next(size + 1);
        }
    }
}
