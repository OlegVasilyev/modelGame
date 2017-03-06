using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel.Interfaces
{
    interface ISkill
    {
        int ManaCost { get; set; }
        void ActionSkill();

    }
}
