using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "An engineer must be added")]
    public string MachineName { get; set; }
    //public List<Engineer> Engineers { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}