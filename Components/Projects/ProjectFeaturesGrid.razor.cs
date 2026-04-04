using Microsoft.AspNetCore.Components;

namespace Portfolio.Components.Projects;

public partial class ProjectFeaturesGrid : ComponentBase
{
    [Parameter] public string Title { get; set; } = "Main Features";
    [Parameter] public IReadOnlyList<ProjectFeature> Features { get; set; } = Array.Empty<ProjectFeature>();
}
