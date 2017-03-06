using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModel.Interfaces;
namespace GameModel.Skills
{
    abstract class SkillNormal : ISkill
    {
        public int ManaCost { get; set; }
        public const int MaxLevel = 4;
        abstract public void ChoosePointLevel();
        abstract public void ActionSkill();
    }
}
