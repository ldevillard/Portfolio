using Microsoft.AspNetCore.Components;

namespace Portfolio.Components.Shared;

public partial class GithubFooter : ComponentBase
{
    [Parameter, EditorRequired] public string Href { get; set; } = string.Empty;
}
