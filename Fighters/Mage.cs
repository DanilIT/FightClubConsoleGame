using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubConsoleGame.Fighters
{
    /// <summary>
    /// Маг
    /// </summary>
    class Mage : FighterBase
    {
        public Mage(string name = "имя должен выбрать игрок") : base(name, 
            "Могущественный маг", "Концентрация - Ничто" +
            " не способно вывести мага из равновесия." +
            " \nМаг на секунду концентрируется и пускает" +
            " в противника огненный шар на 1-60 урона", 2, 3, 5)
        {

        }

        public override int UseUltimateAbility()
        {
            int totalDamage = random.Next(1, 61);
            Console.WriteLine("{0} на секунду концентрируется и пускает" +
                " в протиника огненый шар на {1} урона", Name, totalDamage);
            return totalDamage;
        }
    }
}
