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
        new("VitaSDK", Color.Warning)
    ];

    private static readonly string[] SummaryParagraphs =
    [
        "Rogue Vita is a work-in-progress isometric rogue-lite game built alongside a custom C++ engine, targeting both PC and PlayStation Vita platforms.",
        "The project started as a way to explore game development in a production-oriented context, building as much as possible myself, from engine systems to gameplay features.",
        "Alongside the game, I am developing a reusable, engine and platform-agnostic framework that provides a common foundation for gameplay development across platforms and future projects.",
        "I chose the PlayStation Vita as a target because I enjoy handheld gaming, and its hardware limitations provide an interesting challenge for performance and engine development."
    ];

    private const string NextStep = "Next step: I plan to add physics and collision detection while continuing to improve the framework as the game grows.";

    private static readonly ProjectFeature[] Features =
    [
        new(
            "Cross-platform engine",
            "A shared C++ codebase targeting both PlayStation Vita and desktop, with platform-specific graphics and input implementations hidden behind the framework.",
            Icons.Material.Filled.Devices),
        new(
            "Hybrid ECS",
            "Combines the flexibility of an entity-component architecture with direct access to components for easier iteration and gameplay logic.",
            Icons.Material.Filled.AccountTree),
        new(
            "Skeletal animation",
            "A custom skeletal animation system supporting animated characters, pose evaluation, hierarchical transforms, and GPU skinning.",
            Icons.Material.Filled.Animation),
        new(
            "Asset pipeline",
            "Custom asset cookers converting source assets into runtime formats, reducing the amount of processing required at runtime.",
            Icons.Material.Filled.Transform)
    ];
    
    private static readonly ProjectShowcase[] ShowcaseItems =
    [
        new(
            "Current state of the project",
            "Player controller, animations, lighting and debug view.",
            "images/projects/rogue-vita/rogue-vita-small-gameplay.gif"),
        new(
            "Animation framework",
            "Multiple animated skinned mesh.",
            "images/projects/rogue-vita/rogue-vita-animation.gif"),
        new(
            "Console deployment",
            "PlayStation Vita build and deployment workflow using automated scripts to iterate easily.",
            "images/projects/rogue-vita/vita.png"),
        new(
            "Console performances",
            "Improving performances on console since the limitations are encountered quickly.",
            "images/projects/rogue-vita/vita2.png"),
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