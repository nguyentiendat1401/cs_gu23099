﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    public abstract class Animal
    {
        public abstract string MakeSound();
    }

    public class Tiger : Animal
    {
        public override string MakeSound()
        {
            return "Tiger: roarrrrr!";
        }
    }

    public class Chicken : Animal
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }
    }
    //------------------------------------------
    public interface Edible
    {
        public string HowToEat();
    }

    public class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }

        public string HowToEat()
        {
            return "could be fried";
        }
    }

    //------------------------------------

}
