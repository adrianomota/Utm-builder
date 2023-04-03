using UtmBuilder.Core.ValueObjects.Exceptions;
namespace UtmBuilder.Core.ValueObjects;
public class Campaign : ValueObjehct
{
    public Campaign(
        string source, 
        string medium, 
        string name,
        string? id = null,
        string? term = null,
        string? content = null)
    {
        Source = source;
        Medium = medium;
        Name = name;
        Id = id;
        Term = term;
        Content = content;

        InvalidCampaignException.ThrowIfNull(source, "Source is invalid");
        InvalidCampaignException.ThrowIfNull(medium, "Medium is invalid");
        InvalidCampaignException.ThrowIfNull(name, "Name is invalid");
    }
    public string? Id { get; init; }
    public string Source { get; init; }
    public string Medium { get; init; }
    public string Name { get; init; }
    public string? Term { get; init; }
    public string? Content { get; init; }
}