using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class Card
    {
        //initialising the properties for the card
        public byte CardValue { get; private set; } = 0;
        public CardSuit suit { get; private set; }
        public enum CardSuit
        {
            hearts,
            diamonds,
            clubs,
            spades,
            joker,
        }
        
        public Card(byte myCardValue = 0, CardSuit mysuit = default)
        {
            //setting the Card constructor
            this.CardValue = myCardValue;
            this.suit = mysuit;
        }

        public string DisplayValue()
        {
            //this code take the value generated for the Card and return the value of the Card Game
            switch (CardValue)
            {
                case 1:
                    return "ace";

                case 2:
                    return "2";

                case 3:
                    return "3";

                case 4:
                    return "4";

                case 5:
                    return "5";

                case 6:
                    return "6";

                case 7:
                    return "7";

                case 8:
                    return "8";

                case 9:
                    return "9";

                case 10:
                    return "10";

                case 11:
                    return "jack";

                case 12:
                    return "queen";

                case 13:
                    return "king";

                case 14:
                    return "joker";

                default:
                    return "Invalide Card Value";

            }

        }

    }
}
