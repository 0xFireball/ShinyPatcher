using System;
using System.Threading.Tasks;
using System.Windows;
using MahApps.Metro.Controls.Dialogs;
using Octodiff.CommandLine;

namespace ZetaPatcher
{
    /// <summary>
    /// Interaction logic for SigMaker.xaml
    /// </summary>
    public partial class SigMaker
    {
        private string _basisFile = null;
        private string _sigFile = null;

        public SigMaker()
        {
            InitializeComponent();
        }

        private void btnSelectBasisFile_Click(object sender, RoutedEventArgs e)
        {
            _basisFile = ZetaPatcherCommon.BrowseForOpenFile("All Files (*.*)|*.*", "Select Basis File");
            txtInst1.Text = _basisFile ?? txtInst1.Text;
        }

        private async void btnGenerateSig_Click(object sender, RoutedEventArgs e)
        {
            _sigFile = ZetaPatcherCommon.BrowseForSaveFile("Signature Files (*.sig)|*.sig|All Files (*.*)|*.*", "Select Output File");
            if (_basisFile == null || _sigFile == null)
            {
                await this.ShowMessageAsync("Error", "Please specify all input files.");
                return;
            }
            int exitCode = await Task.Run(()=>RunSignatureCommand());
            if (exitCode == 0)
                await this.ShowMessageAsync("Success", "The operation completed successfully.");
            else
                await this.ShowMessageAsync("Error", $"The operation exited with code {exitCode}");
            this.Close();
        }

        int RunSignatureCommand()
        {
            SignatureCommand sigComm = new SignatureCommand();
            return sigComm.Execute(new string[] { _basisFile, _sigFile, "2048", "false" });
        }
    }
}