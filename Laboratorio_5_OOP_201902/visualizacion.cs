using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laboratorio_5_OOP_201902
{
    public static class visualizacion
    {

        public static void ShowHand(Hand hand)
        {
            Console.setcursor(0, 14);
            Console.Writeline("Hand: ");
            string line = "";
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].GetType().Name == nameof(CombatCard))
                {
                    Console.ForegroundColor = red;
                    line = line + $"|({hand.Cards[i].Id}) " + hand.Cards[i].Name + $" {hand.Cards[i].type} |";
                }
                else
                {
                    Console.ForegroundColor = blue;
                    line = line + $"|({hand.Cards[i].Id}) " + hand.Cards[i].Name + $" {hand.Cards[i].type} |";
                }
            }
            Console.writeline(line);
        }
        public static void ShowDecks(List<Deck> decks)
        {

        }
    }
}
