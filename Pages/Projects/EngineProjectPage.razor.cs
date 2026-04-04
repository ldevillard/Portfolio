using Microsoft.AspNetCore.Components;
using MudBlazor;
using Portfolio.Components.Projects;

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

    private static readonly ChallengeItem[] Challenges =
    [
        new(
            "BVH on CPU and GPU",
            ["One of the main challenges was making the BVH work well on both the CPU and the GPU.",
                "What works nicely on the CPU is not always easy to use on the GPU, where the data needs to be simpler and more regular.",
                "To keep both sides consistent, the BVH was moved toward a more uniform indexed structure that can be sent to the GPU more easily without feeling like a completely separate system."],
            Icons.Material.Filled.Memory),
        new(
            "Unlimited textures for ray tracing",
            ["Textures became another limitation as scenes grew more detailed.",
                "A system based on a small fixed number of texture slots does not scale well when many different materials are involved.",
                "Using bindless textures removed that constraint and made it much easier for materials to refer to textures freely, which helped the ray tracer scale to larger and more varied scenes."],
            Icons.Material.Filled.Collections),
        new(
            "Scene serialization and pointer reconstruction", 
            ["Saving a scene was not only about writing values into JSON.",
                "The harder part was rebuilding the links between objects when the scene was loaded again.",
                "This was handled by saving entities and components as structured data, recreating them from their type when loading, then reconnecting the references the engine needs at runtime."],
            Icons.Material.Filled.Save),
        new(
            "Outline through occlusion",
            ["For selected objects, I wanted hidden objects to stay readable without showing the whole model through other geometry.",
                "Rendering the selection in a separate pass and blending only the final outline back onto the scene solved that cleanly.",
                "This way, when an object is behind another one, you only see its contour, which keeps the editor much clearer."],
            Icons.Material.Filled.Gesture)
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
            "https://jacco.ompf2.com/2022/04/18/how-to-build-a-bvh-part-2-faster-rays/"),
        new(
            "Inigo Quilez: Ray-Surface intersection functions",
            "https://iquilezles.org/articles/intersectors/"
        )
    ];

    private sealed record FeatureItem(string Title, string Description, string Icon);

    private sealed record ChallengeItem(string Title, string[] Description, string Icon);

    private sealed record ShowcaseItem(string Title, string Description, string ImageSrc);
}
