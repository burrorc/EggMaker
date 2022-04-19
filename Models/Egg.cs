using System.ComponentModel.DataAnnotations;

namespace EggMaker.Models;

public class Egg{
    public int Id {get; set; }

    [Required]
    public string? Name {get; set; }
    public EggSize Size {get; set; }
    public bool IsOrganic {get; set; }

    [Range(0.01, 9999.99)]
    public decimal Price {get; set; }

}

public enum EggSize {Small, Medium, Large}