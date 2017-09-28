using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer
{
    public class Player
    {        
        private string _name;
        private string _slayerClass;
        private int _hitPoints;
        private int _mana;
        private int _attack;
        private int _magic;
        private int _heal;

        public Player(string name, string slayerClass)
        {
            _name = name;
            _slayerClass = slayerClass;
            switch (slayerClass)
            {
                case "Mage":
                    _hitPoints = 100;
                    _mana = 150;
                    _attack = 5;
                    _magic = 15;
                    _heal = 10;
                    break;
                case "Paladin":
                    _hitPoints = 125;
                    _mana = 125;
                    _attack = 10;
                    _magic = 10;
                    _heal = 15;
                    break;
                case "Warrior":
                    _hitPoints = 150;
                    _mana = 100;
                    _attack = 15;
                    _magic = 5;
                    _heal = 5;
                    break;
            }
        }

        public void ResetHPAndMana(string slayerClass)
        {
            switch (slayerClass)
            {
                case "Mage":
                    _hitPoints = 100;
                    _mana = 150;
                    break;
                case "Paladin":
                    _hitPoints = 125;
                    _mana = 125;
                    break;
                case "Warrior":
                    _hitPoints = 150;
                    _mana = 100;
                    break;
            }
        }

        public int Mana
        {
            get
            {
                return _mana;
            }
        }

        public int Attack
        {
            get
            {
                return _attack;
            }
        }

        public int Magic
        {
            get
            {
                return _magic;
            }
        }

        public int HitPoints
        {
            get
            {
                return _hitPoints;
            }
        }

        public string SlayerClass
        {
            get
            {
                return _slayerClass;
            }
        }

        public void TakeDmg(int dmg)
        {
            _hitPoints = _hitPoints - dmg;
        }

        public int MagicAttack()
        {
            _mana = _mana - 5;
            return _magic;
        }

        public void Heal()
        {
            _mana = _mana - 5;
            _hitPoints = _hitPoints + _heal;
        }        
    }
}
