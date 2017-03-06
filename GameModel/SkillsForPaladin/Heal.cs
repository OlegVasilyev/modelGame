using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModel.Skills;
namespace GameModel.SkillsForPaladin
{
    class Heal : SkillNormal
    {
        public int PowerHeal { get; set; }
        public int LevelHealAtMoment { get; set; }
        public override void ChoosePointLevel()
        {
            if (LevelHealAtMoment < MaxLevel)
                PowerHeal *= 2;
        }
        public override void ActionSkill()
        {
            Console.WriteLine("+{0}", PowerHeal);
        }
    }
}
