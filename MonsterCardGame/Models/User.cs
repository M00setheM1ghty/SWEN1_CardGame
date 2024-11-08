using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCardGame.Models
{
    public class User
    {
        public string name { get; set; }
        public string password { get; set; }
        public int coins = 20;
        public Stack<Card>currentCards { get; set; }

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
