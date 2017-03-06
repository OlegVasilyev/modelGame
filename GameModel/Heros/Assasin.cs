using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModel.Skills;
using GameModel.Interfaces;
namespace GameModel.Heros
{
    class Assasin : HeroType.Carry
    {
        public int Evation { get; set; }
        public Assasin() { }
        public Assasin(string name, int str, int agi, int inte, ISkill skil1, ISkill skil2, ISkill ult, int evation) : base(name, str, agi, inte, skil1, skil2, ult)
        {
            this.Evation = evation;
        }
        public override void LevelUp()
        {
            Strength += 5;
            Agility += 10;
            Intelligence += 3;
            Level++;
        }
        public new void Atack()
        {
            //Rage
            Damage += 100;
        }
        public override string Voice()
        {
            return "Бойтесь ночи!";
        }
    }
}
