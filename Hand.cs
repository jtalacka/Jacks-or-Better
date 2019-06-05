using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    class Hand
    {
        public List<Card> cards;
        private int numberOfCards = 5;
        public Hand()
        {
            cards = new List<Card>();
        }
        public void populateHand(Deck deck)//populates the hand
        {
            clear();
            for(int i = 0; i < numberOfCards; i++)
            {
                cards.Add(deck.getCard());//gets the card from the deck
                
            }
        }

        public void flip(int index)//Selects or unselects a card
        {
            if (cards.ElementAt(index).selected == false)
            {
                cards[index].selected = true;
            }
            else {
                cards[index].selected = false;
            }
        }
        public void changeCard(Deck deck,int index){
            this.cards[index] = deck.getCard();// Changes a card in hand from the deck
        }

        public void clear() {
            cards.Clear();// clears the list
        }
        public void display() {
            for (int i = 0; i < cards.Count; i++) {
                Console.Out.WriteLine("The {0} {1}",i+1,cards.ElementAt(i).generateName());//display a card
        } }

        public ICombination calculateCombination()// Checks which combination fits
        {
            List<ICombination> combinations = new List<ICombination>();
            combinations.Add(new RoyalFlush());
            combinations.Add(new StraightFlush());
            combinations.Add(new FourOfAKind());
            combinations.Add(new FullHouse());
            combinations.Add(new Flush ());
            combinations.Add(new Straight());
            combinations.Add(new ThreeOfAKind());
            combinations.Add(new TwoPair());
            combinations.Add(new JacksOrBetter());
            combinations.Add(new AllOther());

            ICombination combination = null;
            foreach(ICombination comb in combinations)
            {
                if (combination == null && comb.Combination(this) != null)
                {
                    combination = comb.Combination(this);//if it's the first valid combination you put it in
                }else if(combination!=null && comb.Combination(this) != null)
                {
                    if (combination.prize < comb.Combination(this).prize)// if current combination has bigger prize than previous one, you take the new one
                    {
                        combination = comb.Combination(this);
                    }
                }
            }
            return combination;
        }

    }
}
