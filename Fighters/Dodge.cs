using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubConsoleGame.Fighters
{
    /// <summary>
    /// Ловкач
    /// </summary>
    class Dodge : FighterBase
    {
        public Dodge(string name = "имя должен выбрать игрок") : base(name, 
            "Изворотливый ловкач", "Ловкость рук - Есть 25% " +
            "шанс запутать противника и незаметно ударить " +
            "второй рукой. \nТакой удар считается " +
            "критическим попаданием (x3)", 3, 4, 3)
        {

        }

        public override int UseUltimateAbility()
        {
            int chance = random.Next(1, 101);
            if (chance <= 25)
            {
                int totalDamage = Damage * 3;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} изловчился и ударил второй рукой! " +
                    "Этот удар оказался критическим и " +
                    "нанес {1} урона!", Name, totalDamage);
                Console.ResetColor();
                return totalDamage;
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} попытался незаметно ударить второй " +
                "рукой, но противник это заметил и увернулся!", Name);
            Console.ResetColor();
            return 0;
        }
    }
}
