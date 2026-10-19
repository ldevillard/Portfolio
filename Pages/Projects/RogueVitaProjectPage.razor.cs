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
        "The project started as a way to explore game programming in a more production-oriented context, focusing on building the systems needed to support gameplay.",
        "Alongside the game, I am developing a reusable, engine and platform-agnostic framework that provides a common foundation for gameplay development across platforms and future projects.",
        "I chose the PlayStation Vita as a target because I enjoy handheld gaming, and its hardware limitations provide an interesting challenge for performance and engine development."
    ];

    private const string NextStep = "Next step: I plan to add physics and collision detection while continuing to improve the framework as the game grows.";

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