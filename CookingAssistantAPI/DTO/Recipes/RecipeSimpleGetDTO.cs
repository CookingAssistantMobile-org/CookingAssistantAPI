﻿namespace CookingAssistantAPI.DTO.Recipes
{
    public class RecipeSimpleGetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Ratings { get; set; }
        public int TimeInMinutes { get; set; }
        public string Difficulty { get; set; }
        public int VoteCount { get; set; }
        public string CategoryName { get; set; }
    }
}
