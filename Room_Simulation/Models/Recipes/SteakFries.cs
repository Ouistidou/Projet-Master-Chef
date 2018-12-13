﻿using Room_Simulation.Models.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen_Simulation.Models.Tools;

namespace Room_Simulation.Models.Recipes
{
    class SteakFries : Recipe
    {
        public override RecipeTypes RecipeTypes => RecipeTypes.Main;
        protected override void CreateTools()
        {
            this.Tools.Add(new Louche());
        }
        protected override void CreateIngredients()
        {
            this.AddIngredients(new Steak(), 1);
            this.AddIngredients(new Potato(), 1);
        }
    }
}