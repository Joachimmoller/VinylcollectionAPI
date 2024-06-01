using System.ComponentModel.DataAnnotations;

namespace VinylcollectionAPI.Models;

public class Artist
{
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    public DateTime Formed { get; set; }
    
    public ICollection<Album> Albums { get; set; }
    
}