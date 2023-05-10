using ShaRPGame.Model.Gameplay.Items.Model;
using ShaRPGame.View;

namespace ShaRPGame.Controllers.DebugMenu
{
    internal class ItemGeneratorController
    {
        public static void ProcessInput(string input)
        {
            switch (input)
            {
                case "-1":
                case "E":
                    Console.Clear();
                    MainMenuView.Menu();
                    break;
                case "0":
                case "L":
                    Console.Clear();
                    LightArmor lightArmor = new LightArmor();
                    lightArmor.GenerateRandom(10, 10);
                    break;
            }
        }
    }
}
