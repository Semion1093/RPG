using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    interface ICombatan
    {
        void Wounds(int damage);

        int Attack(int bonus);

        public int MinAttack { get; set; }

        public int MaxAttack { get; set; }
    }
}
