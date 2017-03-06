using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModel.Skills;
namespace GameModel.SkillsForPaladin
{
    class Invul : SkillNormal
    {
        public int InvulLasting { get; set; }
        public int LevelHealAtMoment { get; set; }
        public override void ChoosePointLevel()
        {
            if (LevelHealAtMoment < MaxLevel)
            InvulLasting += 5;
        }
        public override void ActionSkill()
        {
           Console.WriteLine("+10000 Armor");
        }
    }
}
