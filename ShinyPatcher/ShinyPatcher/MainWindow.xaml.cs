using MahApps.Metro.Controls;
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

        private void ProjectPageClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://zetaphase.github.io/ZetaPatcher");
        }

        private void ZetaPhaseClick(object sender, RoutedEventArgs e)
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