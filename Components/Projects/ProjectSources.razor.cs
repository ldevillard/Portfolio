using Microsoft.AspNetCore.Components;

namespace Portfolio.Components.Projects;

public partial class ProjectSources : ComponentBase
{
    [Parameter] public IReadOnlyList<ProjectSourceLink> Sources { get; set; } = [];
}

public sealed record ProjectSourceLink(string Text, string Href);
