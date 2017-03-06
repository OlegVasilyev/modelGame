using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModel.Interfaces;
using GameModel.Skills;
namespace GameModel.HeroType
{
    abstract class Tank : Abstract.Hero
    {
        public Tank() { }
        public Tank(string name, int str, int agi, int inte, ISkill skil1, ISkill skil2, ISkill ult)
        {
            this.Level = 1;
            this.Name = name;
            this.Strength = str;
            this.Agility = agi;
            this.Intelligence = inte;
            this.HealthPointMax = this.HealthPointAtMoment = str * 10;
            this.Armor = agi * 2 + str * 1 + inte / 2;
            this.SkillOne = skil1;
            this.SkillTwo = skil2;
            this.Mana = inte * 10;
            this.SkillUltimate = ult;
            this.Damage = str * 2;
        }
        public virtual void BlockDamage()
        {
           Armor += 1;
        }
    }
}
