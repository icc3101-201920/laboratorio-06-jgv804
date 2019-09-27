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
            
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].GetType().Name == nameof(CombatCard))
                {
                    Console.ForegroundColor = red;
                    Console.write( $"|({hand.Cards[i].Id}) " + hand.Cards[i].Name + $" {hand.Cards[i].type} :{hand.Cards[i].attackpoints} |");
                }
                else
                {
                    Console.ForegroundColor = blue;
                    Console.write( $"|({hand.Cards[i].Id}) " + hand.Cards[i].Name + $" {hand.Cards[i].type} |");
                }
            }
            
        }
        public static void ShowDecks(List<Deck> decks)
        {

        }
    }
}
