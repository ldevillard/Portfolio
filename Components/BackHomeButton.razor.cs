using Microsoft.AspNetCore.Components;

namespace Portfolio.Components;

public partial class BackHomeButton : ComponentBase
{
    [Parameter] public string Text { get; set; } = "Back to home";
    [Parameter] public string Href { get; set; } = string.Empty;
    [Parameter] public string Class { get; set; } = "mb-4";
}
