using Avalonia.Controls;


namespace LoadingAnimation.Avalonia.Demo.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object? sender, SelectionChangedEventArgs e)
        {
            if (!IsLoaded)
            {
                return;
            }
            if (e.AddedItems[0] == null)
            {
                return;
            }

            var item = ((ContentControl)e.AddedItems[0]).Content.ToString();
            switch (item)
            {
                case "The Classic":
                    MainContent.Content = new ClassicPage();
                    break;
                case "The Dots":
                    MainContent.Content = new DotsPage();
                    break;
                case "The Bars":
                    MainContent.Content = new BarsPage();
                    break;
                case "The Spinner":
                    MainContent.Content = new SpinnerPage();
                    break;
                default:
                    break;
            }
        }
    }
}