﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Models.Ingredients
{
    public class Salad : Ingredient
    {
        public override IngredientTypes IngredientTypes => IngredientTypes.Fresh;
    }
}
