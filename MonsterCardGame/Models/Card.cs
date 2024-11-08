using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCardGame.Models
{
    public enum elementType
    {
        Fire,
        Water,
        Earth
    }

    public enum cardType
    {
        Monster,
        Spell
    }

    public class Card
    {
        public string name { get; set; }
        public int damage { get; }
        public elementType cardElement { get; set; }
        public cardType cardStyle { get; set; }

        public Card(string name, int damage, elementType element, cardType cardStyle)
        {
            this.name = name;
            this.damage = damage;
            this.cardElement = element;
            this.cardStyle = cardStyle;
        }
    }
}
