﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Models.Ingredients
{
    public class Apple : Ingredient
    {
        public override IngredientTypes IngredientTypes => IngredientTypes.Fresh;
    }
}
