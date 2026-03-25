using Microsoft.AspNetCore.Components;

namespace Portfolio.Components;

public partial class FeaturedCard : ComponentBase
{
    [Parameter] public string Title { get; set; } = string.Empty;
    [Parameter] public string Role { get; set; } = string.Empty;
    [Parameter] public string Description { get; set; } = string.Empty;
    [Parameter] public string ImageSrc { get; set; } = string.Empty;
    [Parameter] public string ImageAlt { get; set; } = string.Empty;
    [Parameter] public string CreditsUrl { get; set; } = string.Empty;

    [Parameter] public int Xs { get; set; } = 12;
    [Parameter] public int Sm { get; set; } = 6;
    [Parameter] public int Md { get; set; } = 4;
}