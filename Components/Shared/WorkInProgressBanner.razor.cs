using Microsoft.AspNetCore.Components;

namespace Portfolio.Components.Shared;

public partial class WorkInProgressBanner : ComponentBase
{
    [Parameter] public string Title { get; set; } = "Page in progress";
    [Parameter] public string Description { get; set; } = "This page is currently being written.";
}
