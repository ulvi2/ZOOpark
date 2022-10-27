using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZOOpark.Опции;

namespace ZOOpark
{
    public  class Cerepaxa
    {
        public string Name { get; set; }
        public int Age  { get; set; }
        public BiomType Biome { get; private set; } 
        public double Weight { get; set; }
        public int[] Eat { get; set; }
        public bool isPredator { get; set; }
        private string _sound;
        public Cerepaxa(string name,int age, double weight) { 
            Name = name;
            Age = age;
            Biome = BiomType.Tropic;
            Weight = weight;
            }


    }
}
