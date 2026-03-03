namespace groupUptownFile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

      private async void OnHomeClicked(object sender, EventArgs e)
 {
     await DisplayAlert("Home", "Home button clicked!", "OK");
 }

 private async void OnProfileClicked(object sender, EventArgs e)
 {
     await DisplayAlert("Profile", "Profile button clicked!", "OK");
 }

 private async void OnSettingsClicked(object sender, EventArgs e)
 {
     await DisplayAlert("Settings", "Settings button clicked!", "OK");
 }

 private async void OnAboutClicked(object sender, EventArgs e)
 {
     await DisplayAlert("About Us", "About Us button clicked!", "OK");
 }

 private async void OnShortcutClicked(object sender, EventArgs e)
 {
     await DisplayAlert("Shortcut", "Shortcut button clicked!", "OK");
 }
    }
}
