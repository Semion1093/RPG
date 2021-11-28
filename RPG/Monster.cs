using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    enum MonsterType { Dragon, Vampire, Snake, Zombie, Spider, Mutant };
    class Monster : Creature, ICombatan
    {
        private int _minAttack;
        public int MinAttack
        {
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _minAttack = value;
                }
                else
                {
                    throw new Exception("Некорректная минимальная сила атаки!");
                }
            }
            get
            {
                return _minAttack;
            }
        }
        private int _maxAttack;
        public int MaxAttack
        {
            set
            {
                if (value >= 20 && value <= 100)
                {
                    _maxAttack = value;
                }
                else
                {
                    throw new Exception("Некорректная максимальная сила атаки!");
                }
            }
            get
            {
                return _maxAttack;
            }
        }
        public string WarCry { get; set; }
        public string DieCry { get; set; }

        public MonsterType MonsterType { get; set; }

        public string GetTypeText(MonsterType monsterType)
        {
            switch (monsterType)
            {
                case MonsterType.Dragon: return "Дракон"; break;
                case MonsterType.Vampire: return "Вампир"; break;
                case MonsterType.Snake: return "Змей"; break;
                case MonsterType.Zombie: return "Зомби"; break;
                case MonsterType.Spider: return "Паук"; break;
                case MonsterType.Mutant: return "Мутант"; break;
                default: return "Вы не выбрали тип монстра";
            }
        }

        public string GetInfo() =>
            $"МОНСТР\n" +
            $"Имя: {Name}\n" +
            $"Здоровье на данный момент: {HP}\n" +
            $"Максимальное здоровье: {MaxHP}\n" +
            $"Милимальная сила атаки: {MinAttack}\n" +
            $"Максимальная сила атаки: {MaxAttack}\n" +
            $"Боевой клич: {WarCry}\n" +
            $"Боевой клич: {DieCry}\n" +
            $"Боевой клич: {MonsterType}\n" +
            $"Боевой клич: {IsDie}\n";

        public Monster() { }
        public Monster(string name, int hp, int maxhp, int minAttack, int maxAttack, string warcry, string diecry, MonsterType monsterType, bool isdie)
        {
            Name = name;
            HP = hp;
            MaxHP = maxhp;
            MinAttack = minAttack;
            MaxAttack = maxAttack;
            WarCry = warcry;
            DieCry = diecry;
            MonsterType = monsterType;
            IsDie = isdie;
        }

        public int Attack(int bonus)
        {
            Random rnd = new Random();
            bonus = rnd.Next(10, 90);
            return bonus + 10;
        }

        public override void Wounds(int damage)
        {
            Random rnd = new Random();
            damage = rnd.Next(30, 99);
            if (HP - damage < 0)
                HP = 0;
            int res_damage = HP - damage;
        }

        public void Heals()
        {
            HP = MaxHP;
        }
    }
}
 