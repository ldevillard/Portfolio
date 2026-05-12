using Microsoft.AspNetCore.Components;
using MudBlazor;
using Portfolio.Components.Projects;

namespace Portfolio.Pages.Projects;

public partial class SmoothedParticleHydrodynamicsProjectPage : ComponentBase
{
    private const string RepositoryUrl = "https://github.com/ldevillard/Devil-Engine";

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
            "images/projects/sph/SPH3.gif"),
        new(
            "Uniform grid acceleration",
            "Switching to a uniform grid for neighbor search made it possible to simulate many more particles while keeping the update fast enough to stay interactive.",
            "images/projects/sph/fluid-grid.gif"),
        new(
            "Uniform grid debug view",
            "A debug visualization of the uniform grid, useful for checking how particles are distributed across cells and how the spatial partitioning behaves.",
            "images/projects/sph/fluid-debug-grid.gif"),
    ];

    private static readonly ProjectSourceLink[] Sources =
    [
        new(
            "Muller, Charypar, Gross: Particle-Based Fluid Simulation for Interactive Applications",
            "https://matthias-research.github.io/pages/publications/sca03.pdf"),
        new(
            "Sebastian Lague: Simulating Fluids",
            "https://www.youtube.com/watch?v=rSKMYc1CQHE"),
        new(
            "Ahmed Fathy Elbossily: SPH and Hashing",
            "https://medium.com/@ahmed.fathy.elbossily/sph-and-hashing-c28e70ff7615"),
        new(
            "Nobody Builds: Fluid Simulation",
            "https://github.com/NobodyBuilds/fluid_sim")
    ];
}
