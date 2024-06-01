using System.ComponentModel.DataAnnotations;

namespace VinylcollectionAPI.Models;

public class User
{
    public int Id { get; set; }
    
    [Required]
    public string Username { get; set; }
    
    [Required]
    public string Email { get; set; }
    
    [Required]
    public string PasswordHash { get; set; }
    
    public ICollection<Album> Albums { get; set; }
}