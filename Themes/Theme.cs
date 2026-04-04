using MudBlazor;

namespace Portfolio.Themes
{
    public static class Theme
    {
        public static MudTheme PortfolioTheme = new MudTheme()
        {
            PaletteDark = new PaletteDark()
            {
                Primary = "#a89c8a",
                Secondary = "#E2D4BE",
                Tertiary = "#8a7651",

                Background = "#262732",
                Surface = "#353747",
                AppbarBackground = "#2B2D38",
                DrawerBackground = "#2E303C",

                TextPrimary = "#F4EEE6",
                TextSecondary = "#CBC4BA",

                DrawerText = "#EEE6DC",
                DrawerIcon = "#D8D0C6",

                ActionDefault = "#D0C7BC",
                ActionDisabled = "rgba(255,255,255,0.26)",
                ActionDisabledBackground = "rgba(255,255,255,0.12)",

                Divider = "rgba(255,255,255,0.08)",
                LinesDefault = "rgba(255,255,255,0.08)",

                Success = "#9cc472",
                Warning = "#C8AE7D",
                Error = "#c27070",
                Info = "#769dc2"
            }
        };
    }
}
