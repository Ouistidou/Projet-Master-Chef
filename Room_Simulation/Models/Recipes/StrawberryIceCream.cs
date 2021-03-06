﻿using Room_Simulation.Models.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen_Simulation.Models.Tools;

namespace Room_Simulation.Models.Recipes
{
    class StrawberryIceCream : Recipe
    {
        public override RecipeTypes RecipeTypes => RecipeTypes.Dessert;
        protected override void CreateTools()
        {
            this.Tools.Add(new Louche());
        }
        protected override void CreateIngredients()
        {
            this.AddIngredients(new Strawberry(), 5);
            this.AddIngredients(new IceCream(), 1);
        }
    }
}
