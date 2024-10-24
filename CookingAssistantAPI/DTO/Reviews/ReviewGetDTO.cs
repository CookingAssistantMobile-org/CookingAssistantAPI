﻿namespace CookingAssistantAPI.DTO.Reviews
{
    public class ReviewGetDTO
    {
        public int Value { get; set; }
        public string? Description { get; set; }
        public string? ReviewAuthor { get; set; }
        public byte[]? ReviewAuthorProfilePicture { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}