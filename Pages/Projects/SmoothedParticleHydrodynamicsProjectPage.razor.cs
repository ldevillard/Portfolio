using Microsoft.AspNetCore.Components;
using MudBlazor;
using Portfolio.Components.Projects;

namespace Portfolio.Pages.Projects;

public partial class SmoothedParticleHydrodynamicsProjectPage : ComponentBase
{
    private const string RepositoryUrl = "https://example.com/sph-repository-placeholder";
    private const string NotesUrl = "https://example.com/sph-technical-notes-placeholder";
    private const string DemoUrl = "https://example.com/sph-demo-placeholder";

    private static readonly ProjectChip[] LinkChips =
    [
        new("GitHub repository", Color.Secondary, Icons.Custom.Brands.GitHub, RepositoryUrl),
    ];

    private static readonly ProjectChip[] TechChips =
    [
        new("DirectX 12", Color.Warning),
        new("OpenGL", Color.Warning),
        new("C++", Color.Warning),
    ];

    private static readonly string[] SummaryParagraphs =
    [
        "Project summary will be written soon.",
        "Motivation details will be written soon."
    ];

    private const string NextStep = "More details will be added soon.";

    private const string ChallengesIntro = "Challenge details will be written soon.";

    private static readonly ProjectFeature[] Features =
    [
        new(
            "Placeholder",
            "Details will be written soon.",
            Icons.Material.Filled.BlurOn),
        new(
            "Placeholder",
            "Details will be written soon.",
            Icons.Material.Filled.GridView),
        new(
            "Placeholder",
            "Details will be written soon.",
            Icons.Material.Filled.WaterDrop),
        new(
            "Placeholder",
            "Details will be written soon.",
            Icons.Material.Filled.Tune)
    ];

    private static readonly ProjectChallenge[] Challenges =
    [
        new(
            "Placeholder",
            ["Details will be written soon."],
            Icons.Material.Filled.Speed),
        new(
            "Placeholder",
            ["Details will be written soon."],
            Icons.Material.Filled.Search),
        new(
            "Placeholder",
            ["Details will be written soon."],
            Icons.Material.Filled.CropFree),
        new(
            "Placeholder",
            ["Details will be written soon."],
            Icons.Material.Filled.Visibility)
    ];

    private static readonly ProjectShowcase[] ShowcaseItems =
    [
        new(
            "First steps",
            "The project started with gravity and boundary collisions to establish the core particle behavior using GPU instancing.",
            "images/projects/sph/SPH4.gif"),
        new(
            "First SPH simulation",
            "The first working SPH implementation, rendered with velocity-based coloring.",
            "images/projects/sph/SPH.gif"),
        new(
            "Toward fluid behavior",
            "After several iterations and parameter tweaks, the particles began to behave much more like a fluid.",
            "images/projects/sph/SPH2.gif"),
        new(
            "Experiments",
            "This experiment used extreme parameter values, leading to unstable but visually interesting behavior in the simulation.",
            "images/projects/sph/SPH3.gif")
    ];

    private static readonly ProjectSourceLink[] Sources =
    [
        new(
            "References will be added soon",
            "https://example.com/sph-reference-placeholder")
    ];
}
