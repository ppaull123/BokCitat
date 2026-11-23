using System.ComponentModel.DataAnnotations;

namespace Bokcitat.Api.Dto;

public class BookRequest
{
    [Required(ErrorMessage = "Title is required.")]
    [MaxLength(200, ErrorMessage = "Title cannot exceed 200 characters.")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Author is required.")]
    [MaxLength(100, ErrorMessage = "Author cannot exceed 100 characters.")]
    public string Author { get; set; } = string.Empty;

    [Required(ErrorMessage = "Publication date is required.")]
    public DateOnly? PublicationDate { get; set; }
}