using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var parakeet1 = new Parakeets();
            var earthworm1 = new Earthworms();
            var terrapin1 = new Terrapins();
            var timber1 = new TimberRattlesnake();
            var mice = new Mice();
            var ant1 = new Ants();
            var finch1 = new Finches();
            var bettaFish1 = new BettaFish();
            var copperhead1 = new CopperheadSnake();
            var gerbil1 = new Gerbils();

            DigContainer digContainer = new DigContainer();
            digContainer.diggingAnimals.Add(earthworm1);

            SwimContainer swimContainer = new SwimContainer();
            swimContainer.swimmingAnimals.Add(terrapin1);
            swimContainer.swimmingAnimals.Add(bettaFish1);

            FlyContainer flyContainer = new FlyContainer();
            flyContainer.flyingAnimals.Add(parakeet1);
            flyContainer.flyingAnimals.Add(finch1);

            WalkContainer walkContainer = new WalkContainer();
            walkContainer.walkingAnimals.Add(timber1);
            walkContainer.walkingAnimals.Add(ant1);
            walkContainer.walkingAnimals.Add(mice);
            walkContainer.walkingAnimals.Add(gerbil1);
            walkContainer.walkingAnimals.Add(copperhead1);



        }
    }
}