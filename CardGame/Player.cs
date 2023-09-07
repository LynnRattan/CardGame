using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Player
    {
        private string name;
        private Card[] hand;


        public Player(string name)
        {
            this.name = name;
            hand = new Card[5];
            
            
        }

        public void SetName(string name)
        {
          this.name = name;
        }

        public void SetHand(Card[] hand)
        {
            this.hand = hand;
        }

        public Card[] GetHand()
        {
            return this.hand;
        }

        public string GetName() 
        { 
            return this.name;
        }

        public void Take(Card card)
        {
            for(int i=0; i<hand.Length; i++)
            {
                if (hand[i] == null)
                {
                    hand[i] = card;
                }
            }

          
        }
        public void HandSwap(int i, int j)
        {
            Card c = hand[j];
            hand[j] = hand[i];
            hand[i] = c;
        }
        public Card Put(int i)
        {
            return hand[i];
            Random random = new Random();
            int randomPlace=random.Next(1,6);
            HandSwap(i,randomPlace);
            
        }
    }
}
