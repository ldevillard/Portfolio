using Microsoft.AspNetCore.Components;

namespace Portfolio.Components.Projects;

public partial class ProjectLinksBar : ComponentBase
{
    [Parameter] public IReadOnlyList<ProjectChip> Links { get; set; } = Array.Empty<ProjectChip>();
    [Parameter] public IReadOnlyList<ProjectChip> Tags { get; set; } = Array.Empty<ProjectChip>();
}
