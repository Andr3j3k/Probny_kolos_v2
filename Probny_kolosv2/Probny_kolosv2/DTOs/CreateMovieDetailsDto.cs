using System.ComponentModel.DataAnnotations;

namespace Probny_kolosv2.DTOs;

public class CreateMovieDetailsDto
{
    [StringLength((200))]
    public string Title { get; set; } = string.Empty;
    public decimal RentalPrice { get; set; }
}