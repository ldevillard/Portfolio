using Microsoft.AspNetCore.Components;

namespace Portfolio.Components.Projects;

public partial class ProjectSummaryCard : ComponentBase
{
    [Parameter] public string Title { get; set; } = "Project Summary and Motivation";

    [Parameter] public IReadOnlyList<string> Paragraphs { get; set; } = Array.Empty<string>();

    [Parameter] public string? NextStep { get; set; }
}
