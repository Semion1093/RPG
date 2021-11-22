using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    interface ICombatan
    {
        void Hurt();

        void Attack();

        public int MinAttack { get; set; }

        public int MaxAttack { get; set; }
    }
    
}
