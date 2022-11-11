using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZOOpark.Опции;

namespace ZOOpark
{
    public  class Cerepaxa : AbstractAnimal
    {
        public Cerepaxa(string name, double age) : base(name, age)
        {
            Vid = "Cerepaxa";
            Biome = BiomType.Tropic;
            SquareToUnit = 100;
            NaxFood = 20;
            IsPredator = false;
            Food = new List<FoodType>()
            {
                FoodType.fish,
            };
            _sound = "myaw myaw";
        }
    }
}
