using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "Machine name is required")]
    public string MachineName { get; set; }
    public List<Engineer> Engineers { get; set; }
    public List<EngineerMachine> EngineerMachines { get; }
  }
}