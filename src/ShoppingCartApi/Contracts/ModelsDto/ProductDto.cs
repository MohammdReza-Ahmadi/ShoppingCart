namespace ShoppingCardApi.UseCases.ModelsDto;

public record ProductDto(long Id,string Name,long Price,string? Description, int Quantity);