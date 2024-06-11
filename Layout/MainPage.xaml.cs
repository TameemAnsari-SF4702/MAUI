namespace Layout
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void range_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
        {
            height.Text = e.NewValue.ToString() + "cm";
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            int value = int.Parse(weight.Text);
            value++;
            weight.Text = value.ToString();
        }

        private void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            int value = int.Parse(weight.Text);
            value--;
            weight.Text = value.ToString();
        }

        private void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            int value = int.Parse(age.Text);
            value++;
            age.Text = value.ToString();
        }

        private void Button_Clicked_3(System.Object sender, System.EventArgs e)
        {
            int value = int.Parse(age.Text);
            value--;
            age.Text = value.ToString();
        }
    }

}
