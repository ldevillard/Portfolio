using Microsoft.AspNetCore.Components;

namespace Portfolio.Components.Projects;

public partial class ProjectChallenges : ComponentBase
{
    [Parameter] public string Title { get; set; } = "Challenges";
    [Parameter] public string? IntroText { get; set; }
    [Parameter] public IReadOnlyList<ProjectChallenge> Challenges { get; set; } = Array.Empty<ProjectChallenge>();

    private bool[] _challengeExpanded = Array.Empty<bool>();
    private ChallengeView[] _challengeViews = Array.Empty<ChallengeView>();

    protected override void OnParametersSet()
    {
        _challengeViews = Challenges
            .Select(c =>
            {
                string firstLine = (c.DescriptionLines != null && c.DescriptionLines.Length > 0) ? c.DescriptionLines[0] : string.Empty;
                string[] restLines = (c.DescriptionLines != null && c.DescriptionLines.Length > 1) ? c.DescriptionLines[1..] : Array.Empty<string>();
                return new ChallengeView(c.Title, c.Icon, firstLine, restLines);
            })
            .ToArray();

        EnsureExpandedSize();
    }

    private void ToggleChallenge(int index)
    {
        EnsureExpandedSize();

        if ((uint)index >= _challengeExpanded.Length)
        {
            return;
        }

        _challengeExpanded[index] = !_challengeExpanded[index];
        StateHasChanged();
    }

    private string GetToggleLabel(int index)
    {
        EnsureExpandedSize();

        return (uint)index < _challengeExpanded.Length && _challengeExpanded[index]
            ? "Less details"
            : "More details";
    }

    private int EnsureExpandedSize()
    {
        if (_challengeExpanded == null || _challengeExpanded.Length != _challengeViews.Length)
        {
            _challengeExpanded = new bool[_challengeViews.Length];
        }

        return _challengeExpanded.Length;
    }

    private sealed record ChallengeView(string Title, string Icon, string FirstLine, string[] RestLines);
}
