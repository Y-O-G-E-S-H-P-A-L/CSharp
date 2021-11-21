using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Code
{
    class Player
    {
        public string name = "Ryze";
        private int health = 49;

        public void setHealth(int h)
        {
            health = h;
        }
        public int getHealth()
        {
            return health;
        }
    }
}
