using Microsoft.AspNetCore.Components;
using MudBlazor;
using Portfolio.Components.Projects;

namespace Portfolio.Pages.Projects;

public partial class SmoothParticleHydrodynamicsProjectPage : ComponentBase
{
    private const string RepositoryUrl = "https://example.com/sph-repository-placeholder";
    private const string NotesUrl = "https://example.com/sph-technical-notes-placeholder";
    private const string DemoUrl = "https://example.com/sph-demo-placeholder";

    private static readonly ProjectChip[] LinkChips =
    [
        new("GitHub repository", Color.Secondary, Icons.Custom.Brands.GitHub, RepositoryUrl),
        new("Technical notes", Color.Secondary, Icons.Material.Filled.Article, NotesUrl),
        new("Demo capture", Color.Success, Icons.Material.Filled.ArrowOutward, DemoUrl)
    ];

    private static readonly ProjectChip[] TechChips =
    [
        new("Simulation", Color.Warning),
        new("Fluids", Color.Warning),
        new("Rendering", Color.Warning)
    ];

    private static readonly string[] SummaryParagraphs =
    [
        "Smooth Particle Hydrodynamics is a placeholder entry for an upcoming fluid simulation project based on particles rather than a fixed grid.",
        "The goal of the project is to explore how a real-time SPH solver can be structured, stabilized, and visualized inside a clean interactive prototype.",
        "For now the page only contains placeholder content, but the final version will document the simulation loop, neighbor search strategy, parameter tuning, and rendering approach."
    ];

    private const string NextStep = "Next step: replace these placeholders with the first simulation capture and a concrete breakdown of the solver implementation.";

    private const string ChallengesIntro = "These placeholder challenges map the main technical areas I expect to document once the first presentable version of the project is ready.";

    private static readonly ProjectFeature[] Features =
    [
        new(
            "Particle simulation core",
            "Placeholder section for the solver update loop, particle integration, and force accumulation pipeline.",
            Icons.Material.Filled.BlurOn),
        new(
            "Neighborhood queries",
            "Placeholder section for the spatial partitioning strategy used to keep neighbor lookups fast enough for interactive updates.",
            Icons.Material.Filled.GridView),
        new(
            "Fluid rendering",
            "Placeholder section for the visual representation of particles, density, and surface behavior in the viewport.",
            Icons.Material.Filled.WaterDrop),
        new(
            "Runtime controls",
            "Placeholder section for the debug controls used to tweak parameters and inspect simulation stability in real time.",
            Icons.Material.Filled.Tune)
    ];

    private static readonly ProjectChallenge[] Challenges =
    [
        new(
            "Keeping the simulation stable",
            ["This placeholder challenge will later describe how timestep size, smoothing radius, and pressure settings affect the overall behavior of the simulation.",
                "SPH setups can become unstable quickly when parameters drift apart, so part of the project will be documenting how stability is maintained during iteration.",
                "The final write-up will explain which safeguards were added once the implementation became usable."],
            Icons.Material.Filled.Speed),
        new(
            "Scaling neighbor search",
            ["A naive particle-to-particle search becomes too expensive as soon as the particle count grows.",
                "This placeholder section will be replaced by a description of the spatial hashing or uniform grid strategy used to reduce the number of neighbor checks.",
                "I also plan to document the practical tradeoffs between simplicity, memory layout, and runtime cost."],
            Icons.Material.Filled.Search),
        new(
            "Handling boundaries and collisions",
            ["Fluid behavior depends heavily on how particles interact with container walls and obstacles.",
                "This placeholder challenge will later cover the boundary approach chosen for the prototype and the issues that appeared around leaks, sticking, or excessive bouncing.",
                "It should also capture how those constraints influenced the overall simulation feel."],
            Icons.Material.Filled.CropFree),
        new(
            "Making the result readable",
            ["Even when the simulation is numerically correct, the visual output still needs to be clear enough to inspect and debug.",
                "This placeholder section will later explain how particle rendering, density cues, or surface shading were used to make the fluid easier to read.",
                "The final page will include captures that show those rendering choices in context."],
            Icons.Material.Filled.Visibility)
    ];

    private static readonly ProjectShowcase[] ShowcaseItems =
    [
        new(
            "Simulation overview",
            "A first overview of the SPH simulation running in real time.",
            "images/projects/sph/SPH.gif"),
        new(
            "Flow behavior",
            "Another capture focused on the overall particle flow and shape evolution.",
            "images/projects/sph/SPH2.gif"),
        new(
            "Interaction test",
            "A showcase capture highlighting interactions and motion inside the simulation domain.",
            "images/projects/sph/SPH3.gif"),
        new(
            "Rendering pass",
            "A final capture showing a different rendering or simulation state from the same project.",
            "images/projects/sph/SPH4.gif")
    ];

    private static readonly ProjectSourceLink[] Sources =
    [
        new(
            "SPH reference placeholder",
            "https://example.com/sph-reference-placeholder")
    ];
}
