using System;
using System.Collections.Generic;

namespace AnimalsPractice
{
    public class FlyContainer
    {
        public List<IFly> flyingAnimals { get; set; } = new List<IFly>();
    }
}