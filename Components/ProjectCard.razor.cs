using Microsoft.AspNetCore.Components;

namespace Portfolio.Components;

public partial class ProjectCard : ComponentBase
{
    [Parameter] public string Href { get; set; } = string.Empty;
    [Parameter, EditorRequired] public string Title { get; set; } = string.Empty;
    [Parameter] public string Category { get; set; } = string.Empty;
    [Parameter, EditorRequired] public string Description { get; set; } = string.Empty;
    [Parameter, EditorRequired] public string ImageSrc { get; set; } = string.Empty;
}
