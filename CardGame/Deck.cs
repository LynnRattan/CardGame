using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Deck
    {
        private Card[] cards;
        private int top;

        public Deck() 
        {
            this.top = 0;
            int index = 0;
            cards = new Card[52];
            for (int i = 1; i <= 4; i++)
            {
                for(int j=1; j<=13; j++)
                { cards[index] = new Card(j, i);
                    index++;
                }
            }
        }
        public Card Peek() { return null; }
        public void Swap(int i, int j)
        {
            Card c= cards[j];
            cards[j] = cards[i];
            cards[i] = c;
        }
        public void Shuffle() 
        {
            int j;
            for(int i=0; i<cards.Length; i++)
            {
                Random random = new Random();
                j = random.Next(i, 52);
                Swap(i, j);
                
            }
       

        }
        public Card Deal() {
            Card c = cards[top];
            top++;
            return c; 
        }

        public void Reset() { }
    }
}
