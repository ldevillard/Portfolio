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
        "To make experimentation quick, it includes hot reload of ROMs, a tiny built-in editor using ImGui, and a debug overlay that shows registers while the ROM is running.",
    ];

    private const string NextStep = "Next step: It could be interesting to add save states, allowing snapshots to be captured and restored at runtime.";

    private const string ChallengesIntro = "Because I was still new to emulation, this project led me to tackle my first real challenges in the area while turning a small emulator into a practical tool for testing and iterating on ROMs.";

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
            "Respect the interpreter specifications",
            ["Implemented the full Chip-8 was one of the main emulator challenges:",
                "Getting every opcode, timer, stack, and memory rule to behave like the reference implementation.",
                "This meant handling details, such as 60 Hz timers, collision flags, screen wrapping, and the different shift/load quirks used by some ROMs.",
                "I iterated using test ROMs to validate that all opcodes were running as intended."],
            Icons.Material.Filled.Memory),
        new(
            "Opcode dispatch tables",
            ["I needed to find a clean way to organize opcode decoding without ending up with a giant switch statement.",
                "I organized the 16 primary opcode groups and main sub-groups (0x0, 0x8, 0xE, 0xF) into function-pointer tables.",
                "This way, the interpreter does a single lookup per instruction, and opcode behavior is easier to audit and evolve."],
            Icons.Material.Filled.TableChart),
        new(
            "Hot reload with clean state", 
            ["I wanted to enable the emulator to reload or reset ROMs at runtime.",
                "To achieve this, at startup, the emulator scans the dedicated folder for ROM paths and displays them for selection in an ImGui menu.",
                "Each reload/reset clears the registers, stack, timers, memory and program counter, ensuring that the next ROM always boots from an initial state."],
            Icons.Material.Filled.Bolt),
        new(
            "Bridging Input and Rendering",
            ["One of the practical decision I had to make was deciding how to represent the Chip-8 display in a way that stayed simple to update and easy to render.\n",
                "Since I was still learning and wanted a clean path between the emulator and the graphics layer, I chose to store the 64×32 framebuffer directly as an RGBA buffer instead of keeping a packed bit-buffer and converting it every frame before upload.",
                "This way, the emulator can send its framebuffer directly to OpenGL with no extra per-frame conversion step, which kept the rendering path simpler and easier to work with.",
                "SDL key events were also mapped to the 16-key Chip-8 keypad so the whole input/output path stayed straightforward."],
            Icons.Material.Filled.CompareArrows)
    ];

    private static readonly ProjectShowcase[] ShowcaseItems =
    [
        new(
            "Game View",
            "A view of different Chip-8 ROMs running on the emulator.",
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
