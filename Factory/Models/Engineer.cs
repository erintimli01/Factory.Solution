using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "An engineer must be added")]
    public string Name { get; set; }
    //public int MachineId { get; set; }
    //public Machine Machine { get; set; }
    //public List<Machine> Machines { get; set; }
    public List<EngineerMachine> EngineerMachines { get; }
  }
}