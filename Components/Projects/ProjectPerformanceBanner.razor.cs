using Microsoft.AspNetCore.Components;

namespace Portfolio.Components.Projects;

public partial class ProjectPerformanceBanner : ComponentBase
{
    [Parameter, EditorRequired] public string Platform { get; set; } = string.Empty;
    [Parameter, EditorRequired] public int FrameRateTarget { get; set; }
    [Parameter, EditorRequired] public int SkinnedMeshCount { get; set; }
    [Parameter, EditorRequired] public int SkinnedMeshFrameRate { get; set; }
    [Parameter, EditorRequired] public int DynamicLightCount { get; set; }
}
