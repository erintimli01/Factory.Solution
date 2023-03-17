using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public Dbset<Engineer> Engineers { get; set; }
    public Dbset<Machine> Machines { get; set; }
    public Dbset<EngineerMachine> EngineerMachines { get; set; }

    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}