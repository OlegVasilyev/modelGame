using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModel.Skills;
using GameModel.Interfaces;
namespace GameModel.Heros
{
    class LigthMage : HeroType.Mage
    {
        public int LightPower { get; set; }
        public LigthMage() { }
        public LigthMage(string name, int str, int agi, int inte, ISkill skil1, ISkill skil2, ISkill ult, int LigthPower) : base(name, str, agi, inte, skil1, skil2, ult)
        {
            this.LightPower = LigthPower;
        }
        public override void LevelUp()
        {
            Strength += 3;
            Agility += 2;
            Intelligence += 15;
            Level++;
        }
        public override string Voice()
        {
            return "Тсс, не мешай мне думать.";
        }
    }
}
