using Avalonia;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using LoadingAnimation.Avalonia.Animators;
using LoadingAnimation.Avalonia.ViewModels;
using LoadingAnimation.Avalonia.Views;

namespace LoadingAnimation.Avalonia
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                // Line below is needed to remove Avalonia data validation.
                // Without this line you will get duplicate validations from both Avalonia and CT
                BindingPlugins.DataValidators.RemoveAt(0);
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                    Width = 700,
                    Height = 450,
                    WindowStartupLocation = WindowStartupLocation.CenterScreen,
                };
                Animation.RegisterCustomAnimator<Geometry, GeometryAnimator>();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}