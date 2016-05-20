using System.Diagnostics;
using System.Windows;

namespace ZetaPatcher
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnProjectPage_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://zetaphase.github.io/ZetaPatcher");
        }

        private void BtnZetaPhase_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://zetaphase.io");
        }
    }
}