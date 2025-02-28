using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using System.Linq;
using System.Runtime.CompilerServices;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;
using idv_bpsys_avalonia.ViewModels;
using idv_bpsys_avalonia.Views;

namespace idv_bpsys_avalonia;

public partial class App : Application
{
    public static App AppBase { get; set; }
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
        AppBase = this;
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Avoid duplicate validations from both Avalonia and the CommunityToolkit. 
            // More info: https://docs.avaloniaui.net/docs/guides/development-guides/data-validation#manage-validationplugins
            DisableAvaloniaDataAnnotationValidation();
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    public void ChangeTheme()
    {
        this.RequestedThemeVariant = 
            this.RequestedThemeVariant == ThemeVariant.Light 
                ? ThemeVariant.Dark 
                : ThemeVariant.Light;
        
    }
    
    private void DisableAvaloniaDataAnnotationValidation()
    {
        // Get an array of plugins to remove
        var dataValidationPluginsToRemove =
            BindingPlugins.DataValidators.OfType<DataAnnotationsValidationPlugin>().ToArray();

        // remove each entry found
        foreach (var plugin in dataValidationPluginsToRemove)
        {
            BindingPlugins.DataValidators.Remove(plugin);
        }
    }
}