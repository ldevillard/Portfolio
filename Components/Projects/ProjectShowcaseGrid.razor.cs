using Microsoft.AspNetCore.Components;

namespace Portfolio.Components.Projects;

public partial class ProjectShowcaseGrid : ComponentBase
{
    [Parameter] public string Title { get; set; } = "Selected Visuals";
    [Parameter] public IReadOnlyList<ProjectShowcase> ShowcaseItems { get; set; } = Array.Empty<ProjectShowcase>();
}
