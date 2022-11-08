using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAbstractFactoryProject
{
 
    // Base class
    abstract class Unit
    {
        public abstract string Info();
    }

    // Base classes
    class Infantry : Unit
    {
        public override string Info()
        {
            return "Infantry";
        }
    }

    class Cavalery : Unit
    {
        public override string Info()
        {
            return "Cavalery";
        }
    }

    class Archer : Unit
    {
        public override string Info()
        {
            return "Archer";
        }
    }

    // Roman Collection
    class InfantryRoman : Infantry
    {
        public override string Info()
        {
            return "Roman " + base.Info();
        }
    }

    class ArcherRoman : Archer
    {
        public override string Info()
        {
            return "Roman " + base.Info();
        }
    }

    class CavaleryRoman : Cavalery
    {
        public override string Info()
        {
            return "Roman " + base.Info();
        }
    }

    // Carth Collection
    class InfantryCarth : Infantry
    {
        public override string Info()
        {
            return "Carth " + base.Info();
        }
    }

    class ArcherCarth : Archer
    {
        public override string Info()
        {
            return "Carth " + base.Info();
        }
    }

    class CavaleryCarth : Cavalery
    {
        public override string Info()
        {
            return "Carth " + base.Info();
        }
    }

}
