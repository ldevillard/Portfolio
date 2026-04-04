using MudBlazor;

namespace Portfolio.Components.Projects;

public sealed record ProjectChip(string Label, Color Color, string? Icon = null, string? Href = null, string Target = "_blank");

public sealed record ProjectFeature(string Title, string Description, string Icon);

public sealed record ProjectChallenge(string Title, string[] DescriptionLines, string Icon);

public sealed record ProjectShowcase(string Title, string Description, string ImageSrc);
