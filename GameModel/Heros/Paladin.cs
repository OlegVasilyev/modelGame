using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModel.Interfaces;
using GameModel.Skills;
namespace GameModel.Heros
{
    class Paladin : HeroType.Tank
    {
        public int StunSec { get; set; }
        public Paladin() { }
        public Paladin(string name, int str, int agi, int inte, ISkill skil1, ISkill skil2, ISkill ult, int stunsec) : base(name, str, agi, inte, skil1, skil2, ult)
        {
            this.StunSec = stunsec;
        }
        public override void LevelUp()
        {
            Strength += 10;
            Agility += 2;
            Intelligence += 7;
            Level++;
        }
        public new void BlockDamage()
        {
            //PowerLight
            Strength += 50;
            HealthPointMax += 500;
        }
        public override string Voice()
        {
            return "Мой молот укрепит вашу веру!";
        }
    }
}
