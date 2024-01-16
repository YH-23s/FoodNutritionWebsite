﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNutritionWebsite.Shared.Domain
{
    internal class FoodLog : BaseDomainModel
    {
        public DateTime FoodLogDateTime { get; set; }
        public string? FoodType { get; set; }
        public string? FoodName { get; set;}
        public int UserID { get; set;}
        public virtual User? User { get; set; }
    }
}
