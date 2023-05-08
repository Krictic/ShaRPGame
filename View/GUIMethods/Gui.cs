﻿using ShaRPGame.Model.Entities.Models.PlayerCharacters;

namespace ShaRPG.View.GUI
{
    internal class Gui
    {
        public static void Title(string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            str = string.Format("==== {0} ====\n", str);
            Console.Write(str);
            Console.ResetColor();
        }

        public static void MenuTitle(string str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            str = string.Format("=== {0} ===\n", str);
            Console.Write(str);
            Console.ResetColor();
        }
        public static void MenuOption(int index, string str)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            str = string.Format(" - ({0}) : {1}\n", index, str);
            Console.Write(str);
            Console.ResetColor();
        }

        public static void Announcement(string str)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            str = string.Format("(~) ({0}) \n", str);
            Console.Write(str);
            Console.ResetColor();
        }

        public static void Alert(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            str = string.Format("\t(!!!) ({0}) \n", str);
            Console.Write(str);
            Console.ResetColor();
        }

        public static void PrintLine(string str)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            str = string.Format("{0} \n", str);
            Console.WriteLine(str);
        }

        public static void Print(string str)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            str = string.Format("\t {0} \n", str);
            Console.Write(str);
        }

        public static string ProgressBar(int min, int max, double width)
        {
            string bar = "[";
            double percent = (double)min / max;
            int complete = Convert.ToInt32(percent * width);


            for (int i = 0; i < complete; i++)
            {
                bar += "/";
            }

            for (int i = complete; i < width; i++)
            {
                bar += "-";
            }

            bar += "]";

            return bar;
        }



        public static void GetInput(object str)
        {
            str = string.Format("{0} -> ", str);
            Console.Write(str);
        }


        /// <summary>
        /// This will validate inputs and throw errors
        /// if the input is not valid.
        /// </summary>
        /// <param PlayerName="message"></param>
        /// <returns></returns>
        public static string GetInputIntUpperCase(string message)
        {
            string? input = null;

            while (input == null)
            {
                try
                {
                    GetInput(message);
                    input = Console.ReadLine().ToUpper().Trim();
                }
                catch (Exception e) // Error
                {
                    Console.WriteLine(e.Message);
                }
            }

            return input;
        }

        public static string GetInputIntBasic(object message)
        {
            string? input = null;

            while (input == null)
            {
                try
                {
                    GetInput(message);
                    input = Console.ReadLine().Trim();
                }
                catch (Exception e) // Error
                {
                    Console.WriteLine(e.Message);
                }
            }

            return input;
        }

        /// <summary>
        /// This will create a character banner for you selecter character, formated to adapt
        /// to the size of the raw banner string generated by the ToStringBanner method.
        /// </summary>
        public static void CharacterBannerCreate(CharacterModel activeCharacter)
        {
            int bannerLen = ToStringBanner(activeCharacter).Length;
            string label = "   Active Character   ";
            int labelLen = label.Length;
            int bannerLenMinusLabelLen = bannerLen - labelLen;
            for (int i = 0; i < bannerLenMinusLabelLen; i++)
            {
                if (i == bannerLenMinusLabelLen / 2)
                {
                    Console.Write(label);
                }
                Console.Write("=");
            }
            Console.Write('\n');
            Console.WriteLine(string.Format("{0}", ToStringBanner(activeCharacter)));
            for (int i = 0; i < bannerLen; i++)
            {
                Console.Write("=");
            }
            Console.Write('\n');
        }

        public static string ToStringBanner(CharacterModel character)
        {
            double percentile;
            if (character.GetExpBase() == 0)
            {
                percentile = 0;
            }
            else
            {
                percentile = ((double)character.GetExpBase() / (double)character.GetExpRequirement()) * 100;
            }
            string str =
                $"[ {character.GetName()} | Lv: {character.GetLevel()} | Job: {character.GetJobClass()} | Exp: {character.GetExpBase()} / {character.GetExpRequirement()} ({percentile}%)]";

            return str;
        }
    }
}
