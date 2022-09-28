using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;

namespace bug_repro_status_bar_ios;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();

        var statusBarBehavior = new StatusBarBehavior
        {
            StatusBarColor = Color.FromArgb("#004469"),
            StatusBarStyle = StatusBarStyle.LightContent
        };

        Behaviors.Add(statusBarBehavior);
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

