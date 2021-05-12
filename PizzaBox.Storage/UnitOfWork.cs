using PizzaBox.Storage.Repositories;

namespace PizzaBox.Storage
{
  public class UnitOfWork
  {
    private readonly PizzaBoxContext _context;
    public CrustRepository Crusts { get; }
    public CustomerRepository Customers { get; set; }
    public OrderRepository Orders { get; set; }
    public PizzaRepository Pizzas { get; set; }
    public SizeRepository Sizes { get; }
    public StoreRepository Stores { get; }
    public ToppingRepository Toppings { get; }

    public UnitOfWork(PizzaBoxContext context)
    {
      _context = context;
      Crusts = new CrustRepository(_context);
      Customers = new CustomerRepository(_context);
      Orders = new OrderRepository(_context);
      Pizzas = new PizzaRepository(_context);
      Sizes = new SizeRepository(_context);
      Stores = new StoreRepository(_context);
      Toppings = new ToppingRepository(_context);
    }

    public void Save()
    {
      _context.SaveChanges();
    }
  }
}