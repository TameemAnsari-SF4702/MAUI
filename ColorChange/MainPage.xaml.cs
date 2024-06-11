using System.Drawing;

namespace ColorChange
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var res=await DisplayAlert("Alert", "Can I chnage my color?", "ok", "cancel");
            if (res) {
                CounterBtn.BackgroundColor = Colors.Black;
                CounterBtn.TextColor = Colors.White;
            }

        }
    }

}
