using Microsoft.AspNetCore.Components;

namespace Portfolio.Components.Shared;

public partial class SectionDivider : ComponentBase
{
    [Parameter, EditorRequired]
    public string Label { get; set; } = string.Empty;

    [Parameter]
    public string? Caption { get; set; }
}
