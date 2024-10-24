﻿using CookingAssistantAPI.Database.Models;
using CookingAssistantAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Newtonsoft.Json;
using CookingAssistantAPI.Services;
using CookingAssistantAPI.DTO.Recipes;


namespace CookingAssistantAPI.Controllers
{
    [ApiController]
    [Route("api/recipes")]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _service;
        public RecipeController(IRecipeService service)
        {
            _service = service;
        }

        [HttpPost]
        //[Consumes("multipart/form-data")]
        public async Task<ActionResult> CreateRecipe([FromForm] RecipeCreateDTO recipeDto)
        {
            if (await _service.AddRecipe(recipeDto))
            {
                return Created();
            }
            return BadRequest();
        }

        [HttpGet("{*recipeId}")]
        public async Task<ActionResult<RecipeGetDTO>> GetRecipeById([FromRoute] int recipeId)
        {
            var recipe = await _service.GetRecipeByIdAsync(recipeId);
            return Ok(recipe);
        }

        [HttpGet("nutrientsList")]
        public async Task<ActionResult<List<string>>> GetNutrientsList()
        {
            var nutrients = await _service.GetAllNutrientsAsync();
            return Ok(nutrients);
        }
        [HttpGet("ingredientsList")]
        public async Task<ActionResult<List<string>>> GetIngredientsList()
        {
            var ingredients = await _service.GetAllIngredientsAsync();
            return Ok(ingredients);
        }
    }
}
