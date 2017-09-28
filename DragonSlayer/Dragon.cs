using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer
{
    public class Dragon
    {
        private int _hitPoints;
        private int _level;
        private int _attack = 4;

        public Dragon(int lvl)
        {
            _level = lvl;
            _hitPoints = 95 + (_level * 5);
        }

        public int Attack()
        {
            int attack = _attack + _level;
            return attack;
        }

        public void TakeDmg(int dmg)
        {
            _hitPoints = _hitPoints - dmg;
        }

        public int HitPoints
        {
            get
            {
                return _hitPoints;
            }
        }
    }
}
