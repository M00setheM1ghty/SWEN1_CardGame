using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCardGame.Models
{
    public class Stack
    {
        public List<Card> stack { get; set; } = new List<Card>();

        public Stack() { }
        public void addCard(Card card)
        {
            stack.Add(card);
        }

        public void showCards() 
        {
            foreach (Card card in stack)
            {
                Console.WriteLine($"{card.name} (damage: {card.damage})");
            }
        }
    }
}
