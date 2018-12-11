﻿using Kitchen_Simulation.Models;
using Kitchen_Simulation.Models.Ingredients;
using Kitchen_Simulation.Models.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Models.Recipes
{
    class IceCreamBalls : Recipe
    {
        public override RecipeTypes RecipeTypes => RecipeTypes.Starter;

        protected override void CreateIngredients()
        {
            this.AddIngredients(new IceCream(), 3);
        }
    }
}
