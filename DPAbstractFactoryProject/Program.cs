using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPAbstractFactoryProject
{
    internal class Program
    {
        static List<Unit> ArmyCreate(Factory factory, int count)
        {
            List<Unit> army = new List<Unit>();
            for (int i = 0; i < count / 3; i++)
                army.Add(factory.InfantryCreate());
            for (int i = 0; i < count / 3; i++)
                army.Add(factory.ArcherCreate());
            for (int i = 0; i < count / 3; i++)
                army.Add(factory.CavaleryCreate());

            return army;
        }
        static void Main(string[] args)
        {
            List<Unit> armyRoman = ArmyCreate(new RomeArmyFactory(), 12);
            List<Unit> armyCarth = ArmyCreate(new CarthArmyFactory(), 12);

            foreach(Unit unit in armyRoman)
                Console.WriteLine(unit.Info());

            Console.WriteLine();

            foreach (Unit unit in armyCarth)
                Console.WriteLine(unit.Info());
        }
    }
}
