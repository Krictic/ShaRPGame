﻿using ShaRPG.View.GUI;
using ShaRPGame.Model;
using ShaRPGame.Model.Entities.PlayerCharacters;
using ShaRPGame.Model.InstanceModels;
using ShaRPGame.View;

namespace ShaRPGame.Controllers
{
    internal class CharacterSelectorController
    {
        // Bug here: if the player types an index out of bounds, then the game crashes, gotta find a way fo solving this.
        public static void ListProcessing()
        {
            int input = 0;
            CharacterListModel CharaList = CharacterSelectorModel.ListAll();

            // How do I handle the exception if the input is null?
            while (input >= CharaList.GetLength() && input <= 0)
            {
                input = Convert.ToInt32(Gui.GetInputIntUpperCase("Please, select the index of the character you wish to select to activate it."));
                if (input <= CharaList.GetLength() && input >= 0)
                {
                    CharacterModel character = (CharacterModel)CharaList.GetCharacterList()[input];
                    CharacterSelectorModel.ActivateCharacter(character);
                    ActiveCharacterModel activeCharacterInstance = ActiveCharacterModel.GetIntance();
                    CharacterModel activeCharacter = activeCharacterInstance.GetActiveCharacter();
                    Gui.PrintLine(activeCharacter.GetName() + " has been activated.");
                    MainMenuView.Menu();
                }
                else
                {
                    Gui.Alert("The indicated index is not within the current bound of the list of created characters.");
                    ListProcessing();
                }
            }
        }
    }
}
