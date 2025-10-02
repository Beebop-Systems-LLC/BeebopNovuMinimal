# BeebopNovuMinimal
Test Solution to identify inheritance problems
This solution generates three compile errors 

The type 'BeebopNovuMinimal.App' cannot be used as type parameter 'TApp' in the generic type or method 'AvaloniaMainActivity<TApp>'. There is no implicit reference conversion from 'BeebopNovuMinimal.App' to 'Avalonia.Application'. in MainActivity.cs

'App.InitializePlatformSpecific()': no suitable method found to override in App.Android.Partial.cs

'App.ConfigurePlatformSpecificServices(IServiceCollection)': no suitable method found to override in App.Andriod.cs 

Chatgpt 
Ah — the errors confirm that the Android partial class is being treated as a new App class instead of merging with the base project. This is the classic partial class / project reference issue in Xamarin/Android + Avalonia.

Why this happens

The Android project references the base project DLL.

It also compiles its own App.Android.Partial.cs as a separate class App in the same namespace.

MSBuild sees two conflicting App types:

App from base project DLL

App from Android project compilation

Hence, the overrides fail and the type cannot be used as TApp.
