namespace _2025_01_Home_Devices_Mobile
{
    public partial class MainPage : ContentPage
    {
        private bool _isVacuumOn = false;
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnWashing_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(WashingEntry.Text, out int programNum))
            {
                if (programNum >= 1 && programNum <= 12)
                {
                    WashingResultLabel.Text = $"Washing number: {programNum}";
                }
                else
                {
                    WashingResultLabel.Text = "Washing number not provided";
                }
            }
        }
        private void OnVacuum_Clicked(object sender, EventArgs e)
        {
            _isVacuumOn = !_isVacuumOn;
            if (_isVacuumOn)
            {
                VacuumButton.Text = "Turn Off";
                VacuumStatusLabel.Text = "Vacuum is ON";
            }
            else
            {
                VacuumButton.Text = "Turn On";
                VacuumStatusLabel.Text = "Vacuum is OFF";
            }
        }
    }
}
