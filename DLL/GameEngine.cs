using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static DLL.Card;

namespace DLL
{
    [Serializable]
    public class GameEngine
    {
        
       public sbyte roundnumber =1;
       const byte numberOfCards = 52;
       public List<Player> AllPlayers = new List<Player>();
       public Queue<Player> ActivePlayers = new Queue<Player>();
       public Card[] cards;
       public Stack<Card> draw_pile = new Stack<Card>();
       public Stack<Card> CardPlayer1 = new Stack<Card>();
       public Stack<Card> CardPlayer2 = new Stack<Card>();

        public GameEngine(bool Joker)
        {
            
            Card.CardSuit cardSuit = Card.CardSuit.hearts;
            byte cardIndex = 0;
            int NumberOfCards = 52;

            //check if there's a joker add 2cards
            if (Joker)
            {
                NumberOfCards += 2;
            }

            cards = new Card[NumberOfCards];
            
            //create for type of cards
            for (int i = 1; i <= 4; i++)
            {
                //create 13 cards of one type
                for (byte j = 1; j <= 13; j++)
                {
                    cards[cardIndex] = new Card(j, cardSuit);
                    cardIndex++;

                }
                cardSuit++;
                
            }

            //add joker joker cards if there's joker
            if (Joker)
            {
                
                cards[52] = new Card(14, Card.CardSuit.joker);
                cards[53] = new Card(14, Card.CardSuit.joker);
            }
            
        }

        public void Shuffle()
        {
            //Clear the draw_pile if it has been used before
            draw_pile.Clear();

            //creating an array to shuffle the cards
            Card[] shuffledCard = new Card[cards.Length];

            //copying cards into shuflledCard
            for (int i = 0; i < cards.Length; i++)
            {
                shuffledCard[i] = cards[i];
            }

            //shuffling the cards
            for (int i = cards.Length - 1; i > 0; i--)
            {                
                int j = RandomNumberGenerator.RNG.Next(i + 1);
                Card temp = shuffledCard[i];
                shuffledCard[i] = cards[j];
                cards[j] = temp;
            }

            //put the shuffled cards into the stack draw_pile
            foreach (Card card in shuffledCard)
            {
                draw_pile.Push(card);
                string s = string.Format("{0} {1}", card.CardValue, card.suit);
                Debug.WriteLine(s);
            }
      
            CardPlayer1.Clear();
            CardPlayer2.Clear();
        }
        
        public void rank()
        {
            //this loop calculate points of players
            foreach (Player player in AllPlayers)
            {
                player.TotalPoints = player.wins + (player.draws * 0.5);
            }

         //   AllPlayers = AllPlayers.OrderByDescending(player => player.TotalPoints).ThenByDescending(player => player.wins).ToList();
            
            //this loop sort players by their points then losses
            for (int i = 0; i < AllPlayers.Count; i++)
            {
                for (int j = i + 1; j < AllPlayers.Count; j++)
                {
                    //this one sort player by their points
                    if (AllPlayers[j].TotalPoints > AllPlayers[i].TotalPoints)
                    {
                        Player temp = AllPlayers[i];
                        AllPlayers[i] = AllPlayers[j];
                        AllPlayers[j] = temp;

                        // if players have same points then it sort it by their losses
                        if (AllPlayers[j].TotalPoints == AllPlayers[i].TotalPoints)
                        {
                            if (AllPlayers[j].losses > AllPlayers[i].losses )
                            {
                                 temp = AllPlayers[i];
                                AllPlayers[i] = AllPlayers[j];
                                AllPlayers[j] = temp;
                            }
                        }

                    }
                }
            }
            for (int i = 0; i < AllPlayers.Count; i++)
            {
                for (int j = i + 1; j < AllPlayers.Count; j++)
                {
                        // if players have same points then it sort it by their losses
                        if (AllPlayers[j].TotalPoints == AllPlayers[i].TotalPoints)
                        {
                            if (AllPlayers[j].losses < AllPlayers[i].losses)
                            {
                                Player temp = AllPlayers[i];
                                AllPlayers[i] = AllPlayers[j];
                                AllPlayers[j] = temp;
                            }
                        }
    
                }
            }


        }

     
        public void Serialize()
        {
            using (FileStream Stream = File.OpenWrite("FavoritePlayers.bin"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(Stream, AllPlayers);
             
            }           
        }

        public void Deserialize()
        {
            AllPlayers = null;
            using (FileStream Stream = File.OpenRead("FavoritePlayers.bin"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                AllPlayers = (List<Player>)formatter.Deserialize(Stream);

                foreach (Player Player in AllPlayers)
                {
                    ActivePlayers.Enqueue(Player);
                }
            }
        }
    }

}
