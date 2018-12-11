﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen_Simulation.Models.Tools;

namespace Kitchen_Simulation.Models
{
    public class Cleaner
    {
        private KitchenModel Model { get; set; } = null;

        public Cleaner(KitchenModel model)
        {
            this.Model = model;
        }
        
        public void GetDirtyTools()
        {
            this.Model.GetController().Animation("Go to cook");
            this.Model.GetController().Animation("Move to sink");
        }

        public void LaunchDishMachine(List<Tool> tools)
        {
            this.Model.GetController().Animation("Go to Dish washer");
            this.Model.DishWasher.Wash(tools);
        }

        public void LaunchWashingMachine()
        {
            this.Model.GetController().Animation("Go to Washing machine");
        }
    }
}
