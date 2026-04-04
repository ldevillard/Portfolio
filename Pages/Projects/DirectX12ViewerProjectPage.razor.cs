using Microsoft.AspNetCore.Components;
using MudBlazor;
using Portfolio.Components.Projects;

namespace Portfolio.Pages.Projects;

public partial class DirectX12ViewerProjectPage : ComponentBase
{
    private const string RepositoryUrl = "https://github.com/ldevillard/DX12-Prototype";
    private const string ArticleUrl = "https://example.com/directx12-article-placeholder";
    private const string DemoUrl = "https://example.com/directx12-demo-placeholder";

    private static readonly ProjectChip[] LinkChips =
    [
        new("GitHub repository", Color.Secondary, Icons.Custom.Brands.GitHub, RepositoryUrl),
        new("Related article", Color.Secondary, Icons.Material.Filled.Article, ArticleUrl),
    ];

    private static readonly ProjectChip[] TechChips =
    [
        new("Placeholder Tech 1", Color.Warning),
        new("Placeholder Tech 2", Color.Warning)
    ];

    private static readonly string[] SummaryParagraphs =
    [
        "Placeholder paragraph summarizing the DirectX 12 viewer project and its overall goals.",
        "Placeholder paragraph describing rendering pipeline choices, tools, and workflow.",
        "Placeholder paragraph about learnings, experimentation opportunities, and future improvements."
    ];

    private const string NextStep = "Placeholder next step to highlight a planned improvement or experiment for this viewer.";

    private const string ChallengesIntro = "Placeholder overview of technical or design challenges encountered while building this viewer.";

    private static readonly ProjectFeature[] Features =
    [
        new(
            "Placeholder feature title 1",
            "Placeholder feature description detailing rendering capability or tool.",
            Icons.Material.Filled.AutoAwesomeMosaic),
        new(
            "Placeholder feature title 2",
            "Placeholder feature description exploring debugging, profiling, or tooling aspects.",
            Icons.Material.Filled.Tune),
        new(
            "Placeholder feature title 3",
            "Placeholder feature description covering performance, GPU resource management, or accuracy.",
            Icons.Material.Filled.Speed),
        new(
            "Placeholder feature title 4",
            "Placeholder feature description about asset loading, camera controls, or visualization.",
            Icons.Material.Filled.PhotoCameraFront)
    ];

    private static readonly ProjectChallenge[] Challenges =
    [
        new(
            "Placeholder challenge 1",
            ["Placeholder challenge first line.",
                "Placeholder challenge additional detail line.",
                "Placeholder challenge conclusion or solution summary."],
            Icons.Material.Filled.Memory),
        new(
            "Placeholder challenge 2",
            ["Placeholder challenge first line.",
                "Placeholder challenge additional detail line.",
                "Placeholder challenge conclusion or solution summary."],
            Icons.Material.Filled.Collections),
        new(
            "Placeholder challenge 3",
            ["Placeholder challenge first line.",
                "Placeholder challenge additional detail line.",
                "Placeholder challenge conclusion or solution summary."],
            Icons.Material.Filled.Save),
        new(
            "Placeholder challenge 4",
            ["Placeholder challenge first line.",
                "Placeholder challenge additional detail line.",
                "Placeholder challenge conclusion or solution summary."],
            Icons.Material.Filled.Gesture)
    ];

    private static readonly ProjectShowcase[] ShowcaseItems =
    [
        new(
            "Placeholder visual 1",
            "Placeholder description for first visual.",
            "images/projects/directx12-viewer/bike-showcase.gif"),
        new(
            "Placeholder visual 2",
            "Placeholder description for second visual.",
            "images/projects/directx12-viewer/bike-showcase.gif"),
        new(
            "Placeholder visual 3",
            "Placeholder description for third visual.",
            "images/projects/directx12-viewer/bike-showcase.gif"),
        new(
            "Placeholder visual 4",
            "Placeholder description for fourth visual.",
            "images/projects/directx12-viewer/bike-showcase.gif")
    ];

    private static readonly ProjectSourceLink[] Sources =
    [
        new(
            "Placeholder source 1",
            "https://example.com/source-1"),
        new(
            "Placeholder source 2",
            "https://example.com/source-2"),
        new(
            "Placeholder source 3",
            "https://example.com/source-3"),
        new(
            "Placeholder source 4",
            "https://example.com/source-4")
    ];
}
