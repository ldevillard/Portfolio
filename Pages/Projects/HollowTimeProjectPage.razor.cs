using Microsoft.AspNetCore.Components;
using MudBlazor;
using Portfolio.Components.Projects;

namespace Portfolio.Pages.Projects;

public partial class HollowTimeProjectPage : ComponentBase
{
    private const string RepositoryUrl = "https://github.com/ldevillard/HollowTime";
    private const string ArticleUrl = "https://example.com/hollowtime-article-placeholder";
    private const string DemoUrl = "https://example.com/hollowtime-demo-placeholder";

    private static readonly ProjectChip[] LinkChips =
    [
        new("GitHub repository", Color.Secondary, Icons.Custom.Brands.GitHub, RepositoryUrl),
        new("Related article", Color.Secondary, Icons.Material.Filled.Article, ArticleUrl),
        new("Try it out", Color.Success, Icons.Material.Filled.ArrowOutward, DemoUrl)
    ];

    private static readonly ProjectChip[] TechChips =
    [
        new("Placeholder Tech 1", Color.Warning),
        new("Placeholder Tech 2", Color.Warning)
    ];

    private static readonly string[] SummaryParagraphs =
    [
        "Placeholder paragraph summarizing the Hollow Time project and its overall goals.",
        "Placeholder paragraph describing UX, timer features, and performance considerations.",
        "Placeholder paragraph about learnings, experimentation opportunities, and future improvements."
    ];

    private const string NextStep = "Placeholder next step to highlight a planned improvement or experiment for this timer.";

    private const string ChallengesIntro = "Placeholder overview of technical or design challenges encountered while building this timer.";

    private static readonly ProjectFeature[] Features =
    [
        new(
            "Placeholder feature title 1",
            "Placeholder feature description detailing timing capability or UI element.",
            Icons.Material.Filled.Timer),
        new(
            "Placeholder feature title 2",
            "Placeholder feature description exploring customization, sessions, or scrambles.",
            Icons.Material.Filled.Tune),
        new(
            "Placeholder feature title 3",
            "Placeholder feature description covering persistence, statistics, or analytics.",
            Icons.Material.Filled.Insights),
        new(
            "Placeholder feature title 4",
            "Placeholder feature description about accessibility, responsive layout, or shortcuts.",
            Icons.Material.Filled.Accessibility)
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
            "Placeholder visual 1",
            "Placeholder description for first visual.",
            "images/timer.png"),
        new(
            "Placeholder visual 2",
            "Placeholder description for second visual.",
            "images/timer.png"),
        new(
            "Placeholder visual 3",
            "Placeholder description for third visual.",
            "images/timer.png"),
        new(
            "Placeholder visual 4",
            "Placeholder description for fourth visual.",
            "images/timer.png")
    ];

    private static readonly ProjectSourceLink[] Sources =
    [
        new(
            "Placeholder source 1",
            "https://example.com/source-1"),
        new(
            "Placeholder source 2",
            "https://example.com/source-2"),
        new(
            "Placeholder source 3",
            "https://example.com/source-3"),
        new(
            "Placeholder source 4",
            "https://example.com/source-4")
    ];
}
