using ZXing.Net.Maui;

namespace Vi_Scout;

public partial class ImportPage : ContentPage
{
	public ImportPage()
	{
		InitializeComponent();
        cameraBarcodeReaderView.Options = new BarcodeReaderOptions
        {
            Formats = BarcodeFormats.TwoDimensional,
            AutoRotate = true,
            Multiple = true
        };
    }

	protected async void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
	{
        string Output = "";
        foreach (var barcode in e.Results)
            Output  = $"Barcodes: {barcode.Format} -> {barcode.Value}";

        //await DisplayAlert("Alert", Output, "OK");


        //    OutputLabel.Dispatcher.DispatchAsync(new Action(
        //        () =>
        //        {
        //            OutputLabel.Text = Output;
        //        }
        //));

        /*Dispatcher.DispatchAsync(new Action(
            () =>
            {
                DisplayAlert("Alert", Output, "OK");
            }
    ));*/


    }
}