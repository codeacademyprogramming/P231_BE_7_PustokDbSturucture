﻿namespace P231Yummy.Models
{
    public class MealIngredient
    {
        public int MealId { get; set; }
        public int IngredientId { get; set; }

        public Meal Meal { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
