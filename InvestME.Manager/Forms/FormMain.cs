using System.Diagnostics;

namespace InvestME.Manager.Forms
{
    public partial class FormMain : FormDefault
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnImportFile_Click(object sender, EventArgs e)
        {
            FormImportData formOn = new FormImportData();
            formOn.ShowDialog();
        }

        private void btnOpenPowerBI_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo pi = new ProcessStartInfo();
            pi.UseShellExecute = true;
            pi.FileName = Directory.GetCurrentDirectory() + @"\Resources\powerBI.pbix";
            p.StartInfo = pi;
            try
            {
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddInvest_Click(object sender, EventArgs e)
        {
            FormAddInvest formOn = new FormAddInvest();
            formOn.ShowDialog();
        }
    }
}