using Microsoft.AspNetCore.Components;

namespace Portfolio.Components.Articles;

public partial class ArticleCard : ComponentBase
{
    [Parameter, EditorRequired] public string Href { get; set; } = string.Empty;
    [Parameter, EditorRequired] public string Title { get; set; } = string.Empty;
    [Parameter] public IReadOnlyList<string> Categories { get; set; } = [];
    [Parameter, EditorRequired] public string ImageSrc { get; set; } = string.Empty;
}
