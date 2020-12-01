using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubConsoleGame.Fighters
{
    public abstract class  FighterBase
    {
        protected Random random;
        //члены класса
        //public delegate void IsDeadDelegate();
        public event Action IsDead; //боец мертв (проиграл)

        public string Name { get; private set; }
        public string ClassDescription { get; private set; }
        public string UltimateAbilityDescription { get; private set; }

        private int strength;
        public int Strength
        {
            get { return strength; }
            set
            {
                strength = value;
                Damage = value * Constants.damageMultiplier;
            }
        }
        /// <summary>
        /// Повреждения наносимые врагу
        /// </summary>
        public int Damage { get; private set; }

        private int agility;
        public int Agility
        {
            get { return agility; }
            set
            {
                agility = value;
                DodgeChance = value * Constants.dodgeMultiplier;
            }
        }

        public int DodgeChance { get; private set; }

        private int vitality;
        public int Vitality
        {
            get { return vitality;  }
            set
            {
                vitality = value;
                HP = value * Constants.hpMultiplier;
            }
        }

        private int hp;
        public int HP
        {
            get { return hp; }
            set
            {
                hp = value;
                if (hp < 0)
                {
                    hp = 0;
                    if (IsDead != null)
                    IsDead();
                }                    
            }
        }

        protected FighterBase(string name, string classDescription, 
             string ultimateAbilityDescription, int strength, 
             int agility, int vitality)
        {
            random = new Random();
            Name = name;
            ClassDescription = classDescription;
            UltimateAbilityDescription = ultimateAbilityDescription;
            Strength = strength;
            Agility = agility;
            Vitality = vitality;
        }

        public int Hit()
        {
            int totalDamage = random.Next(Damage - Constants.damageVariety, 
                Damage + Constants.damageVariety + 1);
            Console.WriteLine("{0} ударил и нанес {1} урона!", Name, totalDamage);
            return totalDamage;
        }

        public abstract int UseUltimateAbility();

        public override string ToString()
        {
            return $"\nИмя: {Name}\nКласс: {ClassDescription}\nСила:" +
                $" {Strength}\t\tЛовкость: {Agility}\t\tЖивучесть: " +
                $"{Vitality}\nУрон: {Damage}\tШанс увернуться: " +
                $"{DodgeChance}%\tHP: {HP}\nУмение: {UltimateAbilityDescription}";
        }
    }
}
