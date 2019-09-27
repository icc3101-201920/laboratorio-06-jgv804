using Laboratorio_5_OOP_201902.Cards;
using Laboratorio_5_OOP_201902.Enums;
using System;
using System.Collections.Generic;

namespace Laboratorio_5_OOP_201902
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.AddDecks();
            game.AddCaptains();
            int turn = 0;
            
            bool endGame = false;
            Player[] playerL = new Player[2];
            Player player = new Player();
            Player player2 = new Player();
            Board board = new Board();
            player.Board = board;
            player.Deck = game.Decks[0];
            player.Deck.Shuffle();
            player.Id = 1;
            player2.Board = board;
            player2.Deck = game.Decks[1];
            player2.Id = 2;
            player2.Deck.Shuffle();
            //player.FirstHand();//
            //player2.FirstHand();//
            playerL[0] = player;
            playerL[1] = player2;
            game.Players = playerL;
            game.BoardGame = board;
            Random random = new Random();
            int rand = random.Next(0, 2);
            if (rand == 0)
            {
                game.ActivePlayer = game.Players[0];
                game.Play();
                game.ActivePlayer= game.Players[1];
                game.Play();
                turn++;
            }
            else
            {
                game.ActivePlayer = game.Players[1];
                game.Play();
                game.ActivePlayer= game.Players[0];
                game.Play();
                turn++;
            }
            
              
            
            //Console.WriteLine(game.BoardGame.PlayerCards[1].Keys);//
            
             

            

            /*player.ChooseCaptainCard(game.Captains[0]);
            Console.WriteLine($"Player captain card: {player.Captain.Name}\n");
            int counter = 1;
            Console.WriteLine("Player Hand:");
            foreach (Card card in player.Hand.Cards)
            {
                Console.WriteLine($"{counter++}: {card.Name}");
            }
            counter = 1;
            Console.WriteLine("\nPlayer Deck:");
            foreach (Card card in player.Deck.Cards)
            {
                Console.WriteLine($"{counter++}: {card.Name}");
            }
            Visualizacion.ShowCaptains(game.Captains);
            Visualizacion.ShowDecks(game.Decks);
            Visualizacion.ShowHand(player.Hand);*/
            
            
            //Test Change Card
            
            //player.ChangeCard(3);
            //counter = 1;
            //Console.WriteLine("\n New Player Hand:");
            //foreach (Card card in player.Hand.Cards)
            //{
            //    Console.WriteLine($"{counter++}: {card.Name}");
            //}
            //counter = 1;
            //Console.WriteLine("\n New Player Deck:");
            //foreach (Card card in player.Deck.Cards)
            //{
            //    Console.WriteLine($"{counter++}: {card.Name}");
            //}
            

            //Test draw card
            
            //player.DrawCard();
            //counter = 1;
            //Console.WriteLine("\n New Player Hand:");
            //foreach (Card card in player.Hand.Cards)
            //{
            //    Console.WriteLine($"{counter++}: {card.Name}");
            //}
            //counter = 1;
            //Console.WriteLine("\n New Player Deck:");
            //foreach (Card card in player.Deck.Cards)
            //{
            //    Console.WriteLine($"{counter++}: {card.Name}");
            //}
            

            //Test play card
            
            //player.PlayCard(6);
            //counter = 1;
            //Console.WriteLine("\n New Player Hand:");
            //foreach (Card card in player.Hand.Cards)
            //{
            //    Console.WriteLine($"{counter++}: {card.Name}");
            //}
            //Console.WriteLine(String.Join(", ", board.GetMeleeAttackPoints()));
            //Console.WriteLine(String.Join(", ", board.GetRangeAttackPoints()));
            //Console.WriteLine(String.Join(", ", board.GetLongRangeAttackPoints()));
            
            
        }
    }
}
