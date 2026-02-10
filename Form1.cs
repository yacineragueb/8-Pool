using System.Windows.Forms;

namespace _8Pool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void poolTable_TableCompleted(object sender, PoolTable.TableCompletedEventArgs e)
        {
            MessageBox.Show($"Time Consumed: {e.TimeText}, Total Seconds: {e.TimeInSeconds}, Rate Par Hour: {e.RatePerHour}, Total Fees: {e.TotalFees}.");
        }
    }
}
