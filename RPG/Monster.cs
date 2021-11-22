﻿using System;
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

        public string TypeText
        {
            get
            {
                if (MonsterType == MonsterType.Dragon) return "Дракон";
                if (MonsterType == MonsterType.Vampire) return "Вампир";
                if (MonsterType == MonsterType.Snake) return "Змей";
                if (MonsterType == MonsterType.Zombie) return "Зомби";
                if (MonsterType == MonsterType.Spider) return "Паук";
                if (MonsterType == MonsterType.Mutant) return "Мутант";
                else throw new Exception("Вы не выбрали тип монстра");
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

        public int GetAttack(int bonus)
        {
            Random rnd = new Random();
            bonus = rnd.Next(10, 90);
            return bonus + 10;
        }

        public void Wounds(int damage)
        {
            Random rnd = new Random();
            damage = rnd.Next(0, 99);
            if (HP - damage < 0)
                HP = 0;
            int res_damage = HP - damage;
        }

        public void Heals()
        {
            HP = MaxHP;
        }

        public override int Hurt()
        {
            return (HP - 20);
            if (HP < 0) return 0;
        }

        void ICombatan.Hurt()
        {

        }

        public void Attack()
        {

        }
    }
}
 