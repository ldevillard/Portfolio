using Microsoft.AspNetCore.Components;
using MudBlazor;
using Portfolio.Components.Projects;

namespace Portfolio.Pages.Projects;

public partial class Chip8EmulatorProjectPage : ComponentBase
{
    private const string RepositoryUrl = "https://github.com/ldevillard/CHIP8-Emulator";

    private static readonly ProjectChip[] LinkChips =
    [
        new("GitHub repository", Color.Secondary, Icons.Custom.Brands.GitHub, RepositoryUrl),
    ];

    private static readonly ProjectChip[] TechChips =
    [
        new("OpenGL", Color.Warning),
        new("C++", Color.Warning)
    ];

    private static readonly string[] SummaryParagraphs =
    [
        "As Chip-8 is a tiny 8-bit system, it gave me a first introduction to emulation and helped me better understand how older systems work under the hood.",
        "Chip-8 Emulator started as a small playground project to learn how a full interpreter works: reading opcodes from memory, decoding them, and handling timers, keypad input, and display updates.",
        "To make experimentation quick, it includes hot reload of ROMs, a tiny built-in editor using ImGui, and a debug overlay that shows registers while the game is running.",
    ];

    private const string NextStep = "Next step: It could be interesting to add save states, allowing snapshots to be captured and restored at runtime.";

    private const string ChallengesIntro = "Here are a few interesting problems that came up while turning a tiny emulator into a usable tool for testing and iterating on ROMs.";

    private static readonly ProjectFeature[] Features =
    [
        new(
            "Complete opcode interpreter",
            "Implements the full Chip-8 instruction set with timers, keypad mapping, stack/program counters management, and configurable clock speed.",
            Icons.Material.Filled.Memory),
        new(
            "Live ROM reload + mini editor",
            "Reload or reset ROMs at runtime without restarting the app, while automatically detecting any ROMs placed in the dedicated folder.\n",
            Icons.Material.Filled.Bolt),
        new(
            "Runtime debug overlay",
            "On-screen registers to view program flow while running.",
            Icons.Material.Filled.BugReport),
        new(
            "Editor integrated display",
            "64×32 framebuffer rendered with OpenGL and presented through ImGui in a retro-inspired display view.",
            Icons.Material.Filled.Monitor)
    ];

    private static readonly ProjectChallenge[] Challenges =
    [
        new(
            "Placeholder challenge 1",
            ["Placeholder challenge first line.",
                "Placeholder challenge additional detail line.",
                "Placeholder challenge conclusion or solution summary."],
            Icons.Material.Filled.Memory),
        new(
            "Placeholder challenge 2",
            ["Placeholder challenge first line.",
                "Placeholder challenge additional detail line.",
                "Placeholder challenge conclusion or solution summary."],
            Icons.Material.Filled.Collections),
        new(
            "Placeholder challenge 3", 
            ["Placeholder challenge first line.",
                "Placeholder challenge additional detail line.",
                "Placeholder challenge conclusion or solution summary."],
            Icons.Material.Filled.Save),
        new(
            "Placeholder challenge 4",
            ["Placeholder challenge first line.",
                "Placeholder challenge additional detail line.",
                "Placeholder challenge conclusion or solution summary."],
            Icons.Material.Filled.Gesture)
    ];

    private static readonly ProjectShowcase[] ShowcaseItems =
    [
        new(
            "Game View",
            "A view of different Chip-8 ROMS running on the emulator.",
            "images/projects/chip-8/chip-8.gif"),
        new(
            "Editor View",
            "The editor of the emulator with hot reloading and registers view.",
            "images/projects/chip-8/chip-8-editor.gif")
    ];

    private static readonly ProjectSourceLink[] Sources =
    [
        new(
            "Cowgod's Chip-8 Technical Reference",
            "http://devernay.free.fr/hacks/chip8/C8TECH10.HTM"),
        new(
            "Austin Morlan: Chip8 Emulator",
            "https://austinmorlan.com/posts/chip8_emulator/")
    ];
}
