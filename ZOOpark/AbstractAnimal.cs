using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZOOpark.Опции;

namespace ZOOpark
{
    public abstract class AbstractAnimal
    {
        public string Name { get; set; }
        public string Vid { get; protected set; }
        public BiomType Biome { get; protected set; }
        public double EatenFood { get; protected set; }
        public double NaxFood { get; protected set; }
        public double SquareToUnit { get; set; }
        public double Age { get; set; }
        public bool IsPredator { get; protected set; }
        public List<FoodType> Food;
        protected string _sound;

        public AbstractAnimal(string name, double age)
        {
            EatenFood = 0;
            Name = name;
            Age = age;
            IsPredator = false;
        }
        public string Feed(FoodType eat, double foodWeight)
        {
            string result = "";
            if (!Food.Contains(eat))
            {
                return $"{Name} doesn't eat {eat}";
            }
            if (EatenFood + foodWeight <= NaxFood)
            {
                result = $"{Name} ate {foodWeight}kg of {eat}";
                EatenFood += foodWeight;
            }
            else
            {
                result = $"{foodWeight}kg is too much for {Name}";
                EatenFood = NaxFood;
            }
            return result;
         }
        public virtual string MakeSound()
        {
            string result = $"{Name}:{_sound}";
            return result;
        }
    }
}
