﻿namespace CookingAssistantAPI.Database.Models
{
    public class Difficulty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Recipe>? Recipes { get; set; } = new List<Recipe>();
    }
}