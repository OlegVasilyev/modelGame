using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModel.Abstract;
using GameModel.HeroType;
namespace GameModel
{
    interface IEvent<out T>
    {
        T GetHero(string Name);
    }
    class Event<T> : IEvent<T> where T : Hero
    {
        const int maxHero = 10;
        int position;
        List<T> heros;
        public Event()
        {
            heros = new List<T>();
            heros.OrderBy(h => h.Name);
        }
        public void Add(T hero)
        {
            if(heros.Count<maxHero)
            {   
                heros.Add(hero);
            }
        }
        public void Delete(T hero)
        {
               heros.Remove(hero);
        }
        public T GetHero(string Name) => heros.Where(h => h.Name == Name).First();
        public void InformationForEvent()
        {
            foreach (T h in heros)
                h.Information();
        }
    }
}
