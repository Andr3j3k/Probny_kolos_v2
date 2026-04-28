namespace Probny_kolosv2.DTOs;

public class GetCustomerRentalsDto
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public List<GetRentalDetailsDto> Rentals { get; set; } = [];
}