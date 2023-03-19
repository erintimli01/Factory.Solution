using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "A machine must be added")]
    public string MachineName { get; set; }
    //public List<Engineer> Engineers { get; set; }
    public DateTime? InstallDate { get; set; }
    public DateTime? LastInspection { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}