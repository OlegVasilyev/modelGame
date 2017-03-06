using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModel.Skills;
using GameModel.Interfaces;
namespace GameModel.Abstract
{
    abstract class Hero

    {
        public Hero() { }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int HealthPointAtMoment { get; set; }
        public int HealthPointMax { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public ISkill SkillOne { get; set; }
        public ISkill SkillTwo { get; set; }
        public ISkill SkillUltimate { get; set; }
        abstract public void LevelUp();
        public virtual void CastSkillOne()
        {
            Mana -= SkillOne.ManaCost;
            SkillOne.ActionSkill();
        }
        public virtual void CastSkillTwo()
        {
            Mana -= SkillTwo.ManaCost;
            SkillTwo.ActionSkill();
        }
        public virtual void CastSkillUltimate()
        {
            Mana -= SkillUltimate.ManaCost;
            SkillUltimate.ActionSkill();
        }
        public virtual string Information()
        {
            return String.Format("Харатеристики : Сила -> {0}, Ловкость -> {1}, Интелект -> {2}, Урон -> {3}, Защита -> {4}, Количество хитпоинтов -> {5}, Енергии -> {6}."
                , Strength, Agility, Intelligence, Damage, Armor, HealthPointMax, Mana);
        }
        public virtual string Voice() => "Voice";
    }
}
