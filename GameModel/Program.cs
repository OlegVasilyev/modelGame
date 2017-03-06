using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameModel.Heros;
using GameModel.Interfaces;
using GameModel.Skills;
using GameModel.Abstract;
namespace GameModel
{
    static class Program
    {
        static void Main()
        {
            ISkill heal = new SkillsForPaladin.Heal();
            heal.ManaCost = 75;
            ISkill invul = new SkillsForPaladin.Invul();
            invul.ManaCost = 25;
            ISkill reincanation = new SkillsForPaladin.Reincarnation();
            reincanation.ManaCost = 150;
            Hero paladin = new Heros.Paladin("Паладин",50, 20, 40, heal, invul, reincanation, 2);
            Console.WriteLine(paladin.Voice());
            Console.WriteLine(paladin.Information());
            paladin.CastSkillOne();
            Console.WriteLine(paladin.Information());
            paladin.LevelUp();
            Console.WriteLine(paladin.Information());
            Event<Hero> eventhero = new GameModel.Event<Abstract.Hero>();
            eventhero.Add(paladin);
            Console.WriteLine(eventhero.GetHero("Паладин")?.Information());
        }
    }
}
