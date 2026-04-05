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
        new("Try it out", Color.Success, Icons.Material.Filled.ArrowOutward, "https://ldevillard.github.io/HollowTime/"),
        new("Competition Results", Color.Info, Icons.Material.Filled.Leaderboard, "https://www.worldcubeassociation.org/persons/2015DEVI01")
    ];

    private static readonly ProjectChip[] TechChips =
    [
        new("Blazor", Color.Warning),
        new("C#", Color.Warning),
        new("Js", Color.Warning),
    ];

    private static readonly string[] SummaryParagraphs =
    [
        "Hollow Time is a personal web application built from my interest in competitive speedcubing and my desire to create a timer tailored to my own workflow.",
        "As I regularly practice solving Rubik’s cubes, I wanted a simple and reliable tool to generate scrambles, record solve times, and track performance over time. Building this project was also an opportunity to explore modern web development using Blazor and to set up an automated deployment workflow.",
        "The application supports official scrambles for multiple cube categories, tracks solve history and averages, and provides both 2D and 3D visualization of scrambles to better understand each configuration.",
        "This project allowed me to connect a personal hobby with software development, while gaining hands-on experience in building, deploying, and maintaining a real-world web application."
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
            "Hollow Time Website",
            "A visual of the hollow time website.",
            "images/projects/hollow-time/timer.png"),
        new(
            "Timer Demo",
            "A small demo on how to use it.",
            "images/projects/hollow-time/demo.gif"),
    ];

    private static readonly ProjectSourceLink[] Sources =
    [
        new(
            "The MudBlazor UI library",
            "https://mudblazor.com/"),
        new(
            "Blazor University",
            "https://blazor-university.com/"),
        new(
            "The cubing.js library",
            "https://js.cubing.net/cubing/"),
        new(
            "The CsTimer",
            "https://cstimer.net/"),
    ];
}
