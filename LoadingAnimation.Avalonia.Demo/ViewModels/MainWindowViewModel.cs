namespace LoadingAnimation.Avalonia.Demo.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
#pragma warning disable CA1822 // Mark members as static
        public string TestStr => "加载中...";
#pragma warning restore CA1822 // Mark members as static
    }
}
