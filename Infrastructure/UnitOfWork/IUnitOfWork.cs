using web_api_base.Models.dbebay;
public interface IUnitOfWork : IAsyncDisposable
{
    public IProductRepository _productRepository{get;}
    Task<int> SaveChangesAsync();
}

public class UnitOfWork: IUnitOfWork
{
    public IProductRepository _productRepository{get;}

    private readonly EbayContext _context;
    
    public UnitOfWork(EbayContext context, IProductRepository productRepository)
    {
        _context = context;
        _productRepository = productRepository;
    }
    public Task<int> SaveChangesAsync()
    {
        return _context.SaveChangesAsync();
    }
    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }
}

