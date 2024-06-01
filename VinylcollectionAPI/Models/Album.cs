using System.ComponentModel.DataAnnotations;

namespace VinylcollectionAPI.Models;

public class Album
{
    public int Id { get; set; }
    
    [Required]
    public string Title { get; set; }
    
    public int? ReleaseYear { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
    
    public int ArtistId { get; set; }
    public Artist Artist { get; set; }
    
    public int GenreId { get; set; }
    public Genre Genre { get; set; }
    
}