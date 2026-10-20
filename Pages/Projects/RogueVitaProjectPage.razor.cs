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
        "Rogue Vita is a work-in-progress isometric rogue-lite game built alongside a custom C++ engine, working on both PC and PlayStation Vita platforms.",
        "I started this project to explore game development in a production-oriented way, building things as much as possible by myself, from engine systems to gameplay features.",
        "Alongside the game, I am developing a reusable cross-platform engine, providing a common foundation for gameplay development in this and future projects.",
        "I chose to work on the PlayStation Vita because I enjoy handheld gaming, and its hardware limitations make it an interesting challenge to optimize the engine/gameplay and maintain a target of 60 fps.",
        "The main goal is to build a fun and responsive game, focusing on game feel while developing the engine and tools needed by the gameplay!"
    ];

    private const string NextStep = "Next step: I plan to keep building a fully playable game by adding features like physics, audio, and pathfinding... While expanding the framework along the way.";

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
            "Custom asset cooker converting source assets into runtime formats, reducing the amount of processing required at runtime.",
            Icons.Material.Filled.Transform)
    ];

    private const string ChallengesIntro = "Building a game with a custom engine means improving the engine and creating the tools needed along the way. This includes debugging tools and asset cooking, with plans for an in-game editor and scene management. The main challenges so far have been working with the Vita's hardware limits, building an animation system, and maintaining good performance without sacrificing visual quality.";    
    
    private static readonly ProjectChallenge[] Challenges =
    [
        new(
            "Cross-platform engine and framework",
            [
                "One of the main challenges was supporting both PC and PlayStation Vita with the same codebase.",
                "The two platforms have different graphics APIs, input systems, and hardware limits, so some parts of the engine need different backends.",
                "The framework provides a shared interface for these systems, keeping most of the code platform-independent while allowing each platform to handle its own specific needs."
            ],
            Icons.Material.Filled.Devices),
        new(
            "Skeletal animation pipeline",
            [
                "Bringing animated characters into the game required more than just playing animation clips.",
                "The system loads skeletons and animation data, calculates bone poses, and prepares the transforms needed for skinning.",
                "I built a custom animation pipeline and an Animator API to control animations from gameplay code, while sending skinning matrices to the GPU for rendering."
            ],
            Icons.Material.Filled.Animation),
        new(
            "Asset cooking",
            [
                "Loading source assets directly at runtime would add unnecessary work and complexity.",
                "Meshes, textures and animation data need to be converted into formats that are easy for the engine to load and use.",
                "I developed custom asset cookers to process source files into runtime formats, keeping asset loading simpler and reducing runtime work."
            ],
            Icons.Material.Filled.Transform),
        new(
            "Gameplay features and API",
            [
                "Building gameplay features also means making engine systems easy to use and extend.",
                "The challenge is to keep the framework flexible without making simple gameplay tasks unnecessarily complex.",
                "I designed the APIs around the needs of the game, keeping gameplay code separate from the engine while using reusable components and simple interfaces to make it easier to write and maintain."
            ],
            Icons.Material.Filled.Code)
    ];
    
    private static readonly ProjectShowcase[] ShowcaseItems =
    [
        new(
            "Animation framework",
            "Multiple animated skinned meshes running at the same time using GPU skinning.",
            "images/projects/rogue-vita/rogue-vita-animation.gif"),
        new(
            "Animation performance test",
            "Measuring performance on console, observing bottlenecks, and targeting 60 fps.",
            "images/projects/rogue-vita/animation-perf.gif"),
        new(
            "Console deployment",
            "PlayStation Vita build and deployment workflow using automated scripts to iterate easily.",
            "images/projects/rogue-vita/vita.png"),
        new(
            "Console performance",
            "Improving performance on console since the limitations are encountered quickly. Time to scale the game!",
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
        new(
            "VitaSDK documentation",
            "https://docs.vitasdk.org/"),
        new(
            "Assets used in project: Meshtint Cute Series",
            "https://www.meshtint.com/collections/cute-series"),
    ];
}