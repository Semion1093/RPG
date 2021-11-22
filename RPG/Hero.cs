using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Hero : Humanoid, ICombatan
    {
        public int MinAttack
        {
            set
            {
                if (value >= 0 && value <= 10)
                {
                    MinAttack = value;
                }
                else
                {
                    throw new Exception("Некорректная минимальная сила атаки!");
                }
            }
            get
            {
                return MinAttack;
            }
        }

        public int MaxAttack
        {
            set
            {
                if (value >= 20 && value <= 100)
                {
                    MaxAttack = value;
                }
                else
                {
                    throw new Exception("Некорректная максимальная сила атаки!");
                }
            }
            get
            {
                return MaxAttack;
            }
        }

        public void Attack()
        {

        }

        void ICombatan.Hurt()
        {

        }
    }
}
