namespace Vi_Scout;

public partial class ScoutingPage : ContentPage
{
	public ScoutingPage()
	{
		InitializeComponent();
        BindingContext = this;
	}

    public string QualificationMatchNumber { get; set; } = "13";
    public string TeamNum { get; set; } = "5167";

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
		
    }
}