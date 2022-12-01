using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO
{
    abstract class NPC : Personagem
    {
        public override void Atacar()
        {
            throw new NotImplementedException();
        }
        public override void Movimentar()
        {
            throw new NotImplementedException();
        }
    }
}
