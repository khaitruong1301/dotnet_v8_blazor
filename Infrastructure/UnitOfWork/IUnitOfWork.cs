using web_api_base.Models.dbebay;
public interface IUnitOfWork : IAsyncDisposable
{
    public IUserRepository _userRepository{get;}
    // public IUserRoleRepository _userRoleRepository{get;}
    public IRoleRepository _roleRepository{get;}
    Task<int> SaveChangesAsync();
}

public class UnitOfWork: IUnitOfWork
{
     public IUserRepository _userRepository{get;}
    // public IUserRoleRepository _userRoleRepository{get;}
    public IRoleRepository _roleRepository{get;}

    private readonly EbayContext _context;
    
    public UnitOfWork(EbayContext context, IUserRepository userRepository, IRoleRepository roleRepository)
    {
        _context = context;
        _userRepository = userRepository;
        // _userRoleRepository = userRoleRepository;
        _roleRepository = roleRepository;

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

