namespace API.Models;

public class University
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Cardinality
    public ICollection<Education> Educations { get; set; }
}
