using Laboratorio_5_OOP_201902.Cards;
using Laboratorio_5_OOP_201902.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laboratorio_5_OOP_201902
{
    public static class Visualizacion
    {

        
        public static void ShowHand(Hand hand)
        {
            
            Console.WriteLine("Hand: ");
            
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].GetType().Name == nameof(CombatCard))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    CombatCard Combi =(CombatCard)hand.Cards[i];
                    Console.Write( $"|({i}) " + hand.Cards[i].Name + $" ({hand.Cards[i].Type}) : {Combi.AttackPoints} |");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write( $"|({i}) " + hand.Cards[i].Name + $" ({hand.Cards[i].Type}) |");
                    Console.ResetColor();
                }

            }
            Console.WriteLine("");
            
        }
        public static void ShowDecks(List<Deck> decks)
        {
            
            Console.WriteLine("Select one deck:");
            for (int i = 0; i < decks.Count; i++)
            {
                Console.WriteLine($"({i}) Deck {i + 1}");
            }

        }
        public static void ShowCaptains(List<SpecialCard> captains)
        {
            Console.WriteLine("Select one captain:");
            for(int i = 0; i < captains.Count; i++)
            {
                Console.WriteLine($"({i}) {captains[i].Name} : {captains[i].Effect}");
            }
        }
        public static void ConsoleError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Beep();
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static int GetUserInput(int maxInput, bool stopper = false)
        {
            string option = Console.ReadLine();
            int optionNumber;
            if (stopper)
            {

                while (!int.TryParse(option, out optionNumber))
                {
                    ConsoleError("Input must be a number");
                    option = Console.ReadLine();
                }

                if (-1 <= optionNumber & optionNumber < maxInput)
                {
                    return optionNumber;
                }
                else
                {
                    ConsoleError("imput out of range");
                    option = Console.ReadLine();
                }
            }
            else
            {
                while (!int.TryParse(option, out optionNumber))
                {
                    ConsoleError("Input must be a number");
                    option = Console.ReadLine();
                }

                if (0 <= optionNumber & optionNumber < maxInput)
                {
                    return optionNumber;
                }
                else
                {
                    ConsoleError("imput out of range");
                    option = Console.ReadLine();
                }
            }
            return optionNumber;
            
           
        }
        public static void ShowListOption(List<String> options,string message=null)
        {
            Console.WriteLine(message);
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"({i}) {options[i]}");
            }
        }
        public static void ShowProgramMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
            
        }
        public static void ClearConsole()
        {
            Console.Clear();
        }
    }
}
