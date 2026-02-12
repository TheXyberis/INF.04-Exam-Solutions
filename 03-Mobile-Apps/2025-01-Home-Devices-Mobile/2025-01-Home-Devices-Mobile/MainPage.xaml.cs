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
                    WashingResultLabel.Text = $"Numer prania: {programNum}";
                }
                else
                {
                    WashingResultLabel.Text = "Numer prania nie podano";
                }
            }
        }
        private void OnVacuum_Clicked(object sender, EventArgs e)
        {
            _isVacuumOn = !_isVacuumOn;
            if (_isVacuumOn)
            {
                VacuumButton.Text = "Wyłącz";
                VacuumStatusLabel.Text = "Odkurzac włączony";
            }
            else
            {
                VacuumButton.Text = "Włącz";
                VacuumStatusLabel.Text = "Odkurzac wyłączony";
            }
        }
    }
}
