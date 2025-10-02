using Android.App;
using Android.Content.PM;
using Avalonia;
using Avalonia.Android;

namespace BeebopNovuMinimal.Android;

[Activity(Label = "BeebopNovuMinimal", Theme = "@style/MyTheme.NoActionBar", MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity<BeebopNovuMinimal.App> { }
