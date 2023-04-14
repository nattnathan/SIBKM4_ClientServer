using System.Text.Json.Serialization;

namespace API.Models;

public class Education
{
    public int Id { get; set; }
    public string Major { get; set; }
    public string Degree { get; set; }
    public string GPA { get; set; }
    public int? UniversityId { get; set; }

    // Cardinality
    [JsonIgnore]
    public University? University { get; set; }
    [JsonIgnore]
    public Profiling? Profiling { get; set; }
}