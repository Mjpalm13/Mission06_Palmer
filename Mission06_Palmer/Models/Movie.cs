using System.ComponentModel.DataAnnotations;

namespace Mission06_Palmer.Models
{
    // Movie class represents the properties of a movie in the database
    public class Movie
    {
        // Primary key for the Movie table
        [Key] 
        public int MovieId { get; set; }

        // Title of the movie, required field with a custom error message if left blank
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        // Category of the movie, required field with a custom error message if left blank
        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        // Director of the movie, required field with a custom error message if left blank
        [Required(ErrorMessage = "Director is required.")]
        public string Director { get; set; }

        // Release year of the movie, required field with a range validation between 1888 and 2100
        [Required(ErrorMessage = "Year is required.")]
        [Range(1888, 2100, ErrorMessage = "Year must be between 1888 and 2100.")]
        public int Year { get; set; }

        // Rating of the movie, required field with a custom error message if left blank
        [Required(ErrorMessage = "Rating is required.")]
        public string Rating { get; set; }

        // Edited status, nullable field, indicating if the movie is edited
        public bool? Edited { get; set; } // Nullable field to allow 'null' values for movies with unknown edit status

        // LentTo field to store information about who the movie was lent to, nullable field
        public string? LentTo { get; set; } // Nullable field to allow no value if the movie hasn't been lent

        // Notes for additional comments or information about the movie, nullable field with a max length of 25 characters
        [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
        public string? Notes { get; set; } // Nullable field for optional notes with a character limit of 25
    }
}
