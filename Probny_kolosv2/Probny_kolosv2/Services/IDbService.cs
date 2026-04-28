using Probny_kolosv2.DTOs;

namespace Probny_kolosv2.Services;

public interface IDbService
{
    Task<GetCustomerRentalsDto> GetCustomerRentalsAsync(int customerId);
    Task CreateRentalWithMoviesAsync(int customerId, CreateRentalWithMoviesDto dto);
}