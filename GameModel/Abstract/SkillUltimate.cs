using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModel.Interfaces;
namespace GameModel.Skills
{
    abstract class SkillUltimate : ISkill
    {
        public int ManaCost { get; set; }
        abstract public void ActionSkill();

    }
}
