using Microsoft.AspNetCore.Components;
using MudBlazor;
using Portfolio.Components.Projects;

namespace Portfolio.Pages.Projects;

public partial class RogueVitaProjectPage : ComponentBase
{
    private const string RepositoryUrl = "https://github.com/ldevillard/Rogue-Vita";

    private static readonly ProjectChip[] LinkChips =
    [
        new("GitHub repository", Color.Secondary, Icons.Custom.Brands.GitHub, RepositoryUrl),
    ];

    private static readonly ProjectChip[] TechChips =
    [
        new("OpenGL", Color.Warning),
        new("C++", Color.Warning),
    ];

    private static readonly string[] SummaryParagraphs =
    [
        "This project started from a strong desire to build a real-time physics simulation and explore a more dynamic side of graphics programming.",
        "It also felt like a good opportunity to reuse Devil Engine as a foundation instead of starting from scratch, and to see how far it could support a simulation oriented project.",
        "What makes this project especially interesting to me is that it brings several areas together at once: simulation, engine architecture, rendering, and tooling.",
        "The project started with a naive all pairs approach with quadratic complexity O(n²), and later evolved toward a uniform grid based neighbor search to support many more particles on the CPU."
    ];

    private const string NextStep = "Next step: I would like to keep pushing the CPU uniform grid version so it can handle even more particles, then move the simulation to the GPU. I would also like to experiment with floating objects by making a small boat float on the fluid, and later explore it with DirectX 12 rendering to deepen my rendering skills.";

    private static readonly ProjectShowcase[] ShowcaseItems =
    [
        new(
            "First gameplay",
            "TODO",
            "images/projects/rogue-vita/rogue-vita-small-gameplay.gif"),
        new(
            "Animation framework",
            "TODO",
            "images/projects/rogue-vita/rogue-vita-animation.gif"),
    ];

    private static readonly ProjectSourceLink[] Sources =
    [
        new(
            "LearnOpenGL: Skeletal Animation",
            "https://learnopengl.com/Guest-Articles/2020/Skeletal-Animation"),
        new(
            "Rinnegatamante: VitaGL",
            "https://github.com/rinnegatamante/vitagl"),
    ];
}