using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Engineer
  {

    public int EngineerId { get; set; }
    [Required(ErrorMessage = "An engineer must be added")]
    public string Name { get; set; }
    public DateTime? HireDate { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}