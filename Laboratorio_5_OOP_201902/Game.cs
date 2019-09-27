using Laboratorio_5_OOP_201902.Cards;
using Laboratorio_5_OOP_201902.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Laboratorio_5_OOP_201902
{
    public class Game
    {
        //Atributos
        private Player[] players;
        private Player activePlayer;
        private List<Deck> decks;
        private List<SpecialCard> captains;
        private Board boardGame;

        //Constructor
        public Game()
        {
            decks = new List<Deck>();
            captains = new List<SpecialCard>();
        }
        //Propiedades
        public Player[] Players
        {
            get
            {
                return this.players;
            }
            set
            {
                players = value;
            }
        }
        public Player ActivePlayer
        {
            get
            {
                return this.activePlayer;
            }
            set
            {
                activePlayer = value;
            }
        }
        public List<Deck> Decks
        {
            get
            {
                return this.decks;
            }
        }
        public List<SpecialCard> Captains
        {
            get
            {
                return this.captains;
            }
        }
        public Board BoardGame
        {
            get
            {
                return this.boardGame;
            }
            set
            {
                boardGame = value;
            }
        }

        //Metodos
        public bool CheckIfEndGame()
        {
            if (players[0].LifePoints == 0 || players[1].LifePoints == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetWinner()
        {
            if (players[0].LifePoints == 0 && players[1].LifePoints > 0)
            {
                return 1;
            }
            else if (players[1].LifePoints == 0 && players[0].LifePoints > 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public void Play()
        {
            List<string> changecard = new List<string>();
            changecard.Add("Change Card");
            changecard.Add("Pass");
            Visualizacion.ShowProgramMessage("Player "+ActivePlayer.Id+" please select your deck");
            Visualizacion.ShowDecks(Decks);
            int choice=Visualizacion.GetUserInput(2);
            ActivePlayer.Deck = Decks[choice];
            Visualizacion.ShowCaptains(Captains);
            int choice2 = Visualizacion.GetUserInput(2);
            ActivePlayer.ChooseCaptainCard(Captains[choice2]);
            ActivePlayer.FirstHand();
            Visualizacion.ShowHand(ActivePlayer.Hand);
            Visualizacion.ShowListOption(changecard);
            
            int choice3=Visualizacion.GetUserInput(2);
            int p = 0;
            if (choice3 == 0)
            {
                
                while (p < 3)
                {
                   Console.WriteLine("Please choose what card to change:");
                   Visualizacion.ShowHand(ActivePlayer.Hand);
                   int choice4= Visualizacion.GetUserInput(10, true);
                   if (choice4 == -1)
                   {
                        break;
                   }
                   ActivePlayer.ChangeCard(choice4);
                   p++;
                }
            }
            else
            {
                Console.WriteLine("Player "+ ActivePlayer.Id+" has passed");
            }
            Console.WriteLine("Player " + ActivePlayer.Id + " has finished his turn 0 play");
            Console.ReadKey();
            Visualizacion.ClearConsole();



        }
        public void AddDecks()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent + @"\Files\Decks.txt";
            StreamReader reader = new StreamReader(path);
            int deckCounter = 0;
            List<Card> cards = new List<Card>();


            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string [] cardDetails = line.Split(",");

                if (cardDetails[0] == "END")
                {
                    decks[deckCounter].Cards = new List<Card>(cards);
                    deckCounter += 1;
                }
                else
                {
                    if (cardDetails[0] != "START")
                    {
                        if (cardDetails[0] == nameof(CombatCard))
                        {
                            cards.Add(new CombatCard(cardDetails[1], (EnumType) Enum.Parse(typeof(EnumType),cardDetails[2]), cardDetails[3], Int32.Parse(cardDetails[4]), bool.Parse(cardDetails[5])));
                        }
                        else
                        {
                            cards.Add(new SpecialCard(cardDetails[1], (EnumType)Enum.Parse(typeof(EnumType), cardDetails[2]), cardDetails[3]));
                        }
                    }
                    else
                    {
                        decks.Add(new Deck());
                        cards = new List<Card>();
                    }
                }

            }
            
        }
        public void AddCaptains()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent + @"\Files\Captains.txt";
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] cardDetails = line.Split(",");
                captains.Add(new SpecialCard(cardDetails[1], (EnumType)Enum.Parse(typeof(EnumType), cardDetails[2]), cardDetails[3]));
            }
        }
    }
}
