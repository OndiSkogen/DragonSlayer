using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer
{
    class Player
    {
        private string _name;
        private string _slayerClass;

        public Player(string name, string slayerClass)
        {
            _name = name;
            _slayerClass = slayerClass;
        }
    }
}
