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
        "Hollow Time is a personal web application built from my interest in competitive speedcubing and my desire to create my own timer.",
        "As I regularly practice solving Rubik’s cubes, I wanted a simple and reliable tool to generate scrambles, record solve times, and track performance over time. Building this project was also an opportunity to explore modern web development using Blazor and to set up an automated deployment workflow.",
        "The application supports official scrambles for multiple cube categories, tracks solve history and averages, and provides both 2D and 3D visualization of scrambles to better understand each configuration.",
        "This project allowed me to connect a personal hobby with software development, while gaining hands-on experience in building, deploying, and maintaining a real web application."
    ];

    private const string NextStep = "Next step: I would like to explore simple ways to share solve results with friends, such as lightweight leaderboards or small online sessions.";

    private const string ChallengesIntro = "Here are a few challenges that came up while building this application. Several of them were related to handling real-time interactions in the browser, and ensuring that the application remained simple and reliable for everyday use.";

    private static readonly ProjectFeature[] Features =
    [
        new(
            "Multiple scramble support",
            "Generate official scrambles for multiple cube categories following World Cube Association standards.",
            Icons.Material.Filled.Shuffle),
        new(
            "Performance tracking",
            "Record solve history and compute averages over time.",
            Icons.Material.Filled.QueryStats),
        new(
            "2D and 3D scramble visualization",
            "Display scrambles visually to better understand cube states before solving.",
            Icons.Material.Filled.ViewInAr),
        new(
            "Automated deployment workflow",
            "Set up a GitHub-based CI workflow to automatically build and deploy the application to GitHub Pages.",
            Icons.Material.Filled.CloudDone)
    ];

    private static readonly ProjectChallenge[] Challenges =
    [
        new(
            "Accurate and reliable timing",
            ["A core requirement of a cube timer is providing consistent and precise time measurements.",
                "Handling user input events while ensuring the timer starts and stops reliably required careful coordination between keyboard handling and application state.",
                "Special attention was given to avoiding unintended resets or timing inconsistencies, ensuring that recorded times remain valid during regular practice sessions."],
            Icons.Material.Filled.Speed),
        new(
            "Tracking solve history and averages",
            ["Tracking solve times involved more than simply storing values.",
                "The application needed to compute averages, detect the best performance, and update the interface immediately after each solve.",
                "To support this, dedicated components were designed to manage solve history and recompute statistics incrementally as new times were recorded.",
                "Special care was taken to highlight the best results visually, allowing users to quickly understand their progress without manually analyzing the data."],
            Icons.Material.Filled.Insights),
        new(
            "Integrating libraries through JavaScript interop",
            ["Generating official scrambles and visualizing the cube required using existing JavaScript libraries rather than building everything from scratch.",
                "Since the application is built with Blazor, these libraries were integrated using JavaScript interop, requiring a simple and reliable way to exchange data between the .NET and JavaScript parts of the application.",
                "This approach allowed the project to stay focused on usability while leveraging well-tested tools for scramble generation and cube visualization."],
            Icons.Material.Filled.IntegrationInstructions),
        new(
            "Automated deployment workflow",
            ["I wanted the application to be easily accessible without manual deployment steps after each update.",
                "To achieve this, a GitHub-based workflow was set up to automatically build and deploy the application to GitHub Pages whenever changes were pushed to the repository.",
                "Establishing this pipeline simplified the development process and ensured that the live version of the application always stayed up to date."],
            Icons.Material.Filled.CloudSync)
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
