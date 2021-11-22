using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    enum RaceType { Dwarf, Orc, Elf, Sprite, Wizard, Warrior };

    class Humanoid : Creature
    {
        private int _intelligence;
        public int Intelligence
        {
            set
            {
                if (value > 0 && value <= 100)
                {
                    _intelligence = value;
                }
                else
                {
                    throw new Exception("Некорректное значение интеллекта!");
                }
            }
            get
            {
                return _intelligence;
            }
        }

        public RaceType RaceType { get; set; }
        public string TypeText
        {
            get
            {
                if (RaceType == RaceType.Dwarf) return "Гном";
                if (RaceType == RaceType.Orc) return "Орк";
                if (RaceType == RaceType.Elf) return "Эльф";
                if (RaceType == RaceType.Sprite) return "Фея";
                if (RaceType == RaceType.Wizard) return "Волшебник";
                if (RaceType == RaceType.Warrior) return "Воин";
                else throw new Exception("Вы не выбрали тип гуманоида");
            }
        }

        public override int Hurt()
        {
           return (HP - 30);
        }
    }
}
