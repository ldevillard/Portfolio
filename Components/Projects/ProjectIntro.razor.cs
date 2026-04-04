using Microsoft.AspNetCore.Components;

namespace Portfolio.Components.Projects;

public partial class ProjectIntro : ComponentBase
{
    [Parameter, EditorRequired] public string Title { get; set; } = string.Empty;
    [Parameter, EditorRequired] public string Description { get; set; } = string.Empty;
    [Parameter, EditorRequired] public string ImageSrc { get; set; } = string.Empty;
}
