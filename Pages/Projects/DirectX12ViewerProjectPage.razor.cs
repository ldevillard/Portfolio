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
    ];

    private static readonly ProjectChip[] TechChips =
    [
        new("DirectX", Color.Warning),
        new("C++", Color.Warning)
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
            "First render",
            "One of the first render I had using my own implementation of Direct3D!",
            "images/projects/directx12-viewer/first-dx12-render.gif"),
        new(
            "Model loading and rendering",
            "A render of a custom model loaded in the viewer, with a tiny bit of lighting.",
            "images/projects/directx12-viewer/bike-showcase.gif")
    ];

    private static readonly ProjectSourceLink[] Sources =
    [
        new(
            "Jeremiah: Learning DirectX12",
            "https://www.3dgep.com/learning-directx-12-1/"),
        new(
            "Microsoft Direct3D 12 programming guide",
            "https://learn.microsoft.com/fr-fr/windows/win32/direct3d12/directx-12-programming-guide"),
        new(
            "Microsoft DirectX Graphics Samples",
            "https://github.com/microsoft/DirectX-Graphics-Samples"),
        new(
            "Alain Galvan: Raw DirectX 12",
            "https://alain.xyz/blog/raw-directx12")
    ];
}
