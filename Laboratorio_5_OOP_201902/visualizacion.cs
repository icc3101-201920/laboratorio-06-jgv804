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
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("Hand: ");
            
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].GetType().Name == nameof(CombatCard))
                {
                    Console.ForegroundColor = red;
                    Console.Write( $"|({hand.Cards[i].Id}) " + hand.Cards[i].Name + $" {hand.Cards[i].type} :{hand.Cards[i].attackpoints} |");
                }
                else
                {
                    Console.ForegroundColor = blue;
                    Console.Write( $"|({hand.Cards[i].Id}) " + hand.Cards[i].Name + $" {hand.Cards[i].type} |");
                }

            }
            Console.Writeline();
            
        }
        public static void ShowDecks(List<Deck> decks)
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("select one deck:");
            for (i = 0; i < decks.Count; i++)
            {
                Console.WriteLine($"{(i)} Deck {i + 1}");
            }

        }
    }
}
