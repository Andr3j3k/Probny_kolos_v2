namespace Probny_kolosv2.DTOs;

public class CreateRentalWithMoviesDto
{
    public DateTime RentalDate { get; set; }
    public List<CreateMovieDetailsDto> Movies { get; set; } = [];
}