using MonsterCardGame.Models;

namespace MonsterCardGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User("name", "pswd");
            Card card1 = new Card("monster", 50, elementType.Fire, cardType.Monster);
            Stack stack1 = new Stack();
            stack1.addCard(card1);

            Console.WriteLine($"{user.name},{user.password}");
            Console.WriteLine($"{card1.name},{card1.damage}, {card1.cardElement} , {card1.cardStyle}");
            stack1.showCards();
        }
    }
}
