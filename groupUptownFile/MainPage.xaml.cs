namespace groupUptownFile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       private void OnButtonClicked(object sender, EventArgs e)
     {
    DisplayAlert("Message", "Button Clicked!", "OK");
       }
    }
}
