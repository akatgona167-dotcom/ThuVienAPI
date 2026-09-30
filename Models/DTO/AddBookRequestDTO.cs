using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.DTO
{
    public class AddBookRequestDTO
    {
        [Required(ErrorMessage = "Title is required")]
        [MinLength(10, ErrorMessage = "Title must be at least 10 characters")]
        public string Title { get; set; }

        public string? Description { get; set; }

        public bool IsRead { get; set; }

        public DateTime? DateRead { get; set; }

        [Range(0, 5, ErrorMessage = "Rate must be from 0 to 5")]
        public int? Rate { get; set; }

        public string? Genre { get; set; }

        public string? CoverUrl { get; set; }

        public DateTime DateAdded { get; set; }

        public int PublisherID { get; set; }

        public List<int>? AuthorIds { get; set; }
    }
}