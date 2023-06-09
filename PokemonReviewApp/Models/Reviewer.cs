﻿namespace PokemonReviewApp.Models
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Relação 1 Reviewer pode ter tem N Reviews
        public ICollection<Review> Reviews { get; set; }
    }
}
