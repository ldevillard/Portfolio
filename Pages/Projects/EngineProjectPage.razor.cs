using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Portfolio.Pages.Projects;

public partial class EngineProjectPage : ComponentBase
{
    private const string RepositoryUrl = "https://github.com/ldevillard/Devil-Engine";
    private const string MousePickingArticleUrl = "https://medium.com/@logandvllrd/how-to-pick-a-3d-object-using-raycasting-in-c-39112aed1987";

    private static readonly FeatureItem[] Features =
    [
        new(
            "Real-time rendering",
            "A custom OpenGL renderer with mesh rendering, materials, cubemaps, multiple light types, and shadow mapping.",
            Icons.Material.Filled.LightMode),
        new(
            "Editor tooling",
            "An integrated editor with hierarchy, inspector, transform gizmos, scene controls, object outlining, and viewport navigation.",
            Icons.Material.Filled.Tune),
        new(
            "Ray tracing",
            "A dedicated BVH-based ray tracing mode with reflections, refractions, accumulation, and configurable rendering settings.",
            Icons.Material.Filled.AutoFixHigh),
        new(
            "Scene workflow",
            "Model import, entity/component scene data, and JSON serialization for saving and reloading scenes inside the editor.",
            Icons.Material.Filled.Save)
    ];

    private static readonly ShowcaseItem[] ShowcaseItems =
    [
        new(
            "Editor view",
            "The main viewport combines rendering and in-engine editing tools in the same workflow.",
            "images/editor-showcase.gif"),
        new(
            "BVH debug view",
            "A useful example of rendering-oriented debugging and engine-side visualization.",
            "images/bvh-showcase.gif"),
        new(
            "Raytraced frame",
            "A rendered frame that highlights reflections, refractions, and accumulation experiments.",
            "images/raytracing.png"),
        new(
            "Raytraced video showcase",
            "A video that shows a plane using orbital movements and comparing raytraced and rasterized renders.",
            "images/demo-plane.gif")
    ];

    private sealed record FeatureItem(string Title, string Description, string Icon);

    private sealed record ShowcaseItem(string Title, string Description, string ImageSrc);
}
