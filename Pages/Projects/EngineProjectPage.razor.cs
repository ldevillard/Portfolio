using Microsoft.AspNetCore.Components;
using MudBlazor;
using Portfolio.Components;

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
            "A useful example of rendering and engine visualization.",
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

    private static readonly ProjectSourceLink[] Sources =
    [
        new(
            "LearnOpenGL",
            "https://learnopengl.com/"),
        new(
            "Raytracing in One Weekend",
            "https://raytracing.github.io/books/RayTracingInOneWeekend.html"),
        new(
            "Sebastian Lague: Raytracing",
            "https://www.youtube.com/watch?v=Qz0KTGYJtUk&t=1888s"),
        new(
            "Sebastian Lague: BVH Raytracing",
            "https://www.youtube.com/watch?v=C1H4zIiCOaI"),
        new(
            "jbikker: How to build a BVH",
            "https://jacco.ompf2.com/2022/04/18/how-to-build-a-bvh-part-2-faster-rays/")
    ];

    private sealed record FeatureItem(string Title, string Description, string Icon);

    private sealed record ShowcaseItem(string Title, string Description, string ImageSrc);
}
