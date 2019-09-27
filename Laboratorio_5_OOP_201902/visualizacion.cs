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
                    Console.ForegroundColor = red;
                    Console.Write( $"|({hand.Cards[i].Id}) " + hand.Cards[i].Name + $" {hand.Cards[i].Type} :{hand.Cards[i].AttackPoints} |");
                }
                else
                {
                    Console.ForegroundColor = blue;
                    Console.Write( $"|({hand.Cards[i].Id}) " + hand.Cards[i].Name + $" {hand.Cards[i].Type} |");
                }

            }
            Console.Writeline();
            
        }
        public static void ShowDecks(List<Deck> decks)
        {
            
            Console.WriteLine("Select one deck:");
            for (int i = 0; i < decks.Count; i++)
            {
                Console.WriteLine($"{(i)} Deck {i + 1}");
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
    }
}
