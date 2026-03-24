using MudBlazor;

namespace Portfolio.Themes
{
    public static class Theme
    {
        public static MudTheme PortfolioTheme = new MudTheme()
        {
            PaletteDark = new PaletteDark()
            {
                Primary = "#E6DED3",
                Secondary = "#B8B0A6",

                Background = "#3A3B49",
                Surface = "#3F4050",
                AppbarBackground = "#2D2E3A",
                DrawerBackground = "#2F303C",

                TextPrimary = "#F4EEE6",
                TextSecondary = "#D2CBC2",

                DrawerText = "#EEE6DC",
                DrawerIcon = "#D8D0C6",

                ActionDefault = "#D0C7BC",
                ActionDisabled = "rgba(255,255,255,0.26)",
                ActionDisabledBackground = "rgba(255,255,255,0.12)",

                Divider = "rgba(255,255,255,0.08)",
                LinesDefault = "rgba(255,255,255,0.08)",

                Success = "#9CAF88",
                Warning = "#C8AE7D",
                Error = "#C88F8F",
                Info = "#9AAFC2"
            }
        };
    }
}
