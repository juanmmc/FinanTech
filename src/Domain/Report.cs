
namespace FinanTech.Domain;

using System.Collections.Generic;
using System;

public class Report
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public DateTime CreationDate { get; set; }
    public string ProcessingLevel { get; set; }
    public override string ToString()
    {
        var parts = new List<string>();
        if (!string.IsNullOrWhiteSpace(Title))
            parts.Add($"Title: {Title}");
        if (!string.IsNullOrWhiteSpace(Content))
            parts.Add($"Content: {Content}");
        if (!string.IsNullOrWhiteSpace(Author))
            parts.Add($"Author: {Author}");
        if (CreationDate != DateTime.MinValue)
            parts.Add($"Creation Date: {CreationDate}");
        if (!string.IsNullOrWhiteSpace(ProcessingLevel))
            parts.Add($"Processing Level: {ProcessingLevel}");
        return string.Join(", ", parts);
    }
}
