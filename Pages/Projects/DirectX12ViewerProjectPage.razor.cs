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
        "My DirectX 12 Viewer is a small prototype built to understand the fundamentals of modern graphics APIs and gain experience using DirectX 12.",
        "The goal was not to build a full rendering engine, but to experiment with core concepts such as command lists, resource management, synchronization, and GPU control.",
        "By keeping the project intentionally simple, I could focus on learning how the API behaves and how rendering work is scheduled and executed on the GPU.",
        "I also took the opportunity to structure the project into separate modules, isolating the rendering API, the model loading library, and the main application.",
        "This project helped me build confidence with explicit graphics programming and prepared the ground for more advanced rendering experiments."
    ];

    private const string NextStep = "Next step: I plan to extend this knowledge by building more complete rendering systems and exploring performance-oriented techniques using DirectX 12.";

    private const string ChallengesIntro = "Here are a few challenges that came up while building this prototype. Several of them helped clarify how explicit graphics APIs behave in practice, particularly around resource management, pipeline configuration, and synchronization between the CPU and GPU.";

    private static readonly ProjectFeature[] Features =
    [
        new(
            "DirectX 12 fundamentals",
            "Built a small rendering prototype to understand how DirectX 12 manages command lists, resources, and GPU synchronization.",
            Icons.Material.Filled.DeveloperBoard),
        new(
            "Basic model loading",
            "Loaded external meshes using Assimp and uploaded vertex and index data to the GPU for rendering.",
            Icons.Material.Filled.ViewInAr),
        new(
            "Interactive camera navigation",
            "Implemented simple keyboard and mouse controls to move around the scene and inspect the rendered models.",
            Icons.Material.Filled.Explore),
        new(
            "ImGui integration",
            "Added a debug overlay to switch rendering modes such as wireframe while the viewer is running.",
            Icons.Material.Filled.DashboardCustomize)
    ];

    private static readonly ProjectChallenge[] Challenges =
    [
        new(
            "Isolating the graphics API implementation",
            ["I wanted to structure the project so that the DirectX 12 implementation would remain reusable beyond this prototype.", 
                "Rather than placing all rendering logic directly inside the main application, the graphics API code was isolated into its own module with clear responsibilities.",
                "This separation allowed the viewer to stay simple while keeping the rendering layer independent and easier to evolve.",
            "Designing the project this way turned the prototype into a reusable foundation that can be extended or integrated into future rendering experiments."],
            Icons.Material.Filled.Layers),
        new(
            "Runtime rendering mode switching",
            ["A feature I wanted to implement was allowing the rendering mode to be changed at runtime, switching between solid and wireframe rendering.",
                "In DirectX 12, pipeline state objects are immutable once created, which means rendering settings such as the fill mode cannot be modified dynamically.",
                "To support runtime switching, separate pipeline state objects had to be created ahead of time and selected depending on the active rendering mode.",
            "Designing the rendering flow around this constraint helped clarify how pipeline configuration works in explicit graphics APIs and reinforced the importance of preparing multiple pipeline states for different rendering scenarios."],
            Icons.Material.Filled.SwitchAccessShortcutAdd),
        new(
            "Resource binding and pipeline setup",
            ["Managing how resources are bound to the rendering pipeline quickly became an important design concern.",
                "In DirectX 12, resources such as buffers must be explicitly described and organized before they can be used by shaders.",
                "This required building a small but structured approach to resource binding so that rendering code remained readable and easy to extend.",
                "Establishing this structure early made the rendering pipeline easier to understand and provided a starting point for adding new rendering features later."],
            Icons.Material.Filled.Cable),
        new(
            "Window resizing and GPU synchronization",
            ["Handling window resizing introduced an important challenge related to resource lifetime and GPU synchronization.",
                "When the window size changes, swap chain buffers and dependent resources such as render targets must be recreated to match the new dimensions.",
                "However, these resources may still be in use by the GPU if commands are still being executed.",
            "To safely resize the swap chain, the GPU queue had to be flushed to ensure that all in-flight command lists had completed before releasing and recreating the back buffers.",
            "Implementing this helped clarify how resource ownership and synchronization must be handled when rebuilding rendering resources in real-time applications."],
            Icons.Material.Filled.SyncProblem)
    ];

    private static readonly ProjectShowcase[] ShowcaseItems =
    [
        new(
            "First render",
            "One of the first renders I produced using my own Direct3D implementation.",
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
