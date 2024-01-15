namespace Vi_Scout
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
            await Navigation.PushAsync(new ScoutingPage());
            count++;

            /*
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";
            */
            //SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void NavToImportPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImportPage());
        }
        private async void NavToExportPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExportPage());
        }
    }

}
