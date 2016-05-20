using System.Diagnostics;
using System.Windows;
using MahApps.Metro.Controls;

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

        private void BtnGenerateSignature_OnClick(object sender, RoutedEventArgs e)
        {
            ShowChildWindow(new SigMaker());
        }

        private void btnCreatePatch_Click(object sender, RoutedEventArgs e)
        {
            ShowChildWindow(new PatchCreator());
        }

        private void btnApplyPatch_Click(object sender, RoutedEventArgs e)
        {
            ShowChildWindow(new PatchApplier());
        }

        private void ShowChildWindow(MetroWindow childWindow)
        {
            childWindow.Owner = this;
            childWindow.ShowDialog();
        }
    }
}