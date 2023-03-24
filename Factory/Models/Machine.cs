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
    [Required(ErrorMessage = "An install date must be added")]
    public DateTime? InstallDate { get; set; }
    [Required(ErrorMessage = "A last inspection date must be added, enter install date if machine is new")]
    public DateTime? LastInspection { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}