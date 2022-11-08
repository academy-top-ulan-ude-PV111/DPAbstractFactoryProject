using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAbstractFactoryProject
{
    abstract class Factory
    {
        public abstract Unit InfantryCreate();
        public abstract Unit ArcherCreate();
        public abstract Unit CavaleryCreate();
    }

    class RomeArmyFactory : Factory
    {
        public override Unit ArcherCreate()
        {
            return new InfantryRoman();
        }

        public override Unit CavaleryCreate()
        {
            return new ArcherRoman();
        }

        public override Unit InfantryCreate()
        {
            return new CavaleryRoman();
        }
    }

    class CarthArmyFactory : Factory
    {
        public override Unit ArcherCreate()
        {
            return new InfantryCarth();
        }

        public override Unit CavaleryCreate()
        {
            return new ArcherCarth();
        }

        public override Unit InfantryCreate()
        {
            return new CavaleryCarth();
        }
    }
}
