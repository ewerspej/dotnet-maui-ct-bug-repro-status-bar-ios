# dotnet-maui-ct-bug-repro-status-bar-ios
The StatusBarBehavior leads to the status bar background showing up in the upper left corner when rotating into landscape mode on iOS, which is incorrect since iOS hides the status bar entirely in landscape mode

**Screenshots**

Portrait:
<div>
  <img align="top" src="status_bar_portrait.PNG" width="400"/>
</div>
</br>

Landscape:
<div>
  <img align="top" src="status_bar_landscape.PNG" height="400"/>
</div>
</br></br>

**MauiProgram.cs**
```c#
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
}

```

**MainPage.xaml.cs**
```c#
public partial class MainPage : ContentPage
{
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
}

```
