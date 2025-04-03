using web_api_base.Models.dbebay;

public interface IProductService
{
    Task<dynamic> GetAllProduct();
}

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    private readonly IUnitOfWork _uow;

    public ProductService(IProductRepository repository,IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _uow = unitOfWork;
    }

    public async Task<dynamic> GetAllProduct()
    {
        IEnumerable<Product> res = await _uow._productRepository.GetAllAsync();
        return new {
            StatusCode = 200,
            Data = res.Skip(0).Take(10)
        };
    }
}


