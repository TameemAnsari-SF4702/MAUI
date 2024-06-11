namespace PhoneWord
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
           
        }

        public void Translate_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (word.Text!=null)
            {
                string result = WordConverter.Translator(word.Text.ToUpper());
                CallBtn.Text = "call" + result;
            }
            
        }

        private void Calling_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            CallingWindow.IsVisible = true;
            DefaultWindow.Opacity = 0.3;
        }

        private void EndCallButton_Clicked(object sender, EventArgs e)
        {
            CallingWindow.IsVisible= false;
            DefaultWindow.Opacity = 1;
        }
    }

}
