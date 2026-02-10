using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace _8Pool
{
    public partial class PoolTable : UserControl
    {
        private int seconds = 0;
        enum enMode { Start =  0, Pause = 1 }

        enMode CurrentMode = enMode.Start;

        private float _HourlyRate = 10;
        private string _PlayerName = "Player Name";
        private string _TableTitle = "Table Title";

        [Category("Pool Config")]
        public float HourlyRate 
        { 
            get {
                    return _HourlyRate;
                }

            set {
                _HourlyRate = value;
            }
        }

        [Category("Pool Config")]
        public string TableTitle
        {
            get
            {
                return _TableTitle;
            }

            set
            {
                _TableTitle = value;

                gbTable.Text = _TableTitle;
            }
        }

        [Category("Pool Config")]
        public string PlayerName
        {
            get
            {
                return _PlayerName;
            }

            set
            {
                _PlayerName = value;

                lblPlayerName.Text = _PlayerName;
            }
        }

        public class TableCompletedEventArgs : EventArgs
        {
            public string TimeText { get; }
            public int TimeInSeconds { get; }
            public float RatePerHour { get; }
            public float TotalFees { get; }
            public TableCompletedEventArgs(string TimeText, int TimeInSeconds, float RatePerHour, float TotalFees)
            {
                this.TimeText = TimeText;
                this.TimeInSeconds = TimeInSeconds;
                this.RatePerHour = RatePerHour;
                this.TotalFees = TotalFees;
            }
        }

        public event EventHandler<TableCompletedEventArgs> TableCompleted;

        public PoolTable()
        {
            InitializeComponent();
        }

        private void RaiseOnTableCompleted(string TimeText, int TimeInSeconds, float RatePerHour, float TotalFees)
        {
            TableCompletedEventArgs e = new TableCompletedEventArgs(TimeText, TimeInSeconds, RatePerHour, TotalFees);
            RaiseOnTableCompleted(e);
        }

        private void RaiseOnTableCompleted(TableCompletedEventArgs e)
        {
            TableCompleted?.Invoke(this, e);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer.Stop();
            float TotalFees = seconds * HourlyRate / 3600;
            RaiseOnTableCompleted(lblTime.Text, seconds, HourlyRate, TotalFees);
            seconds = 0;
            CurrentMode = enMode.Start;
            lblTime.Text = "00:00:00";
            btnStartPause.Text = "Start";
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            switch(CurrentMode)
            {
                case enMode.Start:
                    timer.Start();
                    btnStartPause.Text = "Pause";
                    CurrentMode = enMode.Pause;
                    break;

                case enMode.Pause:
                    timer.Stop();
                    btnStartPause.Text = "Start";
                    CurrentMode = enMode.Start;
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTime.Text = TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
        }
    }
}
