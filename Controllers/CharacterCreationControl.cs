﻿using ShaRPG.View.GUI;
using ShaRPGame.Model;
using ShaRPGame.View;

namespace ShaRPGame.Controllers
{
    internal class CharacterCreationControl
    {
        public static void ProcessInput(string input)
        {
            switch (input)
            {
                case "-1":
                case "R":
                    Console.Clear();
                    MainMenuView.Menu();
                    break;
                case "1":
                case "C":
                    Console.Clear();
                    int age = 0;
                    Console.WriteLine("Creating a new character.");
                    string name = Gui.GetInputIntBasic("What´s the name of your character?");
                    string description = Gui.GetInputIntBasic("Tell me something about your character?");
                    string jobClass = Gui.GetInputIntBasic("What´s their class?");
                    age = AgeInput(age);
                    CharacterCreatorModel.CreateCharacter(name, description, jobClass, age);
                    CharacterCreatorView.Menu();
                    break;
                default:
                    Console.Clear();
                    Gui.Alert("Invalid input, pleae try again.");
                    CharacterCreatorView.Menu();
                    break;
            }
        }

        // Made this spurious method jsut ebcause I want the controller to feel a little bti neater for me.
        private static int AgeInput(int age)
        {
            while (age <= 17 | age >= 70) // Is 70 yo too old for adventuring? Sorry, that was a strange thing to ask.
            {
                try
                {
                    age = Convert.ToInt32(Gui.GetInputIntBasic("Finally tell me their age."));
                    Gui.Alert("Sorry, the character cannot be under 18 or over 70.");
                }
                catch (Exception ex)
                {
                    Gui.Alert(ex.Message);
                }
            }

            return age;
        }
    }
}
